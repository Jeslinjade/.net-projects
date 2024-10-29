using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection("Server=KESHIKA\\MSSQLSERVER1;User Id=sa;Password=user123;Database=keshikabd");
            con.Open();
            MessageBox.Show("connection successful");
        }
    }
}
