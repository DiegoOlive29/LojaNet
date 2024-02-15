using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.SqlTypes;

namespace LojaNet.DAL
{

        public static class DbHelper
        {
            private static string conexao
            {
                get
                {
                    return @"Data Source=\DESKTOP-DBMC6MI\USER;
                        Initial Catalog=LojaNetDb;
                        Integrated Security=true";


                }
            }
        public static IDataReader ExecuteReader(string storedProcedure, params object[] parametros) 
        {
            var cn = new SqlConnection(conexao);
            var cmd = new SqlCommand(storedProcedure, cn);

            cmd.CommandType = CommandType.StoredProcedure;
            PreencherParametros(parametros, cmd);


            cn.Open();
            var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
                
            
        }
            
            public static int ExecuteNonquery(string storedProcedure,
                params object[] paramentros)
            {
                int retorno = 0;

                using(var cn =new SqlConnection(conexao))
                {
                    using(var cmd = new SqlCommand(storedProcedure,
                                                   cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    PreencherParametros(paramentros, cmd);
                    cn.Open();
                    retorno = cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
                return retorno;
            }

        private static void PreencherParametros(object[] paramentros, SqlCommand cmd)
        {
            if (paramentros.Length > 0)
            {
                for (int i = 0; i < paramentros.Length; i += 2)
                {
                    cmd.Parameters.AddWithValue(paramentros[i].ToString(), paramentros[i + 1]);

                }
            }
        }
    }

    }
