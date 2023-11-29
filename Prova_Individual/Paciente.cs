using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova_Individual
{
    public class Paciente : Pessoa
    {
        string sexo;
        List<string> sintomas;

        public Paciente(string _nome, string _dataDeNascimento, string _cpf, string sexo, List<string> sintomas){
            this.nome = nome;
            this.dataDeNascimento = dataDeNascimento
        }

        public string sexo{
            get{ return sexo; }
            set{
                if(value.toLower != "MASCULINO" || value.toLower != "feminino"){
                    throw new ArgumentException("Insira um sexo valido !!!");
                } else {
                    sexo = value.toLower;
                }
            }
        }

        public List<string> Sintomas{
            get{ return sintomas; }
            set{ this.sintomas = value; }
        }
    }
}