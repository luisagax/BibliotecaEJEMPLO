
namespace BibliotecaCapaCliente.Formularios
{
    partial class frmRenta
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpFechaRenta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaRegreso = new System.Windows.Forms.DateTimePicker();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbLibro = new System.Windows.Forms.ComboBox();
            this.dtDetalle = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spRentaDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVentaDet = new BibliotecaCapaCliente.dsVentaDet();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.spRentaDetTableAdapter = new BibliotecaCapaCliente.dsVentaDetTableAdapters.spRentaDetTableAdapter();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRentaDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentaDet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Renta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Regreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Multa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Libro";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(146, 71);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(427, 28);
            this.cbCliente.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(146, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(76, 26);
            this.txtID.TabIndex = 0;
            // 
            // dtpFechaRenta
            // 
            this.dtpFechaRenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRenta.Location = new System.Drawing.Point(148, 105);
            this.dtpFechaRenta.Name = "dtpFechaRenta";
            this.dtpFechaRenta.Size = new System.Drawing.Size(138, 26);
            this.dtpFechaRenta.TabIndex = 3;
            // 
            // dtpFechaRegreso
            // 
            this.dtpFechaRegreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegreso.Location = new System.Drawing.Point(435, 105);
            this.dtpFechaRegreso.Name = "dtpFechaRegreso";
            this.dtpFechaRegreso.Size = new System.Drawing.Size(138, 26);
            this.dtpFechaRegreso.TabIndex = 4;
            // 
            // txtMulta
            // 
            this.txtMulta.Location = new System.Drawing.Point(148, 137);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(124, 26);
            this.txtMulta.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(430, 357);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 26);
            this.txtCantidad.TabIndex = 6;
            // 
            // cbLibro
            // 
            this.cbLibro.FormattingEnabled = true;
            this.cbLibro.Location = new System.Drawing.Point(148, 169);
            this.cbLibro.Name = "cbLibro";
            this.cbLibro.Size = new System.Drawing.Size(425, 28);
            this.cbLibro.TabIndex = 7;
            // 
            // dtDetalle
            // 
            this.dtDetalle.AllowUserToAddRows = false;
            this.dtDetalle.AutoGenerateColumns = false;
            this.dtDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idRentaDataGridViewTextBoxColumn,
            this.idLibroDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn});
            this.dtDetalle.DataSource = this.spRentaDetBindingSource;
            this.dtDetalle.Location = new System.Drawing.Point(146, 212);
            this.dtDetalle.Name = "dtDetalle";
            this.dtDetalle.ReadOnly = true;
            this.dtDetalle.Size = new System.Drawing.Size(483, 136);
            this.dtDetalle.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idRentaDataGridViewTextBoxColumn
            // 
            this.idRentaDataGridViewTextBoxColumn.DataPropertyName = "idRenta";
            this.idRentaDataGridViewTextBoxColumn.HeaderText = "idRenta";
            this.idRentaDataGridViewTextBoxColumn.Name = "idRentaDataGridViewTextBoxColumn";
            this.idRentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idLibroDataGridViewTextBoxColumn
            // 
            this.idLibroDataGridViewTextBoxColumn.DataPropertyName = "idLibro";
            this.idLibroDataGridViewTextBoxColumn.HeaderText = "idLibro";
            this.idLibroDataGridViewTextBoxColumn.Name = "idLibroDataGridViewTextBoxColumn";
            this.idLibroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 300;
            // 
            // spRentaDetBindingSource
            // 
            this.spRentaDetBindingSource.DataMember = "spRentaDet";
            this.spRentaDetBindingSource.DataSource = this.dsVentaDet;
            // 
            // dsVentaDet
            // 
            this.dsVentaDet.DataSetName = "dsVentaDet";
            this.dsVentaDet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::BibliotecaCapaCliente.Properties.Resources.mas;
            this.btnAgregar.Location = new System.Drawing.Point(635, 161);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 43);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Image = global::BibliotecaCapaCliente.Properties.Resources.buscar1;
            this.btnBuscarLibro.Location = new System.Drawing.Point(579, 161);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(50, 43);
            this.btnBuscarLibro.TabIndex = 8;
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::BibliotecaCapaCliente.Properties.Resources.buscar1;
            this.btnBuscar.Location = new System.Drawing.Point(228, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 41);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // spRentaDetTableAdapter
            // 
            this.spRentaDetTableAdapter.ClearBeforeFill = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(536, 354);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(149, 32);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 396);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtDetalle);
            this.Controls.Add(this.btnBuscarLibro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbLibro);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.dtpFechaRegreso);
            this.Controls.Add(this.dtpFechaRenta);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRenta";
            this.Text = "frmRenta";
            this.Load += new System.EventHandler(this.frmRenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRentaDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentaDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtpFechaRenta;
        private System.Windows.Forms.DateTimePicker dtpFechaRegreso;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbLibro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.DataGridView dtDetalle;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.BindingSource spRentaDetBindingSource;
        private dsVentaDet dsVentaDet;
        private dsVentaDetTableAdapters.spRentaDetTableAdapter spRentaDetTableAdapter;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
    }
}