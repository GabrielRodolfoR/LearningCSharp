namespace ExemploExecao.models
{
    public class Excecao
    {
        public void Metodo1()
        {
            Metodo2();
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma Exceção"); // Vai jogando para cima procurando um tratamento de exceção
        }
    }
}