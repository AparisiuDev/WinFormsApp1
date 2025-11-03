using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bootstrap : Form
    {
        public Bootstrap()
        {
            InitializeComponent();
        }

        private void butValidation_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtTitle.Text) 
                && !String.IsNullOrEmpty(txtDescription.Text)
                && chkListEnviroment.CheckedItems.Count > 0
                && comboLocation.SelectedIndex > 0
                )
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\fart.wav");
                simpleSound.Play();

                String msg = $@"Mensaje:
Titulo: {txtTitle.Text}
Descripcion: {txtDescription.Text}
Location: {comboLocation.Text}
Enviroment: ";
                //Add chklist to msg
                foreach (object item in chkListEnviroment.CheckedItems)
                    msg += $"\n    - {item}";

                msg += $"\nFecha: {(dateDia.Checked ? dateDia.Value.ToShortDateString() : "No especificada")}";
                MessageBox.Show(msg);
            }

            else
               MessageBox.Show("Faltan datos por completar");
        }

        private void chkListEnviroment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateDia_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
