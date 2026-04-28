using System;
using System.Collections.Generic;
using System.Text;

namespace Instituicaodeensino
{
    public abstract class Curso
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }

        public HashSet<Disciplina> Disciplinas { get; } = new HashSet<Disciplina>();
        public HashSet<Professor> Professores { get; } = new HashSet<Professor>();
        public HashSet<Turma> Turmas { get; } = new HashSet<Turma>();
        public HashSet<Aluno> Alunos { get; } = new HashSet<Aluno>();

        public virtual void RegistrarDisciplina(Disciplina d)
        {
            Disciplinas.Add(d);
        }

        public void RegistrarProfessor(Professor p)
        {
            Professores.Add(p);
            p.Cursos.Add(this);
        }

        public void RegistrarTurma(Turma t)
        {
            Turmas.Add(t);
            t.RegistrarCurso(this);
        }

        public void RegistrarAluno(Aluno a)
        {
            Alunos.Add(a);
            a.Cursos.Add(this);
        }
    }

    public class Graduacao : Curso
    {
        public int Semestres { get; set; }

        public override void RegistrarDisciplina(Disciplina d)
        {
            if (Disciplinas.Count < 24)
                Disciplinas.Add(d);
        }
    }

    public abstract class PosGraduacao : Curso
    {
        public int Creditos { get; set; }
    }

    public class LatoSensu : PosGraduacao
    {
        public string AreaDeGraduacao { get; set; }
    }

    public class StrictoSensu : PosGraduacao
    {
        public IList<string> LinhasDePesquisa { get; } = new List<string>();
    }
}
