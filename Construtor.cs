namespace Método_Construtor
{
    public class Construtor
    {
        public string Something { get; set; }
        public string Biuld {get; set;}

        public Construtor(){

        }
        public Construtor (string _something, string _biuld){

            this.Something = _something;
            this.Biuld = _biuld;

        }
    }
}