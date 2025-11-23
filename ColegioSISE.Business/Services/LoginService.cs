using ColegioSISE.Data.Repositories;
using ColegioSISE.Entities;
using System;

namespace ColegioSISE.Business.Services
{
    public class LoginService
    {
        private readonly LoginDAO loginDAO;

        public LoginService()
        {
            loginDAO = new LoginDAO();
        }

        public Docente Login(string usuario, string clave) 
        {
            if (string.IsNullOrWhiteSpace(usuario))
            {
                throw new Exception("Debe ingresar al usuario");
            }

            if(string.IsNullOrWhiteSpace(clave))
            {
                throw new Exception("Debe ingresar la clave");
            }

            Docente docente = loginDAO.Login(usuario, clave);

            if (docente == null) {
                throw new Exception("Usuario o clave incorrectos");
            }

            return docente;
        }

    }
}
