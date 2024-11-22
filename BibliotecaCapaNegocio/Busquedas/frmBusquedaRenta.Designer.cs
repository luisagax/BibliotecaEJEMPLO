
namespace BibliotecaCapaNegocio.Busquedas
{
    partial class frmBusquedaRenta
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
            this.dgRenta = new System.Windows.Forms.DataGridView();
            this.dgRentaDetalle = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dsvRenta = new BibliotecaCapaNegocio.dsvRenta();
            this.vRentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vRentaTableAdapter = new BibliotecaCapaNegocio.dsvRentaTableAdapters.vRentaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRentaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsvRentaDetalle = new BibliotecaCapaNegocio.dsvRentaDetalle();
            this.vRentaDetalleTableAdapter = new BibliotecaCapaNegocio.dsvRentaDetalleTableAdapters.vRentaDetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRentaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRentaDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvRentaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRenta
            // 
            this.dgRenta.AllowUserToAddRows = false;
            this.dgRenta.AllowUserToDeleteRows = false;
            this.dgRenta.AutoGenerateColumns = false;
            this.dgRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fechaRentaDataGridViewTextBoxColumn,
            this.fechaRegresoDataGridViewTextBoxColumn,
            this.multaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn});
            this.dgRenta.DataSource = this.vRentaBindingSource;
            this.dgRenta.Location = new System.Drawing.Point(31, 57);
            this.dgRenta.Name = "dgRenta";
            this.dgRenta.ReadOnly = true;
            this.dgRenta.Size = new System.Drawing.Size(767, 178);
            this.dgRenta.TabIndex = 0;
            this.dgRenta.SelectionChanged += new System.EventHandler(this.dgRenta_SelectionChanged);
            // 
            // dgRentaDetalle
            // 
            this.dgRentaDetalle.AllowUserToAddRows = false;
            this.dgRentaDetalle.AllowUserToDeleteRows = false;
            this.dgRentaDetalle.AutoGenerateColumns = false;
            this.dgRentaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRentaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.idRentaDataGridViewTextBoxColumn,
            this.idLibroDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn});
            this.dgRentaDetalle.DataSource = this.vRentaDetalleBindingSource;
            this.dgRentaDetalle.Location = new System.Drawing.Point(31, 241);
            this.dgRentaDetalle.Name = "dgRentaDetalle";
            this.dgRentaDetalle.ReadOnly = true;
            this.dgRentaDetalle.Size = new System.Drawing.Size(767, 187);
            this.dgRentaDetalle.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(594, 434);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 33);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(699, 434);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 33);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dsvRenta
            // 
            this.dsvRenta.DataSetName = "dsvRenta";
            this.dsvRenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vRentaBindingSource
            // 
            this.vRentaBindingSource.DataMember = "vRenta";
            this.vRentaBindingSource.DataSource = this.dsvRenta;
            // 
            // vRentaTableAdapter
            // 
            this.vRentaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaRentaDataGridViewTextBoxColumn
            // 
            this.fechaRentaDataGridViewTextBoxColumn.DataPropertyName = "FechaRenta";
            this.fechaRentaDataGridViewTextBoxColumn.HeaderText = "FechaRenta";
            this.fechaRentaDataGridViewTextBoxColumn.Name = "fechaRentaDataGridViewTextBoxColumn";
            this.fechaRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaRegresoDataGridViewTextBoxColumn
            // 
            this.fechaRegresoDataGridViewTextBoxColumn.DataPropertyName = "FechaRegreso";
            this.fechaRegresoDataGridViewTextBoxColumn.HeaderText = "FechaRegreso";
            this.fechaRegresoDataGridViewTextBoxColumn.Name = "fechaRegresoDataGridViewTextBoxColumn";
            this.fechaRegresoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // multaDataGridViewTextBoxColumn
            // 
            this.multaDataGridViewTextBoxColumn.DataPropertyName = "Multa";
            this.multaDataGridViewTextBoxColumn.HeaderText = "Multa";
            this.multaDataGridViewTextBoxColumn.Name = "multaDataGridViewTextBoxColumn";
            this.multaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            this.nombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idRentaDataGridViewTextBoxColumn
            // 
            this.idRentaDataGridViewTextBoxColumn.DataPropertyName = "idRenta";
            this.idRentaDataGridViewTextBoxColumn.HeaderText = "idRenta";
            this.idRentaDataGridViewTextBoxColumn.Name = "idRentaDataGridViewTextBoxColumn";
            this.idRentaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // vRentaDetalleBindingSource
            // 
            this.vRentaDetalleBindingSource.DataMember = "vRentaDetalle";
            this.vRentaDetalleBindingSource.DataSource = this.dsvRentaDetalle;
            // 
            // dsvRentaDetalle
            // 
            this.dsvRentaDetalle.DataSetName = "dsvRentaDetalle";
            this.dsvRentaDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vRentaDetalleTableAdapter
            // 
            this.vRentaDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // frmBusquedaRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 482);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgRentaDetalle);
            this.Controls.Add(this.dgRenta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBusquedaRenta";
            this.Text = "frmBusquedaRenta";
            this.Load += new System.EventHandler(this.frmBusquedaRenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRentaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRentaDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvRentaDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgRenta;
        public System.Windows.Forms.DataGridView dgRentaDetalle;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public dsvRenta dsvRenta;
        public System.Windows.Forms.BindingSource vRentaBindingSource;
        public dsvRentaTableAdapters.vRentaTableAdapter vRentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn multaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        public dsvRentaDetalle dsvRentaDetalle;
        public System.Windows.Forms.BindingSource vRentaDetalleBindingSource;
        public dsvRentaDetalleTableAdapters.vRentaDetalleTableAdapter vRentaDetalleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
    }
}