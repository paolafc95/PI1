using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace World
{
    public class Grupo
    {
        // Constantes para indicar el genero al agregar un integrante al grupo

        public static char GENERO_MASCULINO = 'm';

        public static char GENERO_FEMENINO = 'f';

        //Atributos

        private int numeroIntegrantes;

        private string nombre;

        private List<Musico> musicos;


        // Variable reutilizable para agregar musicos

        private Musico nuevoMusico;


        //Constructor

        public Grupo(string name)
        {
            string Nombre = name;
            musicos = new List<Musico>(5);
        }


        //Inicializa y Agrega un musico al grupo

        public void agregarMusico(string nom, int edad, char genero, string tipoInstrumento)
        {
            Musico NuevoMusico = new Musico(nom, edad, genero, tipoInstrumento);
            musicos.Add(NuevoMusico);
        }

        //Calcula el numero de musicos en el grupo
        public int calcularNumeroMusicos()
        {
            return musicos.Count();
        }

        // Comprueba si se llego al limite del maximo de integrantes en el grupo
        public bool limiteIntegrantes()
        {
            return (calcularNumeroMusicos() == 5) ;
        }

        // Get y set

        public Musico NuevoMusico { get { return nuevoMusico; } set { nuevoMusico = value; } }

        public string Nombre { get { return nombre; } set { nombre = value; } }
    }
}
