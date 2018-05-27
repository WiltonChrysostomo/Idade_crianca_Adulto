using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idade_Crianca_Adulto_Idoso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle(txtIdade.Text);


            if (controle.mensagem.Equals(""))
            {
                lblResposta.Text = controle.ToString();
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
