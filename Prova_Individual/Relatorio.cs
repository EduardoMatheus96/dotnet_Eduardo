using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova_Individual
{
    public class Relatorio
    {
        List<Paciente> pacientes;
        List<Medico> medicos;

        public Relatorio(List<Paciente> pacientes, List<Medico> medicos){
            this.pacientes= pacientes;
            this.medico= medicos;
        }
    }
}