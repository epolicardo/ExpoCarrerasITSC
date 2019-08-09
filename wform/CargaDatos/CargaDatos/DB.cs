using System.Windows.Forms;
using System.IO;

namespace CargaDatos
{
    public partial class DB : Form
    {
        public DB()
        {
            InitializeComponent();

            string ruta = @"C:\Users\Public\Registros.json";

            if (File.Exists(ruta))
            {
                StreamReader leer = new StreamReader(ruta);
                string linea;

                linea = leer.ReadLine();
                while (linea != null)
                {
                    richTextBox1.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
                leer.Close();
            }

            else
            {
                File.Create(ruta).Dispose();
            }
        }
    }
}
