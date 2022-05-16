using Concessionaria.MinhasExceptions;
namespace Concessionaria
{
    public class Cliente : Pessoa
    {
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Cliente()
        {
            
        }
        public Cliente(string nome, string cpf, string dataNasc, string email, string telefone) : base(nome, cpf, dataNasc)
        {
            SetEmail(email);
            SetTelefone(telefone);
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetTelefone(string telefone)
        {
            Telefone = telefone;
        }
        public string GetTelefone()
        {
            return Telefone;
        }

        public bool ValidarTelefone(string telefone)
        {
            if (telefone.Length > 8 && telefone.Length < 15)
            {
                return true;
            }
            throw new ValidacaoDeDados("Telefone inválido");
        }
        public bool ValidarEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            throw new ValidacaoDeDados("email inválido!");
        }

    }
}