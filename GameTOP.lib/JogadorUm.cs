
using GameTOP.Interface;

namespace GameTOP.lib
{
 public class JogadorUm : iJogador
    {
        public readonly string Nome;

        public JogadorUm(string nameJogador)
        {
            this.Nome = nameJogador;
        }


        public string Chuta()
        {
            return $"{Nome} está Chutando\n";
        }

        public string Corre()
        {
            return $"{Nome} está Correndo\n";
        }

        public string Passe()
        {
            return $"{Nome} está Passando\n\n";
        }

    }
}