namespace VAT_Validator
{
    partial class VAT_Validator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VAT_Validator));
            this.lst_ausgabe = new System.Windows.Forms.ListBox();
            this.txt_eingabe = new System.Windows.Forms.TextBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.txt_validate = new System.Windows.Forms.TextBox();
            this.btn_validate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_ausgabe
            // 
            this.lst_ausgabe.FormattingEnabled = true;
            this.lst_ausgabe.Location = new System.Drawing.Point(12, 76);
            this.lst_ausgabe.Name = "lst_ausgabe";
            this.lst_ausgabe.Size = new System.Drawing.Size(172, 290);
            this.lst_ausgabe.TabIndex = 0;
            this.lst_ausgabe.SelectedIndexChanged += new System.EventHandler(this.lst_ausgabe_SelectedIndexChanged);
            this.lst_ausgabe.MouseLeave += new System.EventHandler(this.lst_ausgabe_MouseDoubleClick);
            // 
            // txt_eingabe
            // 
            this.txt_eingabe.Location = new System.Drawing.Point(12, 20);
            this.txt_eingabe.Name = "txt_eingabe";
            this.txt_eingabe.Size = new System.Drawing.Size(172, 20);
            this.txt_eingabe.TabIndex = 1;
            // 
            // btn_import
            // 
            this.btn_import.AutoEllipsis = true;
            this.btn_import.Location = new System.Drawing.Point(109, 46);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 23);
            this.btn_import.TabIndex = 2;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(193, 20);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(443, 514);
            this.axAcroPDF1.TabIndex = 3;
            this.axAcroPDF1.Enter += new System.EventHandler(this.axAcroPDF1_Enter);
            // 
            // txt_validate
            // 
            this.txt_validate.Location = new System.Drawing.Point(12, 387);
            this.txt_validate.Multiline = true;
            this.txt_validate.Name = "txt_validate";
            this.txt_validate.Size = new System.Drawing.Size(172, 193);
            this.txt_validate.TabIndex = 4;
            // 
            // btn_validate
            // 
            this.btn_validate.Location = new System.Drawing.Point(190, 547);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(74, 33);
            this.btn_validate.TabIndex = 5;
            this.btn_validate.Text = "Validate VAT";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // VAT_Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 592);
            this.Controls.Add(this.btn_validate);
            this.Controls.Add(this.txt_validate);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.txt_eingabe);
            this.Controls.Add(this.lst_ausgabe);
            this.Name = "VAT_Validator";
            this.Text = "VAT Validator";
            this.Load += new System.EventHandler(this.VAT_Validator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_ausgabe;
        private System.Windows.Forms.TextBox txt_eingabe;
        private System.Windows.Forms.Button btn_import;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.TextBox txt_validate;
        private System.Windows.Forms.Button btn_validate;
    }
}

