using System.Windows.Forms;
using System.IO;

namespace CargaDatos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        string ruta = @"C:\Users\Public\Registros.json";

        private void BtnEstablecimiento_CheckedChanged(object sender, System.EventArgs e)
        {
            if (btnEstablecimiento.Checked == true)
            {
                panelDatos.Visible = true;
            }
            else
            {
                panelDatos.Visible = false;
            }

        }

        private void BtnCargar_Click(object sender, System.EventArgs e)
        {


            void Camposvacios()
            {
                txtEscuela.Text = "";
                txtOrient.Text = "";
                txtProfes.Text = "";
                txtCant.Text = "";
                txtCurso.Text = "";
            }


            StreamWriter escribir = new StreamWriter(ruta, true);

            if (btnParticular.Checked == true)
            {
                Camposvacios();

                escribir.WriteLine("Escuela: " + "Particular" + ", "
                                  + "Orientación: " + "N/A" + ", "
                                  + "Profesor: " + "N/A" + ", "
                                  + "Cantidad alumnos: " + "1" + ", "
                                  + "Curso: " + "N/A");

                escribir.WriteLine(" ");

                MessageBox.Show("Datos cargados correctamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txtEscuela.Text == "")
            {
                MessageBox.Show("Campo vacio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (!File.Exists(ruta))
                {

                    File.Create(ruta).Dispose();
                }

                escribir.WriteLine("Escuela: " + txtEscuela.Text + ", "
                                     + "Orientación: " + txtOrient.Text + ", "
                                     + "Profesor: " + txtProfes.Text + ", "
                                     + "Cantidad alumnos: " + txtCant.Text + ", "
                                     + "Curso: " + txtCurso.Text);

                escribir.WriteLine(" ");

                Camposvacios();

                MessageBox.Show("Datos cargados correctamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            escribir.Close();

        }
    }
}