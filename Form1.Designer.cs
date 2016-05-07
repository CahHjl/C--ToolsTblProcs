namespace Tools_TblProcs
{
    partial class frmToolsTblProcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbxStructuurInput = new System.Windows.Forms.TextBox();
            this.txtbxTabelProceduresInput = new System.Windows.Forms.TextBox();
            this.lblStructuurInput = new System.Windows.Forms.Label();
            this.lblTabelProceduresInput = new System.Windows.Forms.Label();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTabelProcedureOutput = new System.Windows.Forms.Label();
            this.txtbxTabelProcedureOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbxStructuurInput
            // 
            this.txtbxStructuurInput.Location = new System.Drawing.Point(219, 57);
            this.txtbxStructuurInput.Name = "txtbxStructuurInput";
            this.txtbxStructuurInput.Size = new System.Drawing.Size(297, 22);
            this.txtbxStructuurInput.TabIndex = 0;
            this.txtbxStructuurInput.Text = "Files\\\\KlBg.txt";
            // 
            // txtbxTabelProceduresInput
            // 
            this.txtbxTabelProceduresInput.Location = new System.Drawing.Point(219, 101);
            this.txtbxTabelProceduresInput.Name = "txtbxTabelProceduresInput";
            this.txtbxTabelProceduresInput.Size = new System.Drawing.Size(297, 22);
            this.txtbxTabelProceduresInput.TabIndex = 1;
            this.txtbxTabelProceduresInput.Text = "Files\\\\Recordstructuur.cs";
            this.txtbxTabelProceduresInput.Leave += new System.EventHandler(this.txtbxTabelProceduresInput_Leave);
            // 
            // lblStructuurInput
            // 
            this.lblStructuurInput.AutoSize = true;
            this.lblStructuurInput.Location = new System.Drawing.Point(26, 60);
            this.lblStructuurInput.Name = "lblStructuurInput";
            this.lblStructuurInput.Size = new System.Drawing.Size(106, 17);
            this.lblStructuurInput.TabIndex = 2;
            this.lblStructuurInput.Text = "Structuur-input:";
            // 
            // lblTabelProceduresInput
            // 
            this.lblTabelProceduresInput.AutoSize = true;
            this.lblTabelProceduresInput.Location = new System.Drawing.Point(26, 104);
            this.lblTabelProceduresInput.Name = "lblTabelProceduresInput";
            this.lblTabelProceduresInput.Size = new System.Drawing.Size(161, 17);
            this.lblTabelProceduresInput.TabIndex = 3;
            this.lblTabelProceduresInput.Text = "Tabel-procedures-input:";
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(415, 266);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(75, 23);
            this.btnSluiten.TabIndex = 4;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(219, 223);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTabelProcedureOutput
            // 
            this.lblTabelProcedureOutput.AutoSize = true;
            this.lblTabelProcedureOutput.Location = new System.Drawing.Point(26, 148);
            this.lblTabelProcedureOutput.Name = "lblTabelProcedureOutput";
            this.lblTabelProcedureOutput.Size = new System.Drawing.Size(170, 17);
            this.lblTabelProcedureOutput.TabIndex = 7;
            this.lblTabelProcedureOutput.Text = "Tabel-procedures-output:";
            // 
            // txtbxTabelProcedureOutput
            // 
            this.txtbxTabelProcedureOutput.Location = new System.Drawing.Point(219, 145);
            this.txtbxTabelProcedureOutput.Name = "txtbxTabelProcedureOutput";
            this.txtbxTabelProcedureOutput.Size = new System.Drawing.Size(297, 22);
            this.txtbxTabelProcedureOutput.TabIndex = 6;
            this.txtbxTabelProcedureOutput.Text = "Files\\\\RecordstructuurUit.cs";
            // 
            // frmToolsTblProcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 301);
            this.Controls.Add(this.lblTabelProcedureOutput);
            this.Controls.Add(this.txtbxTabelProcedureOutput);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.lblTabelProceduresInput);
            this.Controls.Add(this.lblStructuurInput);
            this.Controls.Add(this.txtbxTabelProceduresInput);
            this.Controls.Add(this.txtbxStructuurInput);
            this.Name = "frmToolsTblProcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolsTblProcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxStructuurInput;
        private System.Windows.Forms.TextBox txtbxTabelProceduresInput;
        private System.Windows.Forms.Label lblStructuurInput;
        private System.Windows.Forms.Label lblTabelProceduresInput;
        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTabelProcedureOutput;
        private System.Windows.Forms.TextBox txtbxTabelProcedureOutput;
    }
}

