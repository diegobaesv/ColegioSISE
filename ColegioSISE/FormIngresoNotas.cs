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
    public partial class FormIngresoNotas : Form
    {
        public FormIngresoNotas()
        {
            InitializeComponent();
        }

        private void FormIngresoNotas_Load(object sender, EventArgs e)
        {
            dgvNotas.ColumnCount = 4;
            dgvNotas.Columns[0].Name = "Codigo Alumno";
            dgvNotas.Columns[1].Name = "Nombre Completo";
            dgvNotas.Columns[2].Name = "Carrera";
            dgvNotas.Columns[3].Name = "Nota";

            string[] row1 = { "12345", "Verano Jesus", "CPEX Sistemas", "" };

            dgvNotas.Rows.Add(row1);

        }

    }
}
