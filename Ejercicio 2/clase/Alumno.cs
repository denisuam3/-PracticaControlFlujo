using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.clase
{
    internal class Alumno
    {
        public string Name { get; set; }
        public double Point { get; set; }
        public Alumno(string nombre , double nota)
        {
            Name = nombre;
            Point  = nota;
        }
    }
}

