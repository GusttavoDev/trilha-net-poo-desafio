namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }
        public string IModelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }  

        public Smartphone(string Numero, string IModelo, string IMEI, int Memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            this.Numero = Numero;
            this.IModelo = IModelo;
            this.IMEI = IMEI;
            this.Memoria = Memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}