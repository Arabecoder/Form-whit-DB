using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login2
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-245O333\\MSSQLSERVER01; Initial Catalog=Login1; Integrated Security=true;");
        
        public Form1()
        {
            InitializeComponent();
        }

        public void Logins()
        {
            try
            {
                using (SqlCommand comando = new SqlCommand("SELECT Username, Passwords FROM Users WHERE Username='" + txtuser.Text + "' AND Passwords='" + txtpass.Text + "'", conexion))
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.Read())
                    {
                        prgbar1.Visible = true;
                        timer1.Enabled = true;
                        
                        
                        MessageBox.Show("Bienvenido!!!...");
                    }
                    else
                    {
                        MessageBox.Show("Favor revisar tus datos e intentar nuevamente...");
                    }
                    conexion.Close();
                }
            }catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prgbar1.Value = prgbar1.Value + 4;
            if (prgbar1.Value == 100)
            {
                Form2 ff = new Form2();
                ff.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            Logins();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
