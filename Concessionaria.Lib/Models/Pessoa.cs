namespace Concessionaria.Lib.Models
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private string CPF { get; set; }
        private DateTime DataNasc { get; set; }
        public Pessoa (string nome, string cpf, string dataNasc)
        {
            SetNome(nome);
            SetCPF(cpf);
            SetDataNasc(dataNasc);
    
        }

        public void SetNome(string nome)
        {
            Nome=nome;
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetCPF(string cpf)
        {
            CPF=cpf;
        }
        public string GetCPF()
        {
            return CPF;
        }
        public void SetDataNasc(string dataNasc)
        {
            var dataNascDateTime=DateTime.Parse(dataNasc);
            DataNasc=dataNascDateTime;
        }
        public DateTime GetDataNasc()
        {
            return DataNasc;
        }
    }
}