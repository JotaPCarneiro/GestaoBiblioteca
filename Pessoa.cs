using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoBiblioteca {
    internal class Pessoa {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public List<Livro> LivrosEmprestados { get; set; }

        public Pessoa()
        {
            LivrosEmprestados = new List<Livro>();
        }

        public Pessoa(int id, string nome, string cpf, string telefone, List<Livro> livrosEmprestados) {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            LivrosEmprestados = livrosEmprestados;
        }

        public void AdicionarLivroLista(Livro livro) {
            LivrosEmprestados.Add(livro);
        }

        public void RemoverLivroLista(Livro livro) {
            LivrosEmprestados.Remove(livro);
        }
    }
}
