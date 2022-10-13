
namespace Brincando.Models
{
    public class Layout : Pessoa
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();
        public static void TelaPrincipal()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.Clear();

            Console.WriteLine("          1 - Login                     ");
            Console.WriteLine("          ____________________          ");
            Console.WriteLine("          2 - Se cadastrar              ");
            Console.WriteLine("          ____________________          ");
          
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    telaDeLogin();
                    break;
                case 2:
                    telaDeCadastro();
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }

        public static void telaDeLogin()
        {
            Console.Clear();
            Console.WriteLine("          Digite o seu CPF:             ");
            Console.WriteLine("          ____________________          ");
            string cpf = Console.ReadLine();
            Console.WriteLine("          Digite a sua senha:           ");
            Console.WriteLine("          ____________________          ");
            string senha = Console.ReadLine();

            Pessoa pessoa = pessoas.FirstOrDefault(x => x.CPF == cpf && x.Senha == senha);

            if (pessoa != null)
            {
                telaDeBoasVindas(pessoa);

                telaContaLogada(pessoa);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("          Pessoa não cadastrada!!      ");
                Console.WriteLine("          ______________________     ");
                Console.WriteLine();
            }

            Thread.Sleep(1000);
            TelaPrincipal();
        }

        public static void telaDeCadastro()
        {
            Console.Clear();

            Console.WriteLine("          Digite o seu nome:            ");
            Console.WriteLine("          ____________________          ");
            string nome = Console.ReadLine();
            Console.WriteLine("          Digite o seu CPF:             ");
            Console.WriteLine("          ____________________          ");
            string cpf = Console.ReadLine();
            Console.WriteLine("          Digite a sua senha:           ");
            Console.WriteLine("          ____________________          ");
            string senha = Console.ReadLine();

            Pessoa pessoa = new Pessoa();

            pessoa.SetNome(nome);
            pessoa.SetCPF(cpf);
            pessoa.SetSenha(senha);

            pessoas.Add(pessoa);

            Console.Clear();

            Console.WriteLine("          Conta cadastrada com sucesso.   ");
            Console.WriteLine("          ________________________________");

            // Esse código espera 1 segundo para ir a TelaDeLogada
            Thread.Sleep(1000);

            telaContaLogada(pessoa);
        }

        public static void telaContaLogada(Pessoa pessoa)
        {
            Console.Clear();

            telaDeBoasVindas(pessoa);

            Console.WriteLine("          1 - Pensando ainda            ");
            Console.WriteLine("          ____________________          ");
            Console.WriteLine("          2 - Pensando ainda            ");
            Console.WriteLine("          ____________________          ");
            Console.WriteLine("          3 - Sair                      ");
            Console.WriteLine("          ____________________          ");


            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Pensando ainda");
                    break;
                case 2:
                    Console.WriteLine("Pensando ainda");
                    break;
                case 3:
                    TelaPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }

        public static void telaDeBoasVindas(Pessoa pessoa)
        {
            Console.Clear();
            string msgTelaDeBemVindo
                = $"Seja bem vindo(a), {pessoa.Nome}";

            Console.WriteLine();
            Console.WriteLine($"          {msgTelaDeBemVindo}       ");
            Console.WriteLine();
        }
    }
}
