using Gerador_de_Malling_CNPJ.ConectaApi.ApiReceitaws;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Malling_CNPJ
{
    public partial class Consulta_Simples : Form
    {
        public Consulta_Simples()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cons = new Conectaws();
            string cnpj = textBox1.Text;
            cons.Intergracao(cnpj);
            MessageBox.Show(cons.ToString());    
         



        }
    }
}
