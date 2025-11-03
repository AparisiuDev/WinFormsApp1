using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class PruebaWinforms : Form
    {
        public PruebaWinforms()
        {
            InitializeComponent();
        }

        private void PruebaWinforms_Load(object sender, EventArgs e)
        {

        }

        private void butPulsar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = listDiasSemana.SelectedItem.ToString();
        }

        private void butNextForm_Click(object sender, EventArgs e)
        {
            Bootstrap ch = new Bootstrap();
            ch.Show();
        }
    }
}
