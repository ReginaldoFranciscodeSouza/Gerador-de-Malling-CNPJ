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
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void btn_consulta_simples_Click(object sender, EventArgs e)
        {
            Consulta_Simples simples = new Consulta_Simples();  
            simples.Show();
            
        }
    }
}
