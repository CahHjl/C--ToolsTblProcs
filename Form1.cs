using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vars;
using System.IO;


namespace Tools_TblProcs
{
    public partial class frmToolsTblProcs : Form
    {
        public frmToolsTblProcs()
        {
            InitializeComponent();
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int checkFiles()
        {
            int iOk = 0;
            if (Vars.structuurInput == "")
            {
                MessageBox.Show("Structuur-inputfilenaam is niet opgegevens!");
                iOk++;
            }
            else
            {
                if (File.Exists(Vars.structuurInput) == false)
                {
                    MessageBox.Show("Structuur-inputfilenaam niet gevonden!");
                    iOk++;
                }
            };
            if (Vars.tabelProceduresInput == "")
            {
                MessageBox.Show("Procedures-inputfilenaam is niet opgegevens!");
                iOk++;
            }
            else
            {
                if (File.Exists(Vars.tabelProceduresInput) == false)
                {
                    MessageBox.Show("Procedures-inputfilenaam niet gevonden!");
                    iOk++;
                }
            }
            if (Vars.tabelProceduresOutput == "")
            {
                MessageBox.Show("Structuur-outputfilenaam is niet opgegevens!");
                iOk++;
            }

            return iOk;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Vars.structuurInput = txtbxStructuurInput.Text;
            Vars.tabelProceduresInput = txtbxTabelProceduresInput.Text;
            Vars.tabelProceduresOutput = txtbxTabelProcedureOutput.Text;

            if (checkFiles() == 0)
            {
                ttp.toolsTblProcs ttp = new ttp.toolsTblProcs();
                ttp.voerUit();
            }
        }

        private void txtbxTabelProceduresInput_Leave(object sender, EventArgs e)
        {
            if (txtbxTabelProcedureOutput.Text == "")
            {
                txtbxTabelProcedureOutput.Text=txtbxTabelProceduresInput.Text + "_1";
            }
        }
    }
}
