using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class Cliente
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        
        public Cliente(string nome)
        {
            this.nome = nome;
        }
        
        public string GerarRelatorio()
        {
            return this.nome + "-" + this.email;
        }
    }
