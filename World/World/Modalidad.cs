using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    public class Modalidad
    {
        // Constantes del tipo de modalidad

        public static string CHIRIMIA = "Chirimia";

        public static string MARIMBA = "Marimba";

        public static string VIOLINES = "violines";

        public static string LIBRE = "Libre";


        // Lista que contiene los grupos de la modalidad

        private List<Grupo> grupos;


        //Tipo de modalidad

        private string tipo;


        //Variable reutilizable para agregar grupos

        private Grupo nuevoGrupo;

        //Constructor
        public Modalidad(string tip)
        {
            string Tipo = tip;
            grupos = new List<Grupo>(100);

        }

        // Calcula el numero de grupos inscritos en esta modalidad
        public int numeroGrupos()
        {
            return grupos.Count();
        }


        //Verifica que el grupo a agregar no se repita, true si se repite, false de lo contrario
        public bool validarGrupo(string nombre)
        {
            int size = numeroGrupos();
            string temporalName = "";
            for(int i = 0; i < size; i++)
            {
                if (grupos[i] != null)
                {
                    temporalName = grupos[i].Nombre;
                    if (temporalName.Equals(nombre))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        //Agrega un grupo a la modalidad
        public void agregarGrupo(string nombre)
        {
            nuevoGrupo = new Grupo(nombre);
            grupos.Add(nuevoGrupo);
            
        }


        //Get y set

        public string Tipo { get { return tipo; } set { tipo = value; } }       

    }
}
