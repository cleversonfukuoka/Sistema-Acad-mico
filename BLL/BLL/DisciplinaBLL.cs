using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SistemaAcademico.Modelos;
using SistemaAcademico.DAL;

namespace SistemaAcademico.BLL
{
    public class DisciplinaBLL
    {
        public void Cadastrar(Disciplina disciplina)
        {
            if (disciplina.Nome_Disciplina.Trim().Length == 0)
            {
                throw new Exception("O nome da disciplina é obrigatório!");
            }

            disciplina.Nome_Disciplina.ToUpper();
            DisciplinaDAL obj = new DisciplinaDAL();            
            obj.Cadastrar(disciplina);
        }

        public void Alterar(Disciplina disciplina)
        {
            if (disciplina.Nome_Disciplina.Trim().Length == 0)
            {
                throw new Exception("O nome da disciplina é obrigatório!");
            }

            disciplina.Nome_Disciplina.ToUpper();
            DisciplinaDAL obj = new DisciplinaDAL();
            obj.Alterar(disciplina);
        }

        public void Excluir(Disciplina disciplina)
        {
            if (disciplina.ID_Disciplina < 1)
            {
                throw new Exception("Selecione uma disciplina antes de excluir!");
            }
            DisciplinaDAL obj = new DisciplinaDAL();
            obj.Excluir(disciplina);
        }

        public DataTable Listar()
        {
            DisciplinaDAL obj = new DisciplinaDAL();            
            return obj.Listar();
        }
    }
}
