using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientaçãoObjeto
{
    class ClientePJ : Cliente
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public ClientePJ(string nome, string cnpj, string RazaoSocial) : base(nome)
        {
            Cnpj = Cnpj;
            RazaoSocial = RazaoSocial;
        }

        public virtual string GerarRelatorio()
        {
            return this.RazaoSocial + "-" + this.email;
        }
    }
}
