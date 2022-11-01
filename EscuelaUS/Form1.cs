using EscuelaUS.datos;
using EscuelaUS.datos.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaUS
{
    public partial class Universidad : Form
    {
        public Universidad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //boton guardar
        {
            //validar campos del formulario formNombre formCalificacion
            if (dbnombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre");
            }
            else if (dbnombre.Text.Trim().Length <= 5)
            {
                MessageBox.Show("Ingrese un nombre mayor a 5 caracteres");
            }
            else
            {
                //llamar al modelo
                Alumno al = new Alumno();
                al.Nombre = dbnombre.Text.Trim().ToUpper();//paso del formulario al atributo del modelo
                al.Calificacion = Convert.ToInt32(formCalificacion.Text.Trim());

                if (AlumnoController.guardar(al))
                {
                    LlenarGrid();
                    limpiarCampos();
                    MessageBox.Show("Alumno Registrado");

                }
                else
                {
                    MessageBox.Show("Fallo");
                }


            }
        }
        private void LlenarGrid()
        {
            DataTable datos = AlumnoController.listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a datos");
            }
            else
            {
                dglista.DataSource = datos.DefaultView;
            }
        }

        private void limpiarCampos()
            {
                dbnombre.Text = "";
                formCalificacion.Text = "";

            }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Universidad_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dbnombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre");
            }
            else
            {
               Alumno alm = AlumnoController.consultar(dbnombre.Text.Trim());
                if (alm == null)
                {
                    MessageBox.Show("No existe alumno con nombre " + dbnombre.Text);
                    limpiarCampos();
                }
                else
                {
                    dbnombre.Text = alm.Nombre;
                    formCalificacion.Text = alm.Calificacion.ToString();
                }
            }
        }
    }
}
