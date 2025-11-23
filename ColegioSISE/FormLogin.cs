using System;
using System.Windows.Forms;
using ColegioSISE.Business.Services;
using ColegioSISE.Entities;

namespace ColegioSISE
{
    public partial class FormLogin : Form
    {
        private readonly LoginService loginService;

        public FormLogin()
        {
            InitializeComponent();
            loginService = new LoginService();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            try
            {
                Docente docente = loginService.Login(txtNombreUsuario.Text, txtClave.Text);

                MessageBox.Show(
                    "!Bienvenido "+ docente.Nombres+" al sistema de Notas!",
                    "Acceso Ok",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                FormInicio formInicio = new FormInicio();
                formInicio.Show();
                this.Hide();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
