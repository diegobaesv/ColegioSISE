using ColegioSISE.Data.Repositories;
using ColegioSISE.Entities;
using System;
using System.Collections.Generic;


namespace ColegioSISE.Business.Services
{
    public class CursoService
    {
        private readonly CursosDAO cursosDAO;

        public CursoService()
        {
            cursosDAO = new CursosDAO();
        }

        public List<Curso> ListarCursosPorDocente(int idDocente)
        {
            return cursosDAO.ListarCursosPorDocente(idDocente);
        }
    }
}
