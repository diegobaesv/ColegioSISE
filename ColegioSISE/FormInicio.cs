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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }


        private void FormInicio_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormBienvenida());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormEnPanel(Form formHijo)
        {
            if (pnlContenedor.Controls.Count > 0)
            {
                pnlContenedor.Controls.RemoveAt(0);
            }
            formHijo.TopLevel = false;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormCursos());
        }
    }
}
