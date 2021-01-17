using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnoBissexto
{
    public partial class AnoBissexto : Form
    {
        public AnoBissexto()
        {
            InitializeComponent();
        }

        private void txtDescobrir_Click(object sender, EventArgs e)
        {          
            try
            {
                int ano;
                ano = String.IsNullOrEmpty(txtAno.Text) ? 0 : Convert.ToInt32(txtAno.Text);
                if ((ano % 4 == 0) && (ano % 100 != 0) || (ano % 400 == 0))
                {
                    MessageBox.Show("É um ano Bissexto !!!!");
                }
                else
                {
                    MessageBox.Show("Não é um ano Bissexto !!");
                }
            }
            catch (Exception)
            {
               MessageBox.Show("Digite um valor valido!!");
                txtAno.Clear();
            }

        }


    }
}
