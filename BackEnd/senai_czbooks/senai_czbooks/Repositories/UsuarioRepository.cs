using Microsoft.Data.SqlClient;
using senai_czbooks.Contexts;
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
        BlogContext ctx = new BlogContext();
        public void Atualizar(int id, Usuario usuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            throw new NotImplementedException();
        }

        public Usuario Login(string Usuario, string Senha)
        {
            return ctx.Usuarios.FirstOrDefault(login => login.)
        }
    }
}
