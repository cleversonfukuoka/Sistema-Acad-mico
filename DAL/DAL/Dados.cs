using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaAcademico.DAL
{
    class Dados
    {
        public static string StringDeConexao
        {
            get
            {
                //local
                return "server=CLEVERSON-PC\\SQLEXPRESS --- WINDOWS AUTENTICATION --- DATABASE:ESCOLA";
                //Employer
                //return "DATA SOURCE=.\SQLEXPRESS;AttachDbFileName=|DataDirectory|\BancoDeDados.mdf;Integrated Security=TRUE;User";
            }
        }
    }
}
