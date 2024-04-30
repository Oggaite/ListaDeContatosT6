using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosMohhamedAbidbuhamed
{
    internal class Contato
    {
        private string nome;
        private string sobrenome;
        private string telefone;

        // propriedades. São os metodes "get' e "set".
        //get = leitura
        //set = definição
        // é possivel somente a leitura, ou somente definição

        public string Nome 
        { 
            get
            {
                return nome;
            }
            set 
            {
                nome = value;
            } 
        }
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if(value.Length == 11)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "(00) 00000-0000";
                }
            }
        }

        public Contato()
        {
            Nome = "Mohammed";
            Sobrenome = "Abiduhal";
            Telefone = "(11) 91324-9584";
        }


        public Contato(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;   
        }

        public override string ToString()
        {
            string saida = string.Empty;
            saida += String.Format("{0} {1} ", Nome, Sobrenome);
            saida += String.Format("({0}) {1}-{2}", Telefone.Substring(0,2), Telefone.Substring(2,5),Telefone.Substring(7,4));
            return saida;
        }
    }
}
