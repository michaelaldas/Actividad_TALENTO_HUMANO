using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDatos
{
    public static class Persona
    {
        private static string CadenaConex = @"DESKTOP-GIBA0R2\SQLEXPRESS; database=TI2021; Integrated Security=true";

        public static DataTable getDatos()
        {
            string sql = "select cedula, apellido, nombre, fechadenacimiento, peso "+ "from personas order by apellido, nombre";

            SqlConnection conexion = new SqlConnection(CadenaConex);
            SqlCommand comando = new SqlCommand(sql, conexion);
            //cuando se pone el adaptador no es necesario abrir y cerrar la coneccion porque el la abre y cierra para sacar la informacion
            SqlDataAdapter ad = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public static int Insertar(string cedula, string apellido, string nombre, DateTime fechadenacimiento, double peso)
        {
            SqlConnection conexion = new SqlConnection(CadenaConex);
            string sql = "insert into personas(cedula, apellido, nombre, fechadenacimiento, peso)";
            sql += "values(@cedula, @apellido, @nombre, @fechadenacimiento, @peso)";
            //3. ejecutar la operacion
            SqlCommand comando = new SqlCommand(sql, conexion);
            //3.1 configurar los parametros @cedula, @apellidos, @nombres, @fechadenacimiento, @peso
            comando.Parameters.Add(new SqlParameter("@cedula", cedula));
            comando.Parameters.Add(new SqlParameter("@apellido", apellido));
            comando.Parameters.Add(new SqlParameter("@nombre", nombre));
            comando.Parameters.Add(new SqlParameter("@fechadenacimiento", fechadenacimiento));
            comando.Parameters.Add(new SqlParameter("@peso", peso));
            //3.2 abrir la conexion 
            conexion.Open();
            //3.3 Insertar el registro en la Base de datos
            int res = comando.ExecuteNonQuery();
            //4 Cerrar la conexion
            conexion.Close();
            return res;
        }
    }

}
