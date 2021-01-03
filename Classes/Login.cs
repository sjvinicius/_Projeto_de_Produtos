using System;
namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login(){
            Logar();
            if(Logado == true){
                GerarMenu();
            }
        }

        public void GerarMenu(){

            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao = "n";

            do
            {
                Console.WriteLine($"-----    Escolha uma opçâo abaixo :");
                Console.WriteLine($"-----    1 - Cadastrar Marca");
                Console.WriteLine($"-----    2 - Listar Marca:");
                Console.WriteLine($"-----    3 - Excluir Marca:");
                Console.WriteLine($"-----    4 - Cadastrar Produto");
                Console.WriteLine($"-----    5 - Listar Produto:");
                Console.WriteLine($"-----    6 - Excluir Produto:");
                Console.WriteLine($"-----    0 - Sair da aplicação:");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        marca.Cadastrar();
                        break;
                    case "2":
                        marca.Listar();
                        break;
                    case "3":
                        Console.WriteLine($"-----    Digite um código para excluir a marca: ");
                        int codigo = int.Parse(Console.ReadLine());
                        marca.Deletar(codigo);
                    
                        break;
                    case "4":
                        produto.Cadastrar();
                        break;
                    case "5":
                        produto.Listar();
                        break;
                    case "6":
                        Console.WriteLine($"-----    Digite um código para excluir um produto: ");
                        int codigoProduto = int.Parse(Console.ReadLine());
                        produto.Deletar(codigoProduto);
                        break;
                    default:
                        break;
                }
                
                

                
            } while (opcao != "0");
        }
        
        public void Logar(){
            Usuario user = new Usuario();
            do
            {
                
            Console.WriteLine("-----    Digite seu e-mail: ");
            string emailLogin = Console.ReadLine();

            Console.WriteLine($"-----    Digite sua senha: ");
            string senhaLogin = Console.ReadLine();
            
            if(emailLogin == user.Email && senhaLogin == user.Senha){
                Logado = true;
                Console.WriteLine($"-----    Login feito com sucesso!");
                
            }else{
                Console.WriteLine($"-----    Falha ao realizar o login, tente novamente !!");
                
            }           
            } while (Logado == false);
        }
    }
}