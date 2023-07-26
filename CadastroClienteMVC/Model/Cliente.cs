using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClienteMVC.Model
{
    public class Cliente
    {
        public Cliente() { }
        public int Codigo { get; set; }
        public string NomeCliente { get; set; }
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Sexo { get; set; }
        public string RG { get; set; }
        public string Estado { get; set; }
        public string DataHora { get; set; }
        public string Status { get; set; }

    }
}
