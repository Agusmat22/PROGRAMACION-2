using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades.BasesDeDatos
{
    public static class ADOpersonas
    {
        private static string stringConnection;

        static ADOpersonas() 
        {
            ADOpersonas.stringConnection = "Server=.;Database=Persona;Trusted_Connection=True;";
        }
        /// <summary>
        /// Guardar una persona en la DB
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public static bool Guardar(Persona persona)
        {
            try
            {
                string sentencia = "INSERT INTO Persona (nombre,apellido) VALUES (@nombre,@apellido)";

                using (SqlConnection connection = new SqlConnection(ADOpersonas.stringConnection))
                {

                    SqlCommand commando = new SqlCommand(sentencia, connection);
                    commando.Parameters.AddWithValue("nombre",persona.Nombre);
                    commando.Parameters.AddWithValue("apellido",persona.Apellido);
                    connection.Open();  
                    commando.ExecuteNonQuery();
                    return true;
                }


            }
            catch (Exception ex) 
            {
                throw ex;
            }

        }

        /// <summary>
        /// Devuelve todos las personas de la base de datos
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static List<Persona> Leer() 
        {
            try
            {
                string sentencia = "SELECT * FROM Persona";
                List<Persona> personas = new List<Persona>();


                using (SqlConnection connection = new SqlConnection(ADOpersonas.stringConnection))
                {

                    SqlCommand commando = new SqlCommand(sentencia, connection);
                    connection.Open();

                    SqlDataReader reader = commando.ExecuteReader();

                    while (reader.Read())
                    {
                        personas.Add(new Persona(reader.GetString(1), reader.GetString(2), reader.GetInt32(0)));
                    }
                }

                return personas;


            }
            catch (Exception ex)
            {

            }

            throw new Exception("Error al obtener la persona");


        }

        public static Persona LeerPorId(int id)
        {
            try
            {
                string sentencia = "SELECT * FROM Persona WHERE id=@id";

                using (SqlConnection connection = new SqlConnection(ADOpersonas.stringConnection))
                {

                    SqlCommand commando = new SqlCommand(sentencia, connection);
                    commando.Parameters.AddWithValue("id", id);
                    connection.Open();

                    SqlDataReader reader = commando.ExecuteReader();

                    while (reader.Read())
                    {
                        return new Persona(reader.GetString(1),reader.GetString(2),reader.GetInt32(0));
                    }
                }

                
            }
            catch (Exception ex)
            {
                
            }

            throw new Exception("Error al obtener la persona");
        }

        public static bool Modificar(Persona persona)
        {
            try
            {
                string sentencia = "UPDATE Persona SET nombre=@nombre, apellido=@apellido WHERE id=@id";

                using (SqlConnection connection = new SqlConnection(ADOpersonas.stringConnection))
                {

                    SqlCommand commando = new SqlCommand(sentencia, connection);
                    commando.Parameters.AddWithValue("id", persona.Id);
                    commando.Parameters.AddWithValue("nombre", persona.Nombre);
                    commando.Parameters.AddWithValue("apellido", persona.Apellido);
                    connection.Open();

                    commando.ExecuteNonQuery();
                    return true;
                    
                }


            }
            catch (Exception ex)
            {

            }

            throw new Exception("Error al modificar la persona");
        }

        public static bool Borrar(int id)
        {
            try
            {
                string sentencia = "DELETE FROM Persona WHERE id=@id";

                using (SqlConnection connection = new SqlConnection(ADOpersonas.stringConnection))
                {

                    SqlCommand commando = new SqlCommand(sentencia, connection);
                    commando.Parameters.AddWithValue("id", id);
                    connection.Open();
                    commando.ExecuteNonQuery();
                    return true;

                }


            }
            catch (Exception ex)
            {

            }

            throw new Exception("Error al elimar la persona");
        }

    }

    
}
