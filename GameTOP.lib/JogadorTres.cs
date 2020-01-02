using GameTOP.Interface;

namespace GameTOP.lib
{
    public class JogadorTres : iJogador
    {
        public string Chuta()
        {
            return "Teste Chuta\n";
        }

        public string Corre()
        {
            return "Teste Corre\n";
        }

        public string Passe()
        {
            return "Teste Passe\n";
        }
    }
}