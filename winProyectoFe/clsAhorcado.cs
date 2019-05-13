using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winProyectoFe
{
    class clsAhorcado
    {
        private int Vidas;
        public readonly string PalabrAux;
        private List<char> Palabra;
        private int Letras;
        

        public clsAhorcado(string palabra)
        {
            PalabrAux = palabra;
            palabra = palabra.ToUpper();
            Palabra = palabra.ToList();
            Letras = palabra.Length;
            Vidas = 11;
        }

        ~clsAhorcado()
        {
            GC.Collect();
        }

        public int getVidas()
        {
            return Vidas;
        }

        public int getLetras()
        {
            return Letras;
        }

        public int probarLetra(char letra)
        {
            if (Palabra.Contains(letra))
            {
                while (Palabra.Contains(letra))
                {
                    Palabra[Palabra.IndexOf(letra)] = ' ';
                    Letras--;
                }
            }
            else
            {
                Vidas--;
                if (Vidas == 0)
                {
                    return -2; // fin del jeugo
                }
                else
                {
                    return -1;
                }
            }

            return Letras; //regresa las letras restantes
        }

    }
}
