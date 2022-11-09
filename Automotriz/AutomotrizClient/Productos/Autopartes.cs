using Aplicacion.Datos;
using Aplicacion.Dominio;
using AutomotrizClient.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutomotrizClient
{
    public partial class Autopartes : Form
    {
        SQLControl data = new SQLControl();

        public Autopartes()
        {
            InitializeComponent();
        }

        private void Autopartes_Load(object sender, EventArgs e)
        {
            cargarcomboModelos();
            cargarcomboVehiculosAsync();
            inicio();
            limpiar();
            checkTodos.Checked = true;
        }

        private void limpiar()
        {
            cboVehiculos.SelectedIndex = -1;
            cboModelos.SelectedIndex = -1;
            txtColor.Text = String.Empty;
            txtNroSerie.Text = String.Empty;
            txtPre_unitario.Text = String.Empty;
        }

        private void inicio()
        {
            btnBuscar.Enabled = true;
            checkTodos.Enabled=true;
            cboModelos.Enabled = false;
            cboVehiculos.Enabled = false;
            txtColor.Enabled = false;
            txtPre_unitario.Enabled = false;
            dtPicker.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnGuardarEdit.Enabled = false;
        }

        private async void cargarcomboVehiculosAsync()
        {
            string url = "http://localhost:5127/tipos_vehiculos";
            var res = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Automovil>>(res);
            cboVehiculos.DataSource = lst;
            cboVehiculos.ValueMember = "Codigo";
            cboVehiculos.DisplayMember = "Tipo";
            cboVehiculos.SelectedIndex = -1;
        }

        private void cargarcomboModelos()
        {
            cboModelos.DataSource = data.ConsultarSQL("select * from modelos");
            cboModelos.ValueMember = "cod_modelo";
            cboModelos.DisplayMember = "modelo";
            cboModelos.SelectedIndex = -1;
        }

        private void llenar_grilla(string query)
        {
            DataTable tabla;
            tabla = data.ConsultarSQL(query);
            foreach (DataRow fila in tabla.Rows)
            {
                dataGridView1.Rows.Add(new object[] { fila["cod_producto"],
                    fila["nro_serie"],
                    fila["cod_tipo_producto"],
                    fila["cod_modelo"],
                    fila["color"],
                    fila["cod_tipo_vehiculo"],
                    fila["pre_unitario"],
                    fila["fecha_fabricacion"]
                });
            }
        }
        private void validacion()
        {

            if (cboModelos.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un Modelo!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboVehiculos.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un Vehiculo!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (txtColor.Text == "")
            {
                MessageBox.Show("Debe ingresar un color!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtNroSerie.Text == "")
            {
                MessageBox.Show("Debe ingresar un numero de serie!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtPre_unitario.Text == "" || !int.TryParse(txtPre_unitario.Text, out _))
            {
                MessageBox.Show("Debe ingresar un precio valido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            cboModelos.Enabled = true;
            cboVehiculos.Enabled = true;
            txtColor.Enabled = true;
            txtPre_unitario.Enabled = true;
            dtPicker.Enabled = true;
            btnGuardar.Enabled = true;
            checkTodos.Enabled = false;
            btnBuscar.Enabled = false;
            btnGuardar.Visible = true;
            LabelEdit.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int nro = int.Parse(dataGridView1.CurrentRow.Cells["producto"].Value.ToString());
            data.EliminarSQL(nro);
            MessageBox.Show("Se elimino correctamente");
            dataGridView1.Rows.Clear();
            inicio();
            limpiar();
            LabelEdit.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            if (checkTodos.Checked)
            {
                llenar_grilla("select * from productos where cod_tipo_producto=2");
            }
            else
            {
                string aux;
                aux = "select * from productos where nro_serie like '" + txtNroSerie.Text+ "%'";
                llenar_grilla(aux);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            validacion();
            Autoparte autoparte = new Autoparte();
            autoparte.nroSerie = txtNroSerie.Text;
            autoparte.color = txtColor.Text;
            autoparte.pre_unitario = Convert.ToInt32(txtPre_unitario.Text);
            autoparte.cod_modelo = Convert.ToInt32(cboModelos.SelectedValue);
            autoparte.cod_tipo_vehiculo = Convert.ToInt32(cboVehiculos.SelectedValue);
            autoparte.cod_tipo_producto = 2;
            autoparte.fecha_fabricacion = dtPicker.Value;
            data.InsertarSQL(autoparte);
            MessageBox.Show("Se guardo correctamente");
            dataGridView1.Rows.Clear();
            inicio();
            limpiar();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            limpiar();
            btnGuardar.Visible = false;
            cboModelos.Enabled = true;
            cboVehiculos.Enabled = true;
            txtColor.Enabled = true;
            txtPre_unitario.Enabled = true;
            dtPicker.Enabled = true;
            txtNroSerie.Enabled = true;
            btnGuardarEdit.Enabled = true;
            int nro = int.Parse(dataGridView1.CurrentRow.Cells["producto"].Value.ToString());
            LabelEdit.Visible = true;
            LabelEdit.Text = "Se esta editando el producto con codigo : :" + Convert.ToString(nro);
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
        }
        private void btnGuardarEdit_Click(object sender, EventArgs e)
        {
            validacion();
            Autoparte autoparte = new Autoparte();
            int nro = int.Parse(dataGridView1.CurrentRow.Cells["producto"].Value.ToString());
            autoparte.codigo = nro;
            autoparte.nroSerie = txtNroSerie.Text;
            autoparte.color = txtColor.Text;
            autoparte.pre_unitario = Convert.ToInt32(txtPre_unitario.Text);
            autoparte.cod_modelo = Convert.ToInt32(cboModelos.SelectedValue);
            autoparte.cod_tipo_vehiculo = Convert.ToInt32(cboVehiculos.SelectedValue);
            autoparte.cod_tipo_producto = 2;
            autoparte.fecha_fabricacion = dtPicker.Value;
            data.Updatear(autoparte);
            MessageBox.Show("Se edito correctamente");
            dataGridView1.Rows.Clear();
            inicio();
            limpiar();
            LabelEdit.Visible = false;
        }

        private void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
