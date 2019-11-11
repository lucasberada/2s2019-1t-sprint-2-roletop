using System;

namespace roletop.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Endereco {get;set;}
        public string Telefone {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        public DateTime DataNascimento {get;set;}
    
    

    public Cliente(string Nome,string Endereco,string telefone,string Senha,string Email,DateTime DataNascimento)
    {
        this.Nome=Nome;
        this.Endereco=Endereco;
        this.Telefone=telefone;
        this.Senha=Senha;
        this.Email=Email;
        this.DataNascimento=DataNascimento;

    }
}
}