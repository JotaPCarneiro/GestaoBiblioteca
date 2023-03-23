using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoBiblioteca {
    internal class Livro {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int QuantidadeExemplares { get; set; }
        public bool Disponivel { get; set; }

        public Livro() { }

        public Livro(int id, string titulo, string autor, string editora, int quantidadeExemplares)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            QuantidadeExemplares = quantidadeExemplares;
        }

        public void EmprestarLivro(int quantidadeEmprestada) {
            QuantidadeExemplares -= quantidadeEmprestada;
        }

        public void DevolverLivro(int quantidadeDevolvida) {
            QuantidadeExemplares += quantidadeDevolvida;
        }

        
    }
}
