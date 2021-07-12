using senai_czbooks.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_czbooks.Interfaces
{
    interface IEmpresaRepository
    {
        List<Empresa> Listar();

        Empresa BuscarPorId(int id);

        void Cadastrar(Empresa novaEmpresa);

        void Atualizar(int id, Empresa empresaAtualizada);

        void Deletar(int id);
    }
}
