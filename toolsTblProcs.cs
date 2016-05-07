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
            StreamReader strcIn = new StreamReader(Vars.structuurInput);
            //try
            //{ 
                regel = strcIn.ReadLine();
                //splitsRegel(regel);
                //recordstrc[teller, 0] = rgldeel1;
                //recordstrc[teller, 1] = rgldeel2;
                //recordstrc[teller, 2] = rgldeel3;
                //teller++;

                while (regel != null)
                {
                    try
                    {
                    splitsRegel(regel.Trim());
                    recordstrc[teller, 0] = rgldeel1;
                    recordstrc[teller, 1] = rgldeel2;
                    recordstrc[teller, 2] = rgldeel3;
                    teller++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fout {0} bij splitsen van structuurfile (Regel: {1})", ex.Message + " - " + regel.ToString());
                }
                regel = strcIn.ReadLine();
            }
            strcIn.Close();
        }

        public void voerUit()
        {
            init();
            leesStructuurFile();

            //StreamReader tblProcIn = new StreamReader(Vars.tabelProceduresInput);
            //StreamWriter tblProcOut = new StreamWriter(Vars.tabelProceduresOutput);



        }

    }
}
