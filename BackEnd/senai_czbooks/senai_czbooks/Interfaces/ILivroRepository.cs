using senai_czbooks.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_czbooks.Interfaces
{
    interface ILivroRepository
    {
        List<Livro> Listar();

        Livro BuscarPorId(int id);

        void Cadastrar(Livro novoLivro);

        void Atualizar(int id, Livro livroAtualizado);

        void Deletar(int id);
    }
}
