using System;
using System.Collections.Generic;
using System.Text;

namespace Instituicaodeensino
{
    public class Departamento
    {
        public string Nome { get; set; }
        public IList<Curso> Cursos { get; } = new List<Curso>();

        public void RegistrarCurso(Curso c)
        {
            Cursos.Add(c);
        }
    }
}
