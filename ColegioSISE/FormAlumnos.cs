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
    public partial class FormAlumnos : Form
    {
        public FormAlumnos()
        {
            InitializeComponent();
        }

        private void FormAlumnos_Load(object sender, EventArgs e)
        {
            dgvAlumnos.ColumnCount = 7;
            dgvAlumnos.Columns[0].Name = "Código";
            dgvAlumnos.Columns[1].Name = "Nombre Completo";
            dgvAlumnos.Columns[2].Name = "Carrera";
            dgvAlumnos.Columns[3].Name = "EA1";
            dgvAlumnos.Columns[4].Name = "EP";
            dgvAlumnos.Columns[5].Name = "EA2";
            dgvAlumnos.Columns[6].Name = "EF";

            string[] row1 = { "12345", "Verano Jesus", "CPEX Sistemas", "10", "13", "15", "10" };

            dgvAlumnos.Rows.Add(row1);
        }
    }
}
