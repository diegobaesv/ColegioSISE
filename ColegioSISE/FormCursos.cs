using ColegioSISE.Business.Services;
using ColegioSISE.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ColegioSISE
{
    public partial class FormCursos : Form
    {

        private readonly CursoService cursoService;
        public FormCursos()
        {
            InitializeComponent();
            cursoService = new CursoService();
        }

        private void FormCursos_Load(object sender, EventArgs e)
        {

            dgvCursos.AutoGenerateColumns = false;

            dgvCursos.Columns.Add("IdCurso", "Codigo");
            dgvCursos.Columns["IdCurso"].DataPropertyName = "IdCurso";

            dgvCursos.Columns.Add("Nombre", "Nombre Curso");
            dgvCursos.Columns["Nombre"].DataPropertyName = "Nombre";

            dgvCursos.Columns.Add("Ciclo", "Ciclo");
            dgvCursos.Columns["Ciclo"].DataPropertyName = "Ciclo";

            dgvCursos.Columns.Add("CantidadMatriculados", "Alumnos Matriculados");
            dgvCursos.Columns["CantidadMatriculados"].DataPropertyName = "CantidadMatriculados";

            Docente docente = SesionActual.DocenteLogueado;

            List<Curso> cursos = cursoService.ListarCursosPorDocente(docente.IdDocente);

            dgvCursos.DataSource = cursos;
        }
    }
}
