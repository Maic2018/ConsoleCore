using GameTOP.Interface;

namespace GameTOP.lib
{
    public class JogadorDois : iJogador
    {
        public string Chuta()
        {
            return "Maradona estas pateando\n";
        }

        public string Corre()
        {
            return "Maradona estas corriendo\n";
        }

        public string Passe()
        {
            return "Maradon estas passando\n";
        }
    }
}