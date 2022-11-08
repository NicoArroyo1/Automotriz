namespace Login
{
    public partial class Login : Form
    {
        SQLControl sqlControl = new SQLControl();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int result = sqlControl.Login(txtUsuario.Text, txtContraseña.Text);
            if (result == 1)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
            }else if (result == 0)
            {
                MessageBox.Show("¡¡Usuario o contraseña incorrecta!!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}