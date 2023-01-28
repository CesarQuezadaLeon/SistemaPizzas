namespace Proyecto
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DWVProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.brnAlta = new System.Windows.Forms.Button();
            this.DataVentas = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtIdDetalleVenta = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnConsultarDEtalle = new System.Windows.Forms.Button();
            this.bntEliminarDetalleVenta = new System.Windows.Forms.Button();
            this.btnActualizarDetalle = new System.Windows.Forms.Button();
            this.btnAltaDetalle = new System.Windows.Forms.Button();
            this.txtCodigocliente = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoempleado = new System.Windows.Forms.TextBox();
            this.txtCodigoVenta = new System.Windows.Forms.TextBox();
            this.TxtFechaVenta = new System.Windows.Forms.TextBox();
            this.txtCantidadDetalle = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DataDetalleVentas = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ComboVehiculo = new System.Windows.Forms.ComboBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtCodigoTransporte = new System.Windows.Forms.TextBox();
            this.txtDetalleVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnElimi = new System.Windows.Forms.Button();
            this.btnActua = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.DataViajes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DWVProductos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataVentas)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDetalleVentas)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Administracion";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.vehiculosToolStripMenuItem,
            this.materiaPrimaToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(100, 20);
            this.Menu.Text = "Administracion";
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // materiaPrimaToolStripMenuItem
            // 
            this.materiaPrimaToolStripMenuItem.Name = "materiaPrimaToolStripMenuItem";
            this.materiaPrimaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.materiaPrimaToolStripMenuItem.Text = "Materia Prima";
            this.materiaPrimaToolStripMenuItem.Click += new System.EventHandler(this.MateriaPrimaToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // DWVProductos
            // 
            this.DWVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DWVProductos.Location = new System.Drawing.Point(6, 110);
            this.DWVProductos.Name = "DWVProductos";
            this.DWVProductos.Size = new System.Drawing.Size(756, 258);
            this.DWVProductos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Producto";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(170, 27);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 3;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(353, 23);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 411);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DWVProductos);
            this.tabPage1.Controls.Add(this.btnBusqueda);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtBusqueda);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtIdVenta);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnConsulta);
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Controls.Add(this.btnActualizar);
            this.tabPage2.Controls.Add(this.brnAlta);
            this.tabPage2.Controls.Add(this.DataVentas);
            this.tabPage2.Controls.Add(this.txtCantidad);
            this.tabPage2.Controls.Add(this.txtMonto);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ventas";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(498, 119);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(100, 20);
            this.txtIdVenta.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "clave Venta";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(214, 119);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 8;
            this.btnConsulta.Text = "Registro";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(314, 118);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(108, 119);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // brnAlta
            // 
            this.brnAlta.Location = new System.Drawing.Point(7, 119);
            this.brnAlta.Name = "brnAlta";
            this.brnAlta.Size = new System.Drawing.Size(75, 23);
            this.brnAlta.TabIndex = 5;
            this.brnAlta.Text = "Registrar";
            this.brnAlta.UseVisualStyleBackColor = true;
            this.brnAlta.Click += new System.EventHandler(this.BrnAlta_Click);
            // 
            // DataVentas
            // 
            this.DataVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataVentas.Location = new System.Drawing.Point(7, 164);
            this.DataVentas.Name = "DataVentas";
            this.DataVentas.Size = new System.Drawing.Size(755, 204);
            this.DataVentas.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(142, 67);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(142, 19);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtIdDetalleVenta);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.btnConsultarDEtalle);
            this.tabPage3.Controls.Add(this.bntEliminarDetalleVenta);
            this.tabPage3.Controls.Add(this.btnActualizarDetalle);
            this.tabPage3.Controls.Add(this.btnAltaDetalle);
            this.tabPage3.Controls.Add(this.txtCodigocliente);
            this.tabPage3.Controls.Add(this.txtCodigoProducto);
            this.tabPage3.Controls.Add(this.txtCodigoempleado);
            this.tabPage3.Controls.Add(this.txtCodigoVenta);
            this.tabPage3.Controls.Add(this.TxtFechaVenta);
            this.tabPage3.Controls.Add(this.txtCantidadDetalle);
            this.tabPage3.Controls.Add(this.txtDescuento);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.DataDetalleVentas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 385);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Detalles de ventas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtIdDetalleVenta
            // 
            this.txtIdDetalleVenta.Location = new System.Drawing.Point(649, 187);
            this.txtIdDetalleVenta.Name = "txtIdDetalleVenta";
            this.txtIdDetalleVenta.Size = new System.Drawing.Size(100, 20);
            this.txtIdDetalleVenta.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(577, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "codigo";
            // 
            // btnConsultarDEtalle
            // 
            this.btnConsultarDEtalle.Location = new System.Drawing.Point(324, 187);
            this.btnConsultarDEtalle.Name = "btnConsultarDEtalle";
            this.btnConsultarDEtalle.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarDEtalle.TabIndex = 18;
            this.btnConsultarDEtalle.Text = "Consultar";
            this.btnConsultarDEtalle.UseVisualStyleBackColor = true;
            this.btnConsultarDEtalle.Click += new System.EventHandler(this.BtnConsultarDEtalle_Click);
            // 
            // bntEliminarDetalleVenta
            // 
            this.bntEliminarDetalleVenta.Location = new System.Drawing.Point(486, 185);
            this.bntEliminarDetalleVenta.Name = "bntEliminarDetalleVenta";
            this.bntEliminarDetalleVenta.Size = new System.Drawing.Size(75, 23);
            this.bntEliminarDetalleVenta.TabIndex = 17;
            this.bntEliminarDetalleVenta.Text = "eliminar";
            this.bntEliminarDetalleVenta.UseVisualStyleBackColor = true;
            this.bntEliminarDetalleVenta.Click += new System.EventHandler(this.BntEliminarDetalleVenta_Click);
            // 
            // btnActualizarDetalle
            // 
            this.btnActualizarDetalle.Location = new System.Drawing.Point(486, 121);
            this.btnActualizarDetalle.Name = "btnActualizarDetalle";
            this.btnActualizarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarDetalle.TabIndex = 16;
            this.btnActualizarDetalle.Text = "Actualizar ";
            this.btnActualizarDetalle.UseVisualStyleBackColor = true;
            this.btnActualizarDetalle.Click += new System.EventHandler(this.BtnActualizarDetalle_Click);
            // 
            // btnAltaDetalle
            // 
            this.btnAltaDetalle.Location = new System.Drawing.Point(324, 119);
            this.btnAltaDetalle.Name = "btnAltaDetalle";
            this.btnAltaDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnAltaDetalle.TabIndex = 15;
            this.btnAltaDetalle.Text = "Registrar";
            this.btnAltaDetalle.UseVisualStyleBackColor = true;
            this.btnAltaDetalle.Click += new System.EventHandler(this.BtnAltaDetalle_Click);
            // 
            // txtCodigocliente
            // 
            this.txtCodigocliente.Location = new System.Drawing.Point(409, 54);
            this.txtCodigocliente.Name = "txtCodigocliente";
            this.txtCodigocliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodigocliente.TabIndex = 14;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(409, 17);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProducto.TabIndex = 13;
            // 
            // txtCodigoempleado
            // 
            this.txtCodigoempleado.Location = new System.Drawing.Point(120, 157);
            this.txtCodigoempleado.Name = "txtCodigoempleado";
            this.txtCodigoempleado.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoempleado.TabIndex = 12;
            // 
            // txtCodigoVenta
            // 
            this.txtCodigoVenta.Location = new System.Drawing.Point(120, 119);
            this.txtCodigoVenta.Name = "txtCodigoVenta";
            this.txtCodigoVenta.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoVenta.TabIndex = 11;
            // 
            // TxtFechaVenta
            // 
            this.TxtFechaVenta.Location = new System.Drawing.Point(120, 84);
            this.TxtFechaVenta.Name = "TxtFechaVenta";
            this.TxtFechaVenta.Size = new System.Drawing.Size(100, 20);
            this.TxtFechaVenta.TabIndex = 10;
            // 
            // txtCantidadDetalle
            // 
            this.txtCantidadDetalle.Location = new System.Drawing.Point(120, 47);
            this.txtCantidadDetalle.Name = "txtCantidadDetalle";
            this.txtCantidadDetalle.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadDetalle.TabIndex = 9;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(120, 13);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(321, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Codigo Cliente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(321, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Codigo Producto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Codigo Empleado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Codigo Venta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Fecha de Venta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Descuento";
            // 
            // DataDetalleVentas
            // 
            this.DataDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDetalleVentas.Location = new System.Drawing.Point(7, 228);
            this.DataDetalleVentas.Name = "DataDetalleVentas";
            this.DataDetalleVentas.Size = new System.Drawing.Size(755, 151);
            this.DataDetalleVentas.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ComboVehiculo);
            this.tabPage4.Controls.Add(this.txtDestino);
            this.tabPage4.Controls.Add(this.txtCodigoTransporte);
            this.tabPage4.Controls.Add(this.txtDetalleVenta);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.btnMostrar);
            this.tabPage4.Controls.Add(this.btnElimi);
            this.tabPage4.Controls.Add(this.btnActua);
            this.tabPage4.Controls.Add(this.btnAlta);
            this.tabPage4.Controls.Add(this.DataViajes);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 385);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Viajes";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.TabPage4_Click);
            // 
            // ComboVehiculo
            // 
            this.ComboVehiculo.FormattingEnabled = true;
            this.ComboVehiculo.Location = new System.Drawing.Point(377, 57);
            this.ComboVehiculo.Name = "ComboVehiculo";
            this.ComboVehiculo.Size = new System.Drawing.Size(121, 21);
            this.ComboVehiculo.TabIndex = 18;
            this.ComboVehiculo.SelectedIndexChanged += new System.EventHandler(this.ComboVehiculo_SelectedIndexChanged);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(234, 99);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 20);
            this.txtDestino.TabIndex = 17;
            // 
            // txtCodigoTransporte
            // 
            this.txtCodigoTransporte.Location = new System.Drawing.Point(234, 58);
            this.txtCodigoTransporte.Name = "txtCodigoTransporte";
            this.txtCodigoTransporte.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoTransporte.TabIndex = 16;
            // 
            // txtDetalleVenta
            // 
            this.txtDetalleVenta.Location = new System.Drawing.Point(234, 18);
            this.txtDetalleVenta.Name = "txtDetalleVenta";
            this.txtDetalleVenta.Size = new System.Drawing.Size(100, 20);
            this.txtDetalleVenta.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Distancia de destino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Codigo de Transporte";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(224, 136);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Registro";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // btnElimi
            // 
            this.btnElimi.Location = new System.Drawing.Point(324, 135);
            this.btnElimi.Name = "btnElimi";
            this.btnElimi.Size = new System.Drawing.Size(75, 23);
            this.btnElimi.TabIndex = 11;
            this.btnElimi.Text = "Eliminar";
            this.btnElimi.UseVisualStyleBackColor = true;
            this.btnElimi.Click += new System.EventHandler(this.BtnElimi_Click);
            // 
            // btnActua
            // 
            this.btnActua.Location = new System.Drawing.Point(118, 136);
            this.btnActua.Name = "btnActua";
            this.btnActua.Size = new System.Drawing.Size(75, 23);
            this.btnActua.TabIndex = 10;
            this.btnActua.Text = "Actualizar";
            this.btnActua.UseVisualStyleBackColor = true;
            this.btnActua.Click += new System.EventHandler(this.BtnActua_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(17, 136);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 9;
            this.btnAlta.Text = "Registrar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // DataViajes
            // 
            this.DataViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViajes.Location = new System.Drawing.Point(6, 175);
            this.DataViajes.Name = "DataViajes";
            this.DataViajes.Size = new System.Drawing.Size(755, 204);
            this.DataViajes.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo de detalle de venta";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DWVProductos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataVentas)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDetalleVentas)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.DataGridView DWVProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.ToolStripMenuItem materiaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button brnAlta;
        private System.Windows.Forms.DataGridView DataVentas;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DataDetalleVentas;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView DataViajes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboVehiculo;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtCodigoTransporte;
        private System.Windows.Forms.TextBox txtDetalleVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnElimi;
        private System.Windows.Forms.Button btnActua;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtCodigocliente;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtCodigoempleado;
        private System.Windows.Forms.TextBox txtCodigoVenta;
        private System.Windows.Forms.TextBox TxtFechaVenta;
        private System.Windows.Forms.TextBox txtCantidadDetalle;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAltaDetalle;
        private System.Windows.Forms.Button btnConsultarDEtalle;
        private System.Windows.Forms.Button bntEliminarDetalleVenta;
        private System.Windows.Forms.Button btnActualizarDetalle;
        private System.Windows.Forms.TextBox txtIdDetalleVenta;
        private System.Windows.Forms.Label label15;
    }
}