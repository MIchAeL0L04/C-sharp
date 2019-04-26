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
namespace ProjetoBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-VPREGEP2\\SQLSERVER014;Initial Catalog=ProjetoBanco;User ID=sa;Password=1234567");
        SqlCommand comando = new SqlCommand();

        private void Form1_Load(object sender, EventArgs e)
        {
            comando.Connection = con;
        }

        private void btmInserir_Click(object sender, EventArgs e)
        {
            con.Open();
            comando.CommandText = "INSERT INTO dados(id,nome) VALUES('" + txtId.Text + "','" + txtNome.Text + "')";
            comando.ExecuteNonQuery();
            con.Close();

            txtId.Text = "";
            txtNome.Text = "";
        }
    }
}
