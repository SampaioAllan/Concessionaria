namespace Concessionaria
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }
        public Pessoa()
        {
            
        }
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