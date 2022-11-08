using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;

namespace Login
{
    public partial class Consultas : Form
    {
        private SQLControl oConexion;

        public Consultas()
        {
            InitializeComponent();
            oConexion = new SQLControl();

            Habilitar(true);
        }
        public void Habilitar(bool v)
        {
            lbConsulta1.Visible = !v;
            lbConsulta2.Visible = !v;
            lbConsulta3.Visible = !v;
            lbConsulta4.Visible = !v;
            lbConsulta5.Visible = !v;
            lbConsulta6.Visible = !v;
            lbConsulta7.Visible = !v;
            lbConsulta8.Visible = !v;
            lbConsulta9.Visible = !v;
            txtFecha.Visible = !v;
            btnOk.Visible = !v;

        }
        public void Limpiar()
        {
            lbConsulta1.Hide();
            lbConsulta2.Hide();
            lbConsulta3.Hide();
            lbConsulta4.Hide();
            lbConsulta5.Hide();
            lbConsulta6.Hide();
            lbConsulta7.Hide();
            lbConsulta8.Hide();
            lbConsulta9.Hide();
            txtFecha.Hide();
            btnOk.Hide();
            dgvConsulta.DataSource = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //consulta 1
            Limpiar();
            lbConsulta1.Show();
            oConexion = new SQLControl();
            DataTable tabla = oConexion.ConsultarSQL("select * from vis_vent_sedan");
            dgvConsulta.DataSource = tabla;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta2.Show();//
            oConexion = new SQLControl();
            DataTable tabla = oConexion.ConsultarSQL("select * from vis_empleados");
            dgvConsulta.DataSource = tabla;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta3.Show();
            oConexion = new SQLControl();
            DataTable tabla = oConexion.ConsultarSQL("exec sp_ventas_tipo_clientes");
            dgvConsulta.DataSource = tabla;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta4.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta5.Show();
            oConexion = new SQLControl();
            DataTable tabla = oConexion.ConsultarSQL("select* from vis_emp_pas");
            dgvConsulta.DataSource = tabla;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta6.Show();
            oConexion = new SQLControl();
            DataTable tabla = oConexion.ConsultarSQL("select * from vis_veh_no_ven");
            dgvConsulta.DataSource = tabla;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta7.Show();
            oConexion = new SQLControl();
            DataTable tabla = oConexion.ConsultarSQL("select * from vis_plan_21_22");
            dgvConsulta.DataSource = tabla;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta8.Show();
            oConexion = new SQLControl();
            DataTable tabla = oConexion.ConsultarSQL("select* from vis_modelos_mas_vendidos");
            dgvConsulta.DataSource = tabla;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbConsulta9.Show();
            txtFecha.Show();
            btnOk.Show();
         
            


        }

        private void button2_Click(object sender, EventArgs e)//boton imprimir
        {
            //PrintDocument doc = new PrintDocument();
            //doc.DefaultPageSettings.Landscape = true;
            //doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            //PrintPreviewDialog ppd = new PrintPreviewDialog{Document = doc};
            //((Form)ppd).WindowState = FormWindowState.Maximized;
            //doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            //{
            //    const int DGV_ALTO
            //};
            //ppd.ShowDialog();
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

            btnOk.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
        
            int colum = Convert.ToInt32(txtFecha.Text);
            oConexion = new SQLControl();
            DataTable tabla = oConexion.ConsultarSQL("select * from f_recaudacion_tipo_prod('" + colum + "')");
            dgvConsulta.DataSource = tabla;
            btnOk.Show();

        }

  
    }
}
