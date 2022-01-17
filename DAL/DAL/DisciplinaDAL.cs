using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SistemaAcademico.Modelos;

namespace SistemaAcademico.DAL
{
    public class DisciplinaDAL
    {
        #region CADASTRAR
        public void Cadastrar(Disciplina disciplina)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "";
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no banco de dados: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion

        #region ALTERAR
        public void Alterar(Disciplina disciplina)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "";
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no banco de dados: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion

        #region EXCLUIR
        public void Excluir(Disciplina disciplina)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "";
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir a disciplina " + disciplina.ID_Aluno);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no banco de dados: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion

        #region LISTAR
        public DataTable Listar()
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                da.SelectCommand = new SqlCommand("");
                da.SelectCommand.Connection = cn;
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no banco de dados: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion
    }
}
