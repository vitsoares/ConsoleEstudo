using System;
using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Maradona Chuta\n";
        }

        public string Corre()
        {
            return "Maradona Corre\n";
        }

        public string Passe()
        {
            return "Maradona passa\n";
        }
    }
}