using Microsoft.Data.SqlClient;
using senai_czbooks.Domains;
using senai_czbooks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_czbooks.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string stringConexao = "Data Source=LAB08DESK701\\SQLEXPRESS; Initial Catalog= senai_czbooks; user Id=sa; pwd=sa132";

        public Usuario BuscarPorUsuarioSenha(string Usuario, string Senha)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string querySelect = "SELECT idUsuario, Usuario, Senha FROM Usuario WHERE Usuario = @Usuario AND Senha = @Senha;";

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.Parameters.AddWithValue("@Senha", Senha);

                    con.Open();


                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        Usuario usuarioBuscado = new Usuario
                        {
                            IdUsuario = Convert.ToInt32(rdr["idUsuario"]),
                            Usuario1 = rdr["Usuario"].ToString(),
                            Senha = rdr["Senha"].ToString(),
                            // permissao = rdr["permissao"].ToString()
                        };

                        return usuarioBuscado;
                    }
                    return null;

                }
            }
        }
    }
}
