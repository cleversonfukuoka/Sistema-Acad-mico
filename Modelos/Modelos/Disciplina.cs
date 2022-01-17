using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaAcademico.Modelos
{
    public class Disciplina
    {
        public int ID_Disciplina { get; set; }
        public string Nome_Disciplina { get; set; }
        public int ID_Aluno { get; set; }
    }
}
