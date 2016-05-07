using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vars;
using System.IO;
using System.Windows.Forms;

namespace ttp
{
    class toolsTblProcs
    {
        public string[,] recordstrc = new string[60, 3];
        public string regel = "";
        public string regel1 = "";
        public int teller = 0;
        public string rgldeel1;
        public string rgldeel2;
        public string rgldeel3;


        private void splitsRegel(string rgl)
        {
            rgldeel1 = "";
            rgldeel2 = "";
            rgldeel3 = "";

            // 1e deel
            if (rgl != "||")
            {
                int idx = rgl.IndexOf("|");
                if (idx != 0)
                {
                    rgldeel1 = rgl.Substring(0, idx);
                    string rest = rgl.Remove(0, idx + 1);
                    rgl = rest.Trim();
                }
                else
                {
                    if (rgl.Substring(0, 1) == "|")
                    {
                        string rest = rgl.Remove(0, 1);
                        rgl = rest.Trim();
                    }
                }

                // 2e deel
                idx = rgl.IndexOf("|");
                if (idx != 0)
                {
                    rgldeel2 = rgl.Substring(0, idx);
                    string rest = rgl.Remove(0, idx + 1);
                    rgl = rest.Trim();
                }
                else
                {
                    if (rgl.Substring(0, 1) == "|")
                    {
                        string rest = rgl.Remove(0, 1);
                        rgl = rest.Trim();
                    }
                }

                // 3e deel
                if (rgl.Length != 0)
                {
                    rgldeel3 = rgl;
                }

            }
        }


        private void init()
        {
            for (int i = 0; i<60; i++)
			{
                recordstrc[i, 0] = "";
                recordstrc[i, 1] = "";
                recordstrc[i, 2] = "";
            }
        }

        private void leesStructuurFile()
        {
            teller = 0;
            StreamReader strcIn = new StreamReader(Vars.structuurInput);
            regel = strcIn.ReadLine();

            while (regel != null)
            {
                try
                {
                    splitsRegel(regel.Trim());
                    recordstrc[teller, 0] = rgldeel1.Trim();
                    recordstrc[teller, 1] = rgldeel2.Trim();
                    recordstrc[teller, 2] = rgldeel3.Trim();
                    teller++;
                    if (rgldeel1 == "×99") { Vars.arrayTabelStart = teller; }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fout {0} bij splitsen van structuurfile (Regel: {1})", ex.Message + " - " + regel.ToString());
                }
                regel = strcIn.ReadLine();
            }
            strcIn.Close();
            Vars.arrayTotaal = teller--;
        }


        private int zoekParam(string p)
        {

            int ret=0;
            
            int i = 0;
            while (i<61)
            {
                if (recordstrc[i,0] == p)
                {
                    ret = i;
                    i = 60;
                }
                i++;
            }

            return ret;
        }

        private string zoekDataType(string dSoort)
        {
            string ret = "datatype";
            dSoort = dSoort.ToUpper();
            if (dSoort != "")
            {
                if (dSoort == "INTEGER") { ret = "int"; }
                if (dSoort.Substring(0, 7) == "VARCHAR") { ret = "string"; }
                if (dSoort.Substring(0, 4) == "REAL") { ret = "decimal"; }
                if (dSoort == "DATETIME") { ret = "DateTime"; }
            }
            
            return ret;
        }

        private void totaalStructuur(int iPars, string sRegel)
        {
            string dataSoort;
            string uitString;
            int idx = sRegel.IndexOf("×");
            string voor = sRegel.Substring(0, idx);


            int startPositie = zoekParam("×99");
            startPositie++;
            if (iPars == 99)
            {
                int i = startPositie;
                while (i <= 59)
                {
                    if (recordstrc[i, 0] != "")
                    { 
                        dataSoort=zoekDataType(recordstrc[i, 1]);
                        uitString = voor + "public " + dataSoort + " " + recordstrc[i, 0] + " { get; set; }";
                        
                    }    
                    i++;
                }
            }
        }


        public void voerUit()
        {
            init();
            leesStructuurFile();

            StreamReader tblProcIn = new StreamReader(Vars.tabelProceduresInput);
            StreamWriter tblProcOut = new StreamWriter(Vars.tabelProceduresOutput);

            string procRegel = tblProcIn.ReadLine();
            string voor;
            string na;
            string pars;
            string dataSoort;
            int idx;
            bool bTblStruc = false;

            while (procRegel != null)
            {
                while (procRegel.IndexOf("×") != -1)
                {
                    bTblStruc = false;
                    idx = procRegel.IndexOf("×");
                    pars = procRegel.Substring(idx, 3);
                    voor = procRegel.Substring(0, idx);
                    na = procRegel.Substring(idx + 3);
                    if (pars != "×99" && pars != "×98")
                    {
                        procRegel = voor + recordstrc[zoekParam(pars),1] + na;
                    }
                    else
                    {
                        if (pars == "×98") { totaalStructuur(98, procRegel); }
                        else
                        {
                            for (int i = Vars.arrayTabelStart; i < Vars.arrayTotaal; i++)
                            {
                                dataSoort = zoekDataType(recordstrc[i, 1]);
                                procRegel = voor + "public " + dataSoort + " " + recordstrc[i, 0] + " { get; set; }";
                                tblProcOut.WriteLine(procRegel);
                            }
                            totaalStructuur(99, procRegel);
                        }
                        bTblStruc = true;
                    }
                }
                if (bTblStruc == false) { tblProcOut.WriteLine(procRegel); }
                bTblStruc = false;
                procRegel = tblProcIn.ReadLine();
            }

            tblProcIn.Close();
            tblProcOut.Close();



        }

    }
}
