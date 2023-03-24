namespace GestaoBiblioteca {
    public class Menu {
        static void Main(string[] args) {

            List<Pessoa> pessoasCadastradas = new List<Pessoa>();
            List<Livro> livrosCadastrados = new List<Livro>();
            
             Biblioteca biblioteca = new Biblioteca(pessoasCadastradas, livrosCadastrados);

            int op = 0;
            bool auxOp = true;

            while (auxOp == true) {

                Console.WriteLine(" --- MENU --- ");
                Console.WriteLine(" O que deseja fazer? Digite o número de acordo com a opção desejada:\r\n" +
                    " 1 - Cadastrar Pessoa\r\n 2 - Cadastrar Livro\r\n 3 - Emprestar Livro\r\n 4 - Devolver Livro\r\n " +
                    "5 - Listar todos os livros\r\n 6 - Listar todas as pessoas cadastradas\r\n" + " 7 - Listar todos os livros cadastrados\r\n" + " 8 - Sair");
                op = Int32.Parse(Console.ReadLine());

                switch (op) {

                    case 1: // Cadastrar Pessoa

                        Pessoa pessoa = new Pessoa();

                        Console.WriteLine(" --- CADASTRO DE USUÁRIO --- ");
                        
                        Console.WriteLine("Informe o ID: ");
                        pessoa.Id = Int32.Parse(Console.ReadLine());

                        //Verifica se o ID digitado já existe na lista de pessoas cadastradas
                        foreach (Pessoa p in pessoasCadastradas) {

                            if (p.Id == pessoa.Id) {

                                Console.WriteLine("Já existe um usuário cadastrado com o ID informado.");

                            } else {

                                Console.WriteLine("Informe o nome: ");
                                pessoa.Nome = Console.ReadLine();

                                Console.WriteLine("Informe o CPF: ");
                                pessoa.Cpf = Console.ReadLine();

                                Console.WriteLine("Informe o Telefone: ");
                                pessoa.Telefone = Console.ReadLine();

                                pessoasCadastradas.Add(pessoa);

                            }

                        }

                        break;

                    case 2: // Cadastrar Livro

                        Livro livro = new Livro();

                        Console.WriteLine(" --- CADASTRO DE LIVRO --- ");

                        Console.WriteLine("Informe o ID: ");
                        livro.Id = Int32.Parse(Console.ReadLine());

                        //Verifica se o ID digitado já existe na lista de pessoas cadastradas
                        foreach (Livro l in livrosCadastrados) {

                            if (l.Id == livro.Id) {

                                Console.WriteLine("Já existe um livro cadastrado com o ID informado.");

                            }else {

                                Console.WriteLine("Informe o Título: ");
                                livro.Titulo = Console.ReadLine();

                                Console.WriteLine("Informe o Autor: ");
                                livro.Autor = Console.ReadLine();

                                Console.WriteLine("Informe a Editora: ");
                                livro.Editora = Console.ReadLine();

                                livrosCadastrados.Add(livro);

                            }

                        }

                        break;

                    case 3: // Emprestar Livro

                        break;

                    case 4: // Devolver Livro

                        break;

                    case 5: // Listar Todos os Livros
                        
                        Console.WriteLine(" --- LISTA DE LIVROS CADASTRADOS --- ");

                        foreach(Livro l in livrosCadastrados) {
                            Console.WriteLine(l.Titulo);
                        }

                        break;

                    case 6: // Listar Todas as Pessoas Cadastradas

                        Console.WriteLine(" --- LISTA DE PESSOAS CADASTRADOS --- ");

                        foreach (Pessoa p in pessoasCadastradas) {
                            Console.WriteLine(p.Nome);
                        }

                        break;

                    case 7: // Listar Todos os Livros Emprestados

                        break;

                    case 8: // Sair

                        Console.WriteLine(" --- PROGRAMA ENCERRADO --- ");
                        auxOp = false;

                        break;

                    default:

                        Console.WriteLine("Valor invállido. Digite um novo número no menu.\r\n");
                        
                        break;
                }
            
            }

        }

    }

}
