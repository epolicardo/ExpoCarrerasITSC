using System.Windows.Forms;

namespace CargaDatos
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }


        private void BtnCarga_Click(object sender, System.EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void BtnVerDatos_Click(object sender, System.EventArgs e)
        {
            DB frmdb = new DB();
            frmdb.Show();
        }
    }
}
