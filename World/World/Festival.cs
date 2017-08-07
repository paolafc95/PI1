using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace World
{
    public class Festival
    {

        //Atributos

        private string codigo;

        private string nombre;


        //Modalidades

        private Modalidad chirimia;

        private Modalidad marimba;

        private Modalidad violines;

        private Modalidad libre;


        //Constructor, inicializa las 4 modalidades por defecto

        public Festival(string code, string name)
        {
            string Codigo = code;
            string Nombre = name;
            inicializarModalidades();

        }

        //Inicializa las modalidades por defecto

        public void inicializarModalidades()
        {
            Modalidad Chirimia = new Modalidad(Modalidad.CHIRIMIA);
            Modalidad Marimba = new Modalidad(Modalidad.MARIMBA);
            Modalidad Violines = new Modalidad(Modalidad.VIOLINES);
            Modalidad Libre = new Modalidad(Modalidad.LIBRE);

        }

        // Verifica si el grupo a agregar en Chirimia se repite, true si se repite, false de lo contrario 

        public bool verificarGrupoChirimia(string name)
        {
            return chirimia.validarGrupo(name);
        }

        // Verifica si el grupo a agregar en Marimba se repite, true si se repite, false de lo contrario

        public bool verificarGrupoMarimba(String name)
        {
            return marimba.validarGrupo(name);
        }

        // Verifica si el grupo a agregar en Violines se repite, true si se repite, false de lo contrario

        public bool verificarGrupoViolines(String name)
        {
            return violines.validarGrupo(name);
        }

        // Verifica si el grupo a agregar en Libre se repite, true si se repite, false de lo contrario

        public bool verificarGrupoLibre(String name)
        {
            return libre.validarGrupo(name);
        }

        // Agrega el grupo a la modalidad chirimia

        public void agregarGrupoAChirimia(string name)
        {
            chirimia.agregarGrupo(name);
        }

        // Agrega el grupo a la modalidad Marimba

        public void agregarGrupoAMarimba(String name)
        {
            marimba.agregarGrupo(name);
        }

        // Agrega el grupo a la modalidad Violines

        public void agregarGrupoAViolines(String name)
        {
            violines.agregarGrupo(name);
        }

        // Agrega el grupo a la modalidad Libre

        public void agregarGrupoALibre(String name)
        {
            libre.agregarGrupo(name);
        }
        


        // Get y set

        public string Codigo { get { return codigo; } set { codigo = value; } }

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public Modalidad Chirimia { get { return chirimia; } set { chirimia = value; } }

        public Modalidad Marimba { get { return marimba; } set { marimba = value; } }

        public Modalidad Violines { get { return violines; } set { violines = value; } }

        public Modalidad Libre { get { return libre;} set { libre = value; } }
    }
}
