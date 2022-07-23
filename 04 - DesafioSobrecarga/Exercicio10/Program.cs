/*1) Defina sobrecarga de métodos e em seguida implemente uma classe onde é expresso um exemplo.
  R: Consiste em criar variações de um mesmo método, essas variações devem conter parametros diferentes.
    
  EXEMPLO:

    public class Lampada
    {
        public string Cor { get; set; }

        public bool Ligada { get; set; }

        public Lampada()
        {

        }

        public Lampada(string cor, bool ligada)
        {
            Cor = Cor; Ligada = ligada;
        }

        public Lampada(string cor)
        {
            Cor = Cor;
            Ligada = true;
        }
    }
}

  2) O que é um construtor?
  R: São tipos de métodos, usados para instanciar as classes e criar e inicializar atributos. Usando ou não parametros.
  

  3) O que é um construtor padrão? Quais as suas características?
  R: Quando não espicificamos nenhum construtor, o construtor padrão é definido automaticamente e sem parametros.
*/

