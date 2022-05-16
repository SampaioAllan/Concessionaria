using Xunit;

namespace Concessionaria.TesteUnitario
{
    public class PessoaTest
    {
        [Fact]
        public void TestandoSePessoaSalvaNomeCorretamente()
        {
            //Arrange - Preparando
            var nomeEsperado = "Allan";
            var pessoaTest = new Pessoa(nomeEsperado, "12312312312", "11/07/1994");
            //Act - Agindo
            var nomeATestar = pessoaTest.GetNome();
            //Assert - 
            Assert.Equal(nomeEsperado, nomeATestar);
        }
        [Fact]
        public void TestandoSePessoaSalvaCPFCorretamente()
        {
            //Arrange - Preparando
            var cpfEsperado = "12312312312";
            var pessoaTest = new Pessoa("Allan", cpfEsperado, "11/07/1994");
            //Act - Agindo
            var cpfATestar = pessoaTest.GetCPF();
            //Assert - 
            Assert.Equal(cpfEsperado, cpfATestar);
        }
        [Fact]
        public void TestandoSePessoaSalvaDataNascimentoCorretamente()
        {
            //Arrange - Preparando
            var dataNascimentoEsperada = "11/11/1994 00:00:00";
            var pessoaTest = new Pessoa("Allan", "12312312312", dataNascimentoEsperada);
            //Act - Agindo
            var dataNascimentoATestar = pessoaTest.GetDataNasc().ToString();
            //Assert - 
            Assert.Equal(dataNascimentoEsperada, dataNascimentoATestar);
        }
        [Fact]
        public void TestandoSeClienteSalvaEmailCorretamente()
        {
            //Arrange - Preparando
            var emailEsperado = "email@email.com";
            var pessoaTest = new Cliente("Allan", "12312312312", "11/07/1994", emailEsperado, "999887766");
            //Act - Agindo
            var emailATestar = pessoaTest.GetEmail();
            //Assert - 
            Assert.Equal(emailEsperado, emailATestar);
        }
        [Fact]
        public void TestandoSeClienteSalvaTelefoneCorretamente()
        {
            //Arrange - Preparando
            var telefoneEsperado = "999887766";
            var pessoaTest = new Cliente("Allan", "12312312312", "11/07/1994", "email@email.com", telefoneEsperado);
            //Act - Agindo
            var telefoneATestar = pessoaTest.GetTelefone();
            //Assert - 
            Assert.Equal(telefoneEsperado, telefoneATestar);
        }
        [Fact]
        public void TestandoSeFuncionarioSalvaEmailCorretamente()
        {
            //Arrange - Preparando
            var cargoEsperado = "gerente";
            var pessoaTest = new Funcionario("Allan", "12312312312", "11/07/1994", cargoEsperado);
            //Act - Agindo
            var caroATestar = pessoaTest.GetCargo();
            //Assert - 
            Assert.Equal(cargoEsperado, caroATestar);

            //falta testando se salva cargo do vendedor
            
        }
    }
}