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
            Livro livroEmprestado = Livros.FirstOrDefault(livro => livro.Id == idLivro && livro.Disponivel);
            if (livroEmprestado == null) {
                Console.WriteLine("Livro não disponível para empréstimo");
                return;
            }

            Pessoa pessoa = Pessoas.FirstOrDefault(p => p.Id == idPessoa);
            if (pessoa == null) {
                Console.WriteLine("Pessoa não encontrada");
                return;
            }

            livroEmprestado.EmprestarLivro();
            pessoa.AdicionarLivroLista(livroEmprestado);
        }

        public void DevolverLivroBiblioteca(int idLivro, int idPessoa) {
            Livro livroDevolvido = Livros.FirstOrDefault(livro => livro.Id == idLivro && !livro.Disponivel);
            if (livroDevolvido == null) {
                Console.WriteLine("Livro não encontrado ou já devolvido");
                return;
            }

            Pessoa pessoa = Pessoas.FirstOrDefault(p => p.Id == idPessoa);
            if (pessoa == null) {
                Console.WriteLine("Pessoa não encontrada");
                return;
            }

            livroDevolvido.DevolverLivro();
            pessoa.RemoverLivroLista(livroDevolvido);
        }

    }
}


