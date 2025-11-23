using ColegioSISE.Data.Connection;
using ColegioSISE.Entities;
using System;
using System.Data.SqlClient;

namespace ColegioSISE.Data.Repositories

{
    public class LoginDAO
    {
        public Docente Login(string usuario, string clave)
        {
            Docente docente = null;
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = @"
                    SELECT *
                    FROM docentes
                    WHERE usuario = @usuario
                    AND clave = @clave";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
                {
                    docente = new Docente
                    {
                        IdDocente = Convert.ToInt32(dr["id_docente"]),
                        Nombres = dr["nombres"].ToString(),
                        ApellidoPaterno = dr["apellido_paterno"].ToString(),
                        ApellidoMaterno = dr["apellido_materno"].ToString(),
                    };
                }

            }
            return docente;
        }
    }
}
