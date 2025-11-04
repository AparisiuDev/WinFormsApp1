using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Connection : Form
    {
        SqlConnection connection = null;

        private string connectionString = "Data Source=46.183.118.102,54321;" +
            "Initial Catalog=BielEmployees;" + "User ID=sa;" + "Password=Sql#123456789";

        
        public Connection()
        {
            InitializeComponent();
        }

        private void Connection_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void butConnect_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                txtConnectionShow.Text = "Connection Successful";

                /***
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    txtConnectionShow.Text = "Connection Successful";
                }
                ***/
            }
            catch (Exception ex)
            {
                txtConnectionShow.Text = "Connection Failed: " + ex.Message;
            }
        }

        private void butCloseConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection == null)
                {
                    txtConnectionShow.Text = "No hay conexion de la que desconectarse";
                    return;
                }

                if (connection.State == ConnectionState.Closed)
                {
                    txtConnectionShow.Text = "Ya estas desconectado";
                    return;
                }

                connection.Close();
                txtConnectionShow.Text = "Connection Closed";
            }
            catch (Exception ex)
            {
                txtConnectionShow.Text = "Disconnect Failed: " + ex.Message;
            }
        }

        private void butAddJob_Click(object sender, EventArgs e)
        {
            if (txtJobTitle.Text == "")
            {
                MessageBox.Show("Loco que rellenes los campos");
                return;
            }

            // Nulleable
            decimal? minSalary = null;
            decimal? maxSalary = null;

            // Validar q no hay texto
            if (!string.IsNullOrWhiteSpace(txtMinSalary.Text))
            {
                if (!decimal.TryParse(txtMinSalary.Text, out decimal min))
                {
                    MessageBox.Show("El salario mínimo debe ser un número");
                    return;
                }
                minSalary = min;
            }

            // Lo mismo para max salary
            if (!string.IsNullOrWhiteSpace(txtMaxSalary.Text))
            {
                if (!decimal.TryParse(txtMaxSalary.Text, out decimal max))
                {
                    MessageBox.Show("El salario máximo debe ser un número");
                    return;
                }
                maxSalary = max;
            }

            Job newJob = new Job(txtJobTitle.Text, minSalary, maxSalary);

            string sql = "INSERT INTO jobs (job_title, min_salary, max_salary) " +
                         "VALUES (@titulo, @min, @max)";

            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = newJob.Job_title;
                cmd.Parameters.Add("@min", SqlDbType.Decimal).Value =
                    newJob.Min_salary.HasValue ? (object)newJob.Min_salary.Value : DBNull.Value;
                cmd.Parameters.Add("@max", SqlDbType.Decimal).Value =
                    newJob.Max_salary.HasValue ? (object)newJob.Max_salary.Value : DBNull.Value;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Trabajo añadido correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al añadir trabajo: " + ex.Message);
                }
            }
        }


        private void txtMinSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; 
            }

            TextBox textBox = sender as TextBox;
            if ((e.KeyChar == '.' || e.KeyChar == ',') && textBox.Text.Contains('.') || textBox.Text.Contains(','))
            {
                e.Handled = true;
            }
        }
        private void txtMaxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; 
            }

            TextBox textBox = sender as TextBox;
            if ((e.KeyChar == '.' || e.KeyChar == ',') && textBox.Text.Contains('.') || textBox.Text.Contains(','))
            {
                e.Handled = true;
            }
        }
    }
}
