namespace Calculator
{
    internal class Carro
    {
        public int Portas { get; set; }
        public int Rodas { get; set; }
        public int Volante { get; set; }
        public int Tapete { get; set; }
        public int Banco { get; set; }
        public int Janela { get; set; }
        public int Motor { get; set; }
        public int Vidro { get; set; }

        public int Acelerar(int velocidade)
        {
            velocidade++;
            return velocidade;
        }

        public int Freiar(int velocidade)
        {
            return --velocidade;
        }


        public Carro ConfigureAstra(Carro astra)
        {
            astra.Banco = 4;
            astra.Motor = 1;
            astra.Rodas = 4;

            return astra;
        }

        public Carro ConfigureAstra()
        {
            Carro vectra = new Carro();

            vectra.Banco = 12;
            vectra.Motor = 12;
            vectra.Rodas = 12;

            return vectra;
        }

        public Carro ConfigureAstra(int p)
        {
            Carro palho = new Carro();

            palho.Banco = 60;
            palho.Motor = 60;
            palho.Rodas = 60;

            return palho;

        }

        public Carro ConfigureVectra(Carro vectra)
        {
            vectra.Banco = 8;
            vectra.Motor = 2;
            vectra.Rodas = 8;

            return vectra;
        }
    }
}
