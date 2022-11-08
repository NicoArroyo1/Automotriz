namespace AutomotrizClient
{
    partial class Autopartes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboModelos = new System.Windows.Forms.ComboBox();
            this.txtNroSerie = new System.Windows.Forms.TextBox();
            this.cboVehiculos = new System.Windows.Forms.ComboBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPre_unitario = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_tipo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_tipo_vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkTodos = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.labelNroSerie = new System.Windows.Forms.Label();
            this.labelModelos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardarEdit = new System.Windows.Forms.Button();
            this.LabelEdit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboModelos
            // 
            this.cboModelos.FormattingEnabled = true;
            this.cboModelos.Location = new System.Drawing.Point(30, 78);
            this.cboModelos.Name = "cboModelos";
            this.cboModelos.Size = new System.Drawing.Size(287, 23);
            this.cboModelos.TabIndex = 0;
            // 
            // txtNroSerie
            // 
            this.txtNroSerie.Location = new System.Drawing.Point(30, 25);
            this.txtNroSerie.Name = "txtNroSerie";
            this.txtNroSerie.Size = new System.Drawing.Size(170, 23);
            this.txtNroSerie.TabIndex = 1;
            // 
            // cboVehiculos
            // 
            this.cboVehiculos.FormattingEnabled = true;
            this.cboVehiculos.Location = new System.Drawing.Point(433, 78);
            this.cboVehiculos.Name = "cboVehiculos";
            this.cboVehiculos.Size = new System.Drawing.Size(285, 23);
            this.cboVehiculos.TabIndex = 2;
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(433, 131);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(219, 23);
            this.dtPicker.TabIndex = 3;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(433, 27);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(285, 23);
            this.txtColor.TabIndex = 4;
            // 
            // txtPre_unitario
            // 
            this.txtPre_unitario.Location = new System.Drawing.Point(30, 131);
            this.txtPre_unitario.Name = "txtPre_unitario";
            this.txtPre_unitario.Size = new System.Drawing.Size(287, 23);
            this.txtPre_unitario.TabIndex = 5;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(55, 398);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(614, 398);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "cod_producto";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // cod_tipo_producto
            // 
            this.cod_tipo_producto.HeaderText = "cod_tipo_producto";
            this.cod_tipo_producto.Name = "cod_tipo_producto";
            this.cod_tipo_producto.Visible = false;
            // 
            // cod_modelo
            // 
            this.cod_modelo.HeaderText = "cod_modelo";
            this.cod_modelo.Name = "cod_modelo";
            // 
            // color
            // 
            this.color.HeaderText = "color";
            this.color.Name = "color";
            // 
            // cod_tipo_vehiculo
            // 
            this.cod_tipo_vehiculo.HeaderText = "cod_tipo_vehiculo";
            this.cod_tipo_vehiculo.Name = "cod_tipo_vehiculo";
            this.cod_tipo_vehiculo.Visible = false;
            // 
            // precio
            // 
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.nro_serie,
            this.tipo_producto,
            this.modelo,
            this.dataGridViewTextBoxColumn1,
            this.tipo_vehiculo,
            this.precio2,
            this.fabricacion});
            this.dataGridView1.Location = new System.Drawing.Point(66, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(652, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // producto
            // 
            this.producto.HeaderText = "Codigo";
            this.producto.Name = "producto";
            // 
            // nro_serie
            // 
            this.nro_serie.HeaderText = "Numero Serie";
            this.nro_serie.Name = "nro_serie";
            // 
            // tipo_producto
            // 
            this.tipo_producto.HeaderText = "tipo_producto";
            this.tipo_producto.Name = "tipo_producto";
            this.tipo_producto.Visible = false;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo ";
            this.modelo.Name = "modelo";
            this.modelo.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Color";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // tipo_vehiculo
            // 
            this.tipo_vehiculo.HeaderText = "Tipo Vehiculo";
            this.tipo_vehiculo.Name = "tipo_vehiculo";
            this.tipo_vehiculo.Visible = false;
            // 
            // precio2
            // 
            this.precio2.HeaderText = "Precio";
            this.precio2.Name = "precio2";
            // 
            // fabricacion
            // 
            this.fabricacion.HeaderText = "Fecha y hora de fabricacion";
            this.fabricacion.Name = "fabricacion";
            this.fabricacion.Width = 150;
            // 
            // checkTodos
            // 
            this.checkTodos.AutoSize = true;
            this.checkTodos.Location = new System.Drawing.Point(206, 29);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Size = new System.Drawing.Size(57, 19);
            this.checkTodos.TabIndex = 10;
            this.checkTodos.Text = "Todos";
            this.checkTodos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(269, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelNroSerie
            // 
            this.labelNroSerie.AutoSize = true;
            this.labelNroSerie.Location = new System.Drawing.Point(30, 7);
            this.labelNroSerie.Name = "labelNroSerie";
            this.labelNroSerie.Size = new System.Drawing.Size(79, 15);
            this.labelNroSerie.TabIndex = 12;
            this.labelNroSerie.Text = "Numero Serie";
            // 
            // labelModelos
            // 
            this.labelModelos.AutoSize = true;
            this.labelModelos.Location = new System.Drawing.Point(30, 60);
            this.labelModelos.Name = "labelModelos";
            this.labelModelos.Size = new System.Drawing.Size(53, 15);
            this.labelModelos.TabIndex = 13;
            this.labelModelos.Text = "Modelos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo Vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Precio";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(153, 398);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(374, 398);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardarEdit
            // 
            this.btnGuardarEdit.Location = new System.Drawing.Point(467, 398);
            this.btnGuardarEdit.Name = "btnGuardarEdit";
            this.btnGuardarEdit.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarEdit.TabIndex = 19;
            this.btnGuardarEdit.Text = "Guardar";
            this.btnGuardarEdit.UseVisualStyleBackColor = true;
            this.btnGuardarEdit.Click += new System.EventHandler(this.btnGuardarEdit_Click);
            // 
            // LabelEdit
            // 
            this.LabelEdit.AutoSize = true;
            this.LabelEdit.Location = new System.Drawing.Point(374, 358);
            this.LabelEdit.Name = "LabelEdit";
            this.LabelEdit.Size = new System.Drawing.Size(57, 15);
            this.LabelEdit.TabIndex = 20;
            this.LabelEdit.Text = "Indicador";
            this.LabelEdit.Visible = false;
            // 
            // Autopartes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 443);
            this.Controls.Add(this.LabelEdit);
            this.Controls.Add(this.btnGuardarEdit);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelModelos);
            this.Controls.Add(this.labelNroSerie);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.checkTodos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtPre_unitario);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.cboVehiculos);
            this.Controls.Add(this.txtNroSerie);
            this.Controls.Add(this.cboModelos);
            this.Name = "Autopartes";
            this.Text = "Autopartes";
            this.Load += new System.EventHandler(this.Autopartes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboModelos;
        private TextBox txtNroSerie;
        private ComboBox cboVehiculos;
        private DateTimePicker dtPicker;
        private TextBox txtColor;
        private TextBox txtPre_unitario;
        private Button btnNuevo;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn cod_tipo_producto;
        private DataGridViewTextBoxColumn cod_modelo;
        private DataGridViewTextBoxColumn color;
        private DataGridViewTextBoxColumn cod_tipo_vehiculo;
        private DataGridViewTextBoxColumn precio;
        private DataGridView dataGridView1;
        private CheckBox checkTodos;
        private Button btnBuscar;
        private Label labelNroSerie;
        private Label labelModelos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGuardar;
        private Button btnEditar;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn nro_serie;
        private DataGridViewTextBoxColumn tipo_producto;
        private DataGridViewTextBoxColumn modelo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tipo_vehiculo;
        private DataGridViewTextBoxColumn precio2;
        private DataGridViewTextBoxColumn fabricacion;
        private Button btnGuardarEdit;
        private Label LabelEdit;
    }
}