namespace Concessionaria
{
    public class Funcionario:Pessoa
    {
        private string Cargo { get; set; }
        public Funcionario(string nome, string cpf, string dataNasc, string cargo) : base(nome, cpf, dataNasc)
        {
            SetCargo(cargo);
        }
        public void SetCargo(string cargo)
        {
            Cargo=cargo;
        }
        public string GetCargo()
        {
            return Cargo;
        }
    }
}