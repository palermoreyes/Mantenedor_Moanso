using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mantenedor_1
{
    public class DatabaseEmp

    {

    private string connectionString

        = "Data Source = GONZALO-REYES; Initial Catalog=Empleados;" + "User=sa;Password=12345678";

        public List<Empleado> Get()

        { 
            List<Empleado> empleado = new List<Empleado>();

            string query = "select id, nombre, dni, edad, sueldo";

            using (SqlConnection connection = new SqlConnection(connectionString))

        {
            SqlCommand command = new SqlCommand(query, connection);

        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            while(reader.Read())

           {
            Empleado oEmpleado = new Empleado();
            oEmpleado.id = reader.GetInt32(0);
            oEmpleado.nombre = reader.GetString(1);
            oEmpleado.dni = reader.GetInt32(2);
            oEmpleado.edad = reader.GetInt32(3);
            oEmpleado.sueldo = reader.GetDecimal(4);
            empleado.Add(oEmpleado);

           }
        reader.Close();
        connection.Close();

            }
         catch (Exception ex)

            {
                    throw new Exception("Ocurrió un error al conectar la base de datos" + ex.Message);
                }
            }

                return empleado;

    }

        public void Add (string nombre, int dni, int edad, decimal sueldo)

        {
            string query = "insert into Empleado (nombre, dni, edad, sueldo) values" + "(@nombre, @dni, @edad, @sueldo)";

        {
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@sueldo", sueldo);

                    try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();

                }
                catch (Exception ex)

                {
                    throw new Exception("Ocurrió un error al conectar la base de datos" + ex.Message);
                }
            }

        }

 }

public class Empleado
{

    public int id { get; set; }
    public string nombre { get; set; }
    public int dni { get; set; }
    public int edad { get; set; }
    public decimal sueldo { get; set; }
}

}
}