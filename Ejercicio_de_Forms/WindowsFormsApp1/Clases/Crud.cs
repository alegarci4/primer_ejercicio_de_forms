using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    public class Crud
    {

        string connectionString = "Server=ALE_GARCIA\\SQLEXPRESS;Database=Ejercicio_en_clase;Integrated Security=True; TrustServerCertificate=True; ";
        public string MostrarInformacion(string carnet)
        {
            string nombre = "No Existe";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String query = $"SELECT * FROM Tb_alumnos where carnet = '{carnet}'";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        nombre = reader["estudiante"].ToString();

                    }

                }
                catch (Exception ex)
                {
                    nombre = "Error";

                    //Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
                connection.Close();
            }
            return nombre;

        }
        public string MostrarInformacionSeccion(string carnet)
        {

            string seccion = "No Existe";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String query = $"SELECT * FROM Tb_alumnos where carnet = '{carnet}'";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        seccion = reader["seccion"].ToString();

                    }

                }
                catch (Exception ex)
                {

                    seccion = "Error";


                    //Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
                connection.Close();
            }
            return seccion;

        }
        public string MostrarInformacionCorreo(string carnet)
        {

            string correo = "No Existe";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String query = $"SELECT * FROM Tb_alumnos where carnet = '{carnet}'";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        correo = reader["email"].ToString();

                    }

                }
                catch (Exception ex)
                {

                    correo = "Error";


                    //Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
                connection.Close();
            }
            return correo;

        }

        public int AgregarAlumno(string carnet, string nombre, string seccion, string email)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO tb_alumnos (carnet, estudiante, seccion, email) VALUES (@carnet, @nombre, @seccion, @email)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@seccion", seccion);
                    command.Parameters.AddWithValue("@email", email);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Alumno agregado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se pudo agregar el alumno.");
                    }
                    return rowsAffected;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("ups error al conectar a la base de datos: " + ex.Message);
                    return -1;
                }
                connection.Close();
            }


        }

        public string MostrarNotas(string carnet)
        {
            string resultado = "No Existe";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String query = $"SELECT * FROM tareas WHERE carnet = $Carnet";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Carnet", carnet);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        resultado = $"Nota1: {reader["nota1"]}, Nota2: {reader["nota2"]}, Nota3: {reader["nota3"]}";
                    }
                }
                catch (Exception ex)
                {
                    resultado = "Error";
                    //Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
                connection.Close();
            }
            return resultado;
        }
        










    }
}

