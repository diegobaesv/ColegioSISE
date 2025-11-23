using ColegioSISE.Data.Connection;
using ColegioSISE.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace ColegioSISE.Data.Repositories
{
    public class CursosDAO
    {
        // package dto en bussiness
        // class ListarCursosPorDocenteResponse
        public List<Curso> ListarCursosPorDocente(int idDocente)
        {
            List<Curso> cursos = new List<Curso>();
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = @"
                    select 
	                    cu.*,
	                    ( 
	                    select count(1) from matricula_clases m where m.id_clase = cl.id_clase
	                    ) as cantidad_matriculados
                    from cursos cu
                    inner join clases cl on cl.id_curso = cu.id_curso
                    where cl.id_docente = @idDocente ";

                /*
                if(filtro.NombreCurso)
                {
                    sql += "AND NombreCurso = @NombreCurso ";
                }

                if(filtro.IdCurso)
                {
                    sql += "AND IdCurso = @IdCurso";
                }*/

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@idDocente", idDocente);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Curso curso = new Curso
                    {
                        IdCurso = Convert.ToInt32(dr["id_curso"]),
                        Ciclo = Convert.ToInt32(dr["ciclo"]),
                        Nombre = dr["nombre"].ToString(),
                        CantidadMatriculados = Convert.ToInt32(dr["cantidad_matriculados"])
                    };
                    cursos.Add(curso);
                }

            }
            return cursos;
        }

    }
}
