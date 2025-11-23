using ColegioSISE.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColegioSISE
{
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void FormBienvenida_Load(object sender, EventArgs e)
        {
            Docente docente = SesionActual.DocenteLogueado;
            lblBienvenido.Text = "¡Bienvenido docente " + docente.Nombres + " al sistema SISE Notas!";
        }
    }
}
