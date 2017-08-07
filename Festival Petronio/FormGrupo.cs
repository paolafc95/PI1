using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Festival_Petronio
{
    public partial class FormGrupo : Form
    {
        public FormGrupo()
        {
            InitializeComponent();
            
        }

        private void nombreGtextB_TextChanged(object sender, EventArgs e)
        {
            string line;
            //leer de un archivo txt
            System.IO.StreamReader file = new System.IO.StreamReader(@"C: \Users\Lilian Paola\Documents\UIcesi\Proyecto integrador1\Festival Petronio\Grupos.txt");
            while ((line = file.ReadLine())!= null)
            {
                nombreGlabel.ResetText();
                //nombreGlabel.(line);
                System.Console.WriteLine(line);
                

            }
        }

        private void ingresarbtn_Click(object sender, EventArgs e)
        {   
            //abre el form para ingresar los musicos         
            FormMusicos frmmusico = new FormMusicos();
            frmmusico.Show();
            //ocultar form actual
           /* FormGrupo frmgrupo = new FormGrupo();
            this.Hide();*/
        }
    }
}
