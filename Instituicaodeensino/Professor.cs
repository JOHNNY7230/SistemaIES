using System;
using System.Collections.Generic;
using System.Text;

namespace Instituicaodeensino
{
    public class Professor
    {
        public string Nome { get; set; }
        public DateTime Contratacao { get; set; }
        public HashSet<Curso> Cursos { get; } = new HashSet<Curso>();
    }
}
