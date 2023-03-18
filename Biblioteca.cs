using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoBiblioteca {
    internal class Biblioteca {

        public List<Pessoa> Pessoas { get; set; }
        public List<Livro> Livros { get; set; }

        public Biblioteca(List<Pessoa> pessoas, List<Livro> livros)
        {
            Pessoas = pessoas;
            Livros = livros;
        }

        public void CadastrarPessoa(Pessoa pessoa) {
            Pessoas.Add(pessoa);
        }

        public void CadastrarLivro(Livro livro) {
            Livros.Add(livro);
        }

        public void EmprestarLivroBiblioteca(int idLivro, int idPessoa) {
            
        }

        public void DevolverLivroBiblioteca(int idLivro, int idPessoa) {

        }

    }
}
