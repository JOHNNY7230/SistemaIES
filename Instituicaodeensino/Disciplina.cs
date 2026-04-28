using System;
using System.Collections.Generic;
using System.Text;

namespace Instituicaodeensino
{
    public class Disciplina
    {
        public long? DisciplinaId { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Disciplina d) return this.DisciplinaId.Equals(d.DisciplinaId);
            return false;
        }
        public override int GetHashCode()
        {
            return (11 + this.DisciplinaId == null ? 0 : this.DisciplinaId.GetHashCode());
        }
    }
}