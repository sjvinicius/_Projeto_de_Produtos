using System;
namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Usuario
    {
        public int Codigo { get; set; }
        
        public string Nome { get; set; }
        
        public string Email { get; set; }
        
        public string Senha { get; set; }
        
        public DateTime DataCadastro { get; set; }

        public Usuario(){
            Cadastrar();
        }

        public Usuario(int _codigo, string _nome, string _email, string _senha){
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.Today;
        }
        
        public void Cadastrar(){
            Nome = "Vinicius";
            Email = "vinicius123@gmail.com";
            Senha = "123345";

            DataCadastro = DateTime.Today;
        }

        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";

            DataCadastro = DateTime.Parse("");
        }
    }
}