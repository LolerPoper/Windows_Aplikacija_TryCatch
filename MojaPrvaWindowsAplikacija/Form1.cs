using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojaPrvaWindowsAplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzracun_Click(object sender, EventArgs e)
        {
            int brojA, brojB, zbroj;

            txtGreske.Text = "";

            try { 

            brojA = Convert.ToInt32(txtUnosBrojaA.Text);
            brojB = Convert.ToInt32(txtUnosBrojaB.Text);
            zbroj = brojA + brojB;
            txtRezultat.Text = Convert.ToString(zbroj);
            }
            catch (Exception greska)
            {
                string text = "Molim upisati broj.\n" + greska.Message;
                string naslov = "Pogrešan unos";
                MessageBoxButtons buttons= MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(text, naslov, buttons, icon);
            }
        }

        private void txtRezultat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
