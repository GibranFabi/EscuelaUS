using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaUS.datos
{
    class Conexion
    {
        SqlConnection con;//instacia
        
        public Conexion() //Constructor inicialice la clase con valores
        {
            con = new SqlConnection("Data Source=DESKTOP-CP9KRL0;Initial Catalog=Universidad;Integrated Security=True");
        }
        public SqlConnection conectar()
        {
            con.Open();
            return con;
        }
        public bool desconectar()
        {
            con.Close();
            return true;
        }
    }
}

