using System;
using System.Collections.Generic;

#nullable disable

namespace senai_czbooks_api.Domains
{
    public partial class Livro
    {
        public int IdLivro { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdEmpresa { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public string Categoria { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Preco { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
