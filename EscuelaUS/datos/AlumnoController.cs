using EscuelaUS.datos.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaUS.datos
{
    class AlumnoController
    {
        public static bool guardar(Alumno al)//juan,95
        {
            //conectarme a la bd
            Conexion con = new Conexion();
            //pasar la consulta INSERT INTO Alumno(nombre, calificacion) VALUES('juan',95))
            string sql = "INSERT INTO Alumno(nombre, calificacion) VALUES('" + al.Nombre + "','" + al.Calificacion + "')";
            //acceder a la base y pasarle la consulta
            SqlCommand inserta = new SqlCommand(sql, con.conectar());//(INSERT INTO Alumno(nombre, calificacion) VALUES('juan',95)),("Data Source=DESKTOP-CFRSQB1\\SQLEXPRESS;Initial Catalog=Universidad;Integrated Security=True")
            //contar las filas insertadas
            int insertados = inserta.ExecuteNonQuery();//1
            if (insertados == 1)
            {
                con.desconectar();//cierro conexion
                return true;
            }
            else
            {
                con.desconectar();
                return false;
            }
        }


        public static DataTable listar()//juan,95
        {
            //conectarme a la bd
            Conexion con = new Conexion();
            //pasar la consulta INSERT INTO Alumno(nombre, calificacion) VALUES('juan',95))
            string sql = "SELECT * FROM dbo.Alumno;";
            //acceder a la base y pasarle la consulta
            SqlCommand inserta = new SqlCommand(sql, con.conectar());//(INSERT INTO Alumno(nombre, calificacion) VALUES('juan',95)),("Data Source=DESKTOP-CFRSQB1\\SQLEXPRESS;Initial Catalog=Universidad;Integrated Security=True")
            //contar las filas insertadas
            SqlDataReader dr = inserta.ExecuteReader(CommandBehavior.CloseConnection);//1
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.desconectar();
            return dt;
        }

        public static Alumno consultar(string nombre)//juan,95
        {
            //conectarme a la bd
            Conexion con = new Conexion();
            //pasar la consulta INSERT INTO Alumno(nombre, calificacion) VALUES('juan',95))
            string sql = "SELECT * FROM dbo.Alumno WHERE nombre = '" + nombre + "';";
            //acceder a la base y pasarle la consulta
            SqlCommand inserta = new SqlCommand(sql, con.conectar());//(INSERT INTO Alumno(nombre, calificacion) VALUES('juan',95)),("Data Source=DESKTOP-CFRSQB1\\SQLEXPRESS;Initial Catalog=Universidad;Integrated Security=True")
            //contar las filas insertadas
            SqlDataReader dr = inserta.ExecuteReader();//1
            Alumno alm = new Alumno();
            if (dr.Read())
            {
                alm.Nombre = dr["nombre"].ToString();
                alm.Calificacion = Convert.ToInt32(dr["Calificacion"].ToString());
                con.desconectar();
                return alm;
            }
            else
            {
                con.desconectar();
                return null;
            }
        }
        public static bool actualizar(Alumno al)
        {
            //conectarme a la bd
            Conexion con = new Conexion();
            //pasar la consulta INSERT INTO Alumno(nombre, calificacion) VALUES('juan',95))
            string sql = "update dbo.Alumno SET nombre='" + al.Nombre + "' ,calificacion='" + al.Calificacion + "'  where nombre='" + al.Nombre + "'";
            //acceder a la base y pasarle la consulta
            SqlCommand inserta = new SqlCommand(sql, con.conectar());//(INSERT INTO Alumno(nombre, calificacion) VALUES('juan',95)),("Data Source=DESKTOP-CFRSQB1\\SQLEXPRESS;Initial Catalog=Universidad;Integrated Security=True")
            int insertados = inserta.ExecuteNonQuery();
            if (insertados == 1)
            {
                con.desconectar();
                return true;
            }
            else
            {
                con.desconectar();
                return false;
            }
        }
        public static bool eliminar(string nombre)//juan,95
        {
            try
            {

                //conectarme a la bd
                Conexion con = new Conexion();
                //pasar la consulta INSERT INTO Alumno(nombre, calificacion) VALUES('juan',95))
                string sql = "DELETE FROM Alumno where nombre='" + nombre + "'";
                //acceder a la base y pasarle la consulta
                SqlCommand inserta = new SqlCommand(sql, con.conectar());//(INSERT INTO Alumno(nombre, calificacion) VALUES('juan',95)),("Data Source=DESKTOP-CFRSQB1\\SQLEXPRESS;Initial Catalog=Universidad;Integrated Security=True")
                                                                         //contar las filas insertadas
                int insertados = inserta.ExecuteNonQuery();//1
                if (insertados == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}

