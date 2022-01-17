using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SistemaAcademico.Modelos;
using SistemaAcademico.DAL;

namespace SistemaAcademico.BLL
{
    public class AlunosBLL
    {
        public void Cadastrar(Alunos aluno)
        {
            if (aluno.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do aluno é obrigatório!");
            }

            aluno.Nome.ToUpper();
            AlunosDAL obj = new AlunosDAL();
            obj.Cadastrar(aluno);
        }

        public void Alterar(Alunos aluno)
        {
            if (aluno.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do aluno é obrigatório!");
            }

            aluno.Nome.ToUpper();
            AlunosDAL obj = new AlunosDAL();
            obj.Alterar(aluno);
        }

        public void Excluir(Alunos aluno)
        {
            if (aluno.ID_Aluno < 1)
            {
                throw new Exception("Selecione um aluno antes de excluir!");
            }
            AlunosDAL obj = new AlunosDAL();
            obj.Excluir(aluno);
        }

        public DataTable Listar()
        {
            AlunosDAL obj = new AlunosDAL();
            return obj.Listar();
        }
    }
}
