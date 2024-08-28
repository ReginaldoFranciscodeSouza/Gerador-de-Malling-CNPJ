using Gerador_de_Malling_CNPJ;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Malling_CNPJ
{
    public class atividade_principal
    {
        public string code { get; set; }
        public string text { get; set; }
    }
    public class atividade_secundaria
    {
        public string code { get; set; }
        public string text { get; set; }
    }


    public class Billing
    {
        public bool free { get; set; }
        public bool database { get; set; }
    }

    public class Qsa
    {
        public string nome { get; set; }
        public string qual { get; set; }
        public string pais_origem { get; set; }
        public string nome_rep_legal { get; set; }
        public string qual_rep_legal { get; set; }
    }
}
    internal class DadosCnpj
    {
        public string status { get; set; }
        public string ultima_atualizacao { get; set; }
        public string CNPJ { get; set; }
        public string tipo { get; set; }
        public string porte { get; set; }
        public string nome { get; set; }
        public string fantasia { get; set; }
        public string abertura { get; set; }
        public List <atividade_principal> atividade_principal { get; set; }
        public List<atividade_secundaria> atividade_secundaria {get; set; }
        public string natureza_juridica { get; set; }
        public string logradouro { get; set;}
        public string numero { get; set;}
        public string complemento { get; set;}
        public string cep { get; set;}
        public string bairro { get; set;}
        public string municipio { get; set;}
        public string uf { get; set;}
        public string email { get; set;}
        public string telefone { get; set;}
        public string efr { get; set; }
        public string situacao { get; set; }
        public string data_situacao { get; set; }
        public string situacao_especial { get; set; }
        public string data_situacao_especial { get; set; }
        public string capital_social { get; set; }
        public List<Qsa> qsa { get; set; }
        public Billing billing { get; set; }


    }

