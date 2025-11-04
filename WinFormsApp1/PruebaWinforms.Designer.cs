namespace WinFormsApp1
{
    partial class PruebaWinforms
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.butPulsar = new System.Windows.Forms.Button();
            this.listDiasSemana = new System.Windows.Forms.ListBox();
            this.butNextForm = new System.Windows.Forms.Button();
            this.butSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // butPulsar
            // 
            this.butPulsar.Location = new System.Drawing.Point(252, 58);
            this.butPulsar.Name = "butPulsar";
            this.butPulsar.Size = new System.Drawing.Size(116, 23);
            this.butPulsar.TabIndex = 2;
            this.butPulsar.Text = "Pulsa para copiar";
            this.butPulsar.UseVisualStyleBackColor = true;
            this.butPulsar.Click += new System.EventHandler(this.butPulsar_Click);
            // 
            // listDiasSemana
            // 
            this.listDiasSemana.FormattingEnabled = true;
            this.listDiasSemana.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.listDiasSemana.Location = new System.Drawing.Point(151, 136);
            this.listDiasSemana.Name = "listDiasSemana";
            this.listDiasSemana.Size = new System.Drawing.Size(69, 95);
            this.listDiasSemana.TabIndex = 3;
            // 
            // butNextForm
            // 
            this.butNextForm.Location = new System.Drawing.Point(151, 246);
            this.butNextForm.Name = "butNextForm";
            this.butNextForm.Size = new System.Drawing.Size(75, 23);
            this.butNextForm.TabIndex = 4;
            this.butNextForm.Text = "Next Form";
            this.butNextForm.UseVisualStyleBackColor = true;
            this.butNextForm.Click += new System.EventHandler(this.butNextForm_Click);
            // 
            // butSQL
            // 
            this.butSQL.Location = new System.Drawing.Point(151, 275);
            this.butSQL.Name = "butSQL";
            this.butSQL.Size = new System.Drawing.Size(75, 23);
            this.butSQL.TabIndex = 5;
            this.butSQL.Text = "Connection";
            this.butSQL.UseVisualStyleBackColor = true;
            this.butSQL.Click += new System.EventHandler(this.butSQL_Click);
            // 
            // PruebaWinforms
            // 
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.d14498b1d3b1274c429e6b3b7d49a1b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 317);
            this.Controls.Add(this.butSQL);
            this.Controls.Add(this.butNextForm);
            this.Controls.Add(this.listDiasSemana);
            this.Controls.Add(this.butPulsar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name = "PruebaWinforms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi primera aplicacion ";
            this.Load += new System.EventHandler(this.PruebaWinforms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button butPulsar;
        private System.Windows.Forms.ListBox listDiasSemana;
        private System.Windows.Forms.Button butNextForm;
        private System.Windows.Forms.Button butSQL;
    }
}

