using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova_Individual
{
    public class Medico : Pessoa
    {
        string crm;

        public string Crm{
            get{ return crm; }
            set{ 
                if(value.IsNullOrEmpty){
                    throw new ArgumentException("Insira um crm correto ");
                } else{
                    crm = value;
                }
            }
        }
    }
}