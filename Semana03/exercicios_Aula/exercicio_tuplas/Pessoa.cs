using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana03.exercicios_Aula.exercicio_tuplas
{
    public class Pessoa
    {
        public Pessoa(string name, int height){
            this.name = name;
            this.height = height;
        }
        public string name { get; private set; }
        public int height { get; private set;}

        // public void MediaHeight(List<Pessoa> people){
        //     var media = 0;
        //     media = people.Where(x => x.height == height).Sum();
        // }

    }
}