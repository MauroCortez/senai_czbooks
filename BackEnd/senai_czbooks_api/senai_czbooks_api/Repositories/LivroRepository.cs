using senai_czbooks_api.Contexts;
using senai_czbooks_api.Domains;
using senai_czbooks_api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_czbooks_api.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        BlogContext ctx = new BlogContext();
        public void Atualizar(int id, Livro livroAtualizado)
        {
            throw new NotImplementedException();
        }

        public Livro BuscarPorId(int id)
        {
            return ctx.Livros.FirstOrDefault(i => i.IdLivro == id);
        }

        public void Cadastrar(Livro novoLivro)
        {
            ctx.Livros.Add(novoLivro);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Livros.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Livro> Listar()
        {
            return ctx.Livros.ToList();
        }
    }
}
