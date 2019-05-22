using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winProyectoFe
{
    class clsQuiz
    {
        private int Vidas;
        public readonly string PalabrAux;
        private List<char> Palabra;
        private int Letras;

        public clsQuiz(string palabra)
        {
            PalabrAux = palabra;
            palabra = palabra.ToUpper();
            Palabra = palabra.ToList();
            Letras = palabra.Length;
            Vidas = 11;
        }
        ~clsQuiz()
        {
            GC.Collect();
        }
    }
}
