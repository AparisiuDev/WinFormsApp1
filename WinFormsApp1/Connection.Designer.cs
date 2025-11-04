namespace WinFormsApp1
{
    partial class Connection
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
            this.butConnect = new System.Windows.Forms.Button();
            this.butCloseConnect = new System.Windows.Forms.Button();
            this.txtConnectionShow = new System.Windows.Forms.TextBox();
            this.butAddJob = new System.Windows.Forms.Button();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinSalary = new System.Windows.Forms.TextBox();
            this.txtMaxSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butConnect
            // 
            this.butConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConnect.Location = new System.Drawing.Point(43, 124);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(121, 58);
            this.butConnect.TabIndex = 1;
            this.butConnect.Text = "CONNECT";
            this.butConnect.UseVisualStyleBackColor = true;
            this.butConnect.Click += new System.EventHandler(this.butConnect_Click);
            // 
            // butCloseConnect
            // 
            this.butCloseConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCloseConnect.Location = new System.Drawing.Point(246, 124);
            this.butCloseConnect.Name = "butCloseConnect";
            this.butCloseConnect.Size = new System.Drawing.Size(121, 58);
            this.butCloseConnect.TabIndex = 2;
            this.butCloseConnect.Text = "DISCONNECT";
            this.butCloseConnect.UseVisualStyleBackColor = true;
            this.butCloseConnect.Click += new System.EventHandler(this.butCloseConnect_Click);
            // 
            // txtConnectionShow
            // 
            this.txtConnectionShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnectionShow.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtConnectionShow.Enabled = false;
            this.txtConnectionShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnectionShow.Location = new System.Drawing.Point(107, 15);
            this.txtConnectionShow.Margin = new System.Windows.Forms.Padding(6);
            this.txtConnectionShow.Multiline = true;
            this.txtConnectionShow.Name = "txtConnectionShow";
            this.txtConnectionShow.ReadOnly = true;
            this.txtConnectionShow.Size = new System.Drawing.Size(205, 41);
            this.txtConnectionShow.TabIndex = 0;
            this.txtConnectionShow.Text = "Connection Closed";
            this.txtConnectionShow.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // butAddJob
            // 
            this.butAddJob.Location = new System.Drawing.Point(43, 491);
            this.butAddJob.Name = "butAddJob";
            this.butAddJob.Size = new System.Drawing.Size(75, 23);
            this.butAddJob.TabIndex = 3;
            this.butAddJob.Text = "Añadir Job";
            this.butAddJob.UseVisualStyleBackColor = true;
            this.butAddJob.Click += new System.EventHandler(this.butAddJob_Click);
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(60, 296);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(100, 20);
            this.txtJobTitle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Job Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "MinSalary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "MaxSalary";
            // 
            // txtMinSalary
            // 
            this.txtMinSalary.Location = new System.Drawing.Point(60, 368);
            this.txtMinSalary.Name = "txtMinSalary";
            this.txtMinSalary.Size = new System.Drawing.Size(100, 20);
            this.txtMinSalary.TabIndex = 10;
            this.txtMinSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinSalary_KeyPress);

            // 
            // txtMaxSalary
            // 
            this.txtMaxSalary.Location = new System.Drawing.Point(60, 421);
            this.txtMaxSalary.Name = "txtMaxSalary";
            this.txtMaxSalary.Size = new System.Drawing.Size(100, 20);
            this.txtMaxSalary.TabIndex = 11;
            this.txtMaxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxSalary_KeyPress);

            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.acd8ea1d3c51f7f30dd222d27e09ceb6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 540);
            this.Controls.Add(this.txtMaxSalary);
            this.Controls.Add(this.txtMinSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.butAddJob);
            this.Controls.Add(this.butCloseConnect);
            this.Controls.Add(this.butConnect);
            this.Controls.Add(this.txtConnectionShow);
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.Button butCloseConnect;
        private System.Windows.Forms.TextBox txtConnectionShow;
        private System.Windows.Forms.Button butAddJob;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinSalary;
        private System.Windows.Forms.TextBox txtMaxSalary;
    }
}