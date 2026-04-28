using System;
using System.Collections.Generic;
using System.Text;

namespace Instituicaodeensino
{
    public class Aluno
    {
        public string RegistroAcademico { get; set; }
        public string Nome { get; set; }
        public HashSet<Curso> Cursos { get; } = new HashSet<Curso>();
    }
}
