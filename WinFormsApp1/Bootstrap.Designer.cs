namespace WinFormsApp1
{
    partial class Bootstrap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.comboLocation = new System.Windows.Forms.ComboBox();
            this.chkListEnviroment = new System.Windows.Forms.CheckedListBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.butValidation = new System.Windows.Forms.Button();
            this.dateDia = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enviroment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(70, 91);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 10;
            // 
            // comboLocation
            // 
            this.comboLocation.FormattingEnabled = true;
            this.comboLocation.Items.AddRange(new object[] {
            "Europa",
            "America Nord",
            "America Sud",
            "Tu puta casa",
            "Asia",
            "Oceania",
            "Africa",
            "Dale a tu cuerpo",
            "Alegria Macarena"});
            this.comboLocation.Location = new System.Drawing.Point(368, 91);
            this.comboLocation.Name = "comboLocation";
            this.comboLocation.Size = new System.Drawing.Size(121, 21);
            this.comboLocation.TabIndex = 11;
            // 
            // chkListEnviroment
            // 
            this.chkListEnviroment.FormattingEnabled = true;
            this.chkListEnviroment.Items.AddRange(new object[] {
            "Python",
            "C#",
            "SQL",
            "R"});
            this.chkListEnviroment.Location = new System.Drawing.Point(519, 154);
            this.chkListEnviroment.Name = "chkListEnviroment";
            this.chkListEnviroment.Size = new System.Drawing.Size(120, 94);
            this.chkListEnviroment.TabIndex = 14;
            this.chkListEnviroment.SelectedIndexChanged += new System.EventHandler(this.chkListEnviroment_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(70, 170);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(338, 68);
            this.txtDescription.TabIndex = 15;
            // 
            // butValidation
            // 
            this.butValidation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butValidation.Location = new System.Drawing.Point(542, 292);
            this.butValidation.Name = "butValidation";
            this.butValidation.Size = new System.Drawing.Size(97, 46);
            this.butValidation.TabIndex = 16;
            this.butValidation.Text = "Validate";
            this.butValidation.UseVisualStyleBackColor = false;
            this.butValidation.Click += new System.EventHandler(this.butValidation_Click);
            // 
            // dateDia
            // 
            this.dateDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDia.Location = new System.Drawing.Point(70, 271);
            this.dateDia.Name = "dateDia";
            this.dateDia.ShowCheckBox = true;
            this.dateDia.Size = new System.Drawing.Size(200, 20);
            this.dateDia.TabIndex = 17;
            this.dateDia.ValueChanged += new System.EventHandler(this.dateDia_ValueChanged);
            // 
            // Bootstrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 383);
            this.Controls.Add(this.dateDia);
            this.Controls.Add(this.butValidation);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.chkListEnviroment);
            this.Controls.Add(this.comboLocation);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bootstrap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox comboLocation;
        private System.Windows.Forms.CheckedListBox chkListEnviroment;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button butValidation;
        private System.Windows.Forms.DateTimePicker dateDia;
    }
}