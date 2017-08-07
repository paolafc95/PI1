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
    public partial class FormIdentificacion : Form
    {
        public FormIdentificacion()
        {
            InitializeComponent();
        }

        private void FormIdentificacion_Load(object sender, EventArgs e)
        {

        }

        private void ingresarbtn_Click(object sender, EventArgs e)
        {
            //abrir siguiente ventana, form de los grupos
            FormGrupo frmgrupo = new FormGrupo();
            frmgrupo.Show();            
            //esconder el form al abrir el siguiente
            FormIdentificacion frmident = new FormIdentificacion();
            this.Hide();
          
        }
    }
}
