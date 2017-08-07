using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    public class Musico
    {
        // Constantes de tipo de instrumento

        public static string CUERDA = "Cuerda";

        public static string VIENTO = "Viento";

        public static string PERCUSION = "Percusion";

        //Constantes de genero 

        public static char GENERO_MASCULINO = 'm';

        public static char GENERO_FEMENINO = 'f';

        //Atributos

        private string nombre;

        private int edad;

        private char genero;

        private string tipoIntsrumento;

        //Constructor

        public Musico(string nom, int ed, char gen, string tipoInstru)
        {
            nombre = nom;
            edad = ed;
            genero = gen;
            tipoIntsrumento = tipoInstru;

        }


    }
}
