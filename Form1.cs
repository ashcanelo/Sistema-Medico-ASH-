using System.Data;
using System.Data.SqlClient;

namespace SistemaMedicoAshly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbcontraseña_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbusername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CerrarBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntrarBTN_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(@"data source=THEKILLERCODE\SQL;Initial Catalog = Login; Integrated Security = True;");

            //SqlCommand command = new SqlCommand("select id_area, nombre,usuario, contraseña from Usuario where usuario = @usuario and contraseña = @clave");
            SqlCommand cmd = new SqlCommand("sp_logueo_ez", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", UserNtxt.Text);
            cmd.Parameters.AddWithValue("@clave", PassWtxt.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido");

                Menu_principal v1 = new Menu_principal();
                this.Hide();
                v1.Show();


            }
            else if (dt.Rows.Count == 0)
            {
                MessageBox.Show("El usuario o contraseña son incorrectos");

            }
        }
    }
}