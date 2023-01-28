namespace Proyecto
{
    partial class MateriaPrima
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnGrasas = new System.Windows.Forms.RadioButton();
            this.rbtnArinas = new System.Windows.Forms.RadioButton();
            this.rbtnFrutas = new System.Windows.Forms.RadioButton();
            this.RbtnVerduras = new System.Windows.Forms.RadioButton();
            this.rbtnCarnes = new System.Windows.Forms.RadioButton();
            this.rbtnLacteos = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.DWVMateria = new System.Windows.Forms.DataGridView();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DWVMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Materia Prima";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(239, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnGrasas);
            this.groupBox1.Controls.Add(this.rbtnArinas);
            this.groupBox1.Controls.Add(this.rbtnFrutas);
            this.groupBox1.Controls.Add(this.RbtnVerduras);
            this.groupBox1.Controls.Add(this.rbtnCarnes);
            this.groupBox1.Controls.Add(this.rbtnLacteos);
            this.groupBox1.Location = new System.Drawing.Point(221, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rbtnGrasas
            // 
            this.rbtnGrasas.AutoSize = true;
            this.rbtnGrasas.Location = new System.Drawing.Point(241, 62);
            this.rbtnGrasas.Name = "rbtnGrasas";
            this.rbtnGrasas.Size = new System.Drawing.Size(58, 17);
            this.rbtnGrasas.TabIndex = 5;
            this.rbtnGrasas.TabStop = true;
            this.rbtnGrasas.Text = "Grasas";
            this.rbtnGrasas.UseVisualStyleBackColor = true;
            // 
            // rbtnArinas
            // 
            this.rbtnArinas.AutoSize = true;
            this.rbtnArinas.Location = new System.Drawing.Point(241, 19);
            this.rbtnArinas.Name = "rbtnArinas";
            this.rbtnArinas.Size = new System.Drawing.Size(61, 17);
            this.rbtnArinas.TabIndex = 4;
            this.rbtnArinas.TabStop = true;
            this.rbtnArinas.Text = "Harinas";
            this.rbtnArinas.UseVisualStyleBackColor = true;
            // 
            // rbtnFrutas
            // 
            this.rbtnFrutas.AutoSize = true;
            this.rbtnFrutas.Location = new System.Drawing.Point(143, 62);
            this.rbtnFrutas.Name = "rbtnFrutas";
            this.rbtnFrutas.Size = new System.Drawing.Size(54, 17);
            this.rbtnFrutas.TabIndex = 3;
            this.rbtnFrutas.TabStop = true;
            this.rbtnFrutas.Text = "Frutas";
            this.rbtnFrutas.UseVisualStyleBackColor = true;
            // 
            // RbtnVerduras
            // 
            this.RbtnVerduras.AutoSize = true;
            this.RbtnVerduras.Location = new System.Drawing.Point(143, 19);
            this.RbtnVerduras.Name = "RbtnVerduras";
            this.RbtnVerduras.Size = new System.Drawing.Size(67, 17);
            this.RbtnVerduras.TabIndex = 2;
            this.RbtnVerduras.TabStop = true;
            this.RbtnVerduras.Text = "Verduras";
            this.RbtnVerduras.UseVisualStyleBackColor = true;
            // 
            // rbtnCarnes
            // 
            this.rbtnCarnes.AutoSize = true;
            this.rbtnCarnes.Location = new System.Drawing.Point(18, 62);
            this.rbtnCarnes.Name = "rbtnCarnes";
            this.rbtnCarnes.Size = new System.Drawing.Size(58, 17);
            this.rbtnCarnes.TabIndex = 1;
            this.rbtnCarnes.TabStop = true;
            this.rbtnCarnes.Text = "Carnes";
            this.rbtnCarnes.UseVisualStyleBackColor = true;
            // 
            // rbtnLacteos
            // 
            this.rbtnLacteos.AutoSize = true;
            this.rbtnLacteos.Location = new System.Drawing.Point(18, 20);
            this.rbtnLacteos.Name = "rbtnLacteos";
            this.rbtnLacteos.Size = new System.Drawing.Size(63, 17);
            this.rbtnLacteos.TabIndex = 0;
            this.rbtnLacteos.TabStop = true;
            this.rbtnLacteos.Text = "Lacteos";
            this.rbtnLacteos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(239, 249);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(112, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // DWVMateria
            // 
            this.DWVMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DWVMateria.Location = new System.Drawing.Point(32, 297);
            this.DWVMateria.Name = "DWVMateria";
            this.DWVMateria.Size = new System.Drawing.Size(618, 209);
            this.DWVMateria.TabIndex = 6;
            this.DWVMateria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DWVMateria_CellContentClick);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(737, 31);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 7;
            this.btnAlta.Text = "Ingresar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(737, 116);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(737, 290);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 9;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(737, 207);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(528, 252);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Id de Materia";
            // 
            // MateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 518);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.DWVMateria);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MateriaPrima";
            this.Text = "MateriaPrima";
            this.Load += new System.EventHandler(this.MateriaPrima_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DWVMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnGrasas;
        private System.Windows.Forms.RadioButton rbtnArinas;
        private System.Windows.Forms.RadioButton rbtnFrutas;
        private System.Windows.Forms.RadioButton RbtnVerduras;
        private System.Windows.Forms.RadioButton rbtnCarnes;
        private System.Windows.Forms.RadioButton rbtnLacteos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView DWVMateria;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
    }
}