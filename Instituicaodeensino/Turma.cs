using System;
using System.Collections.Generic;
using System.Text;
using static Instituicaodeensino.Enums;

namespace Instituicaodeensino
{
    public class Turma
    {
        private Curso _curso;
        public string CodigoTurma { get; set; }
        public PeriodoCursoEnum PeriodoCurso { get; set; }
        public TurnoTurmaEnum TurnoTurma { get; set; }
        public Curso Curso { get { return _curso; } }
        public HashSet<Matricula> Matriculas { get; } = new HashSet<Matricula>();

        public void RegistrarCurso(Curso curso)
        {
            this._curso = curso;
        }

        public void RegistrarMatricula(Matricula m)
        {
            if (this.Matriculas.Count > 2)
                throw new Exception("Turma já não dispõe de vagas");

            this.Matriculas.Add(m);
            m.Turma = this;
        }
    }
}
