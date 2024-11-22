
namespace BibliotecaCapaCliente.Informes
{
    partial class frmFiltroUsuarios
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbUsComun = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbSa = new System.Windows.Forms.RadioButton();
            this.vwUsuarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsUsuarios = new BibliotecaCapaCliente.dsUsuarios();
            this.dsUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Controls.Add(this.rbUsComun);
            this.groupBox1.Controls.Add(this.rbAdmin);
            this.groupBox1.Controls.Add(this.rbSa);
            this.groupBox1.Location = new System.Drawing.Point(175, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 129);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(401, 50);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(152, 33);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Generar Reporte";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(227, 68);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(71, 24);
            this.rbTodos.TabIndex = 3;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbUsComun
            // 
            this.rbUsComun.AutoSize = true;
            this.rbUsComun.Location = new System.Drawing.Point(227, 44);
            this.rbUsComun.Name = "rbUsComun";
            this.rbUsComun.Size = new System.Drawing.Size(134, 24);
            this.rbUsComun.TabIndex = 2;
            this.rbUsComun.TabStop = true;
            this.rbUsComun.Text = "Usuario común";
            this.rbUsComun.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(34, 68);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(125, 24);
            this.rbAdmin.TabIndex = 1;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Administrador";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbSa
            // 
            this.rbSa.AutoSize = true;
            this.rbSa.Location = new System.Drawing.Point(34, 44);
            this.rbSa.Name = "rbSa";
            this.rbSa.Size = new System.Drawing.Size(170, 24);
            this.rbSa.TabIndex = 0;
            this.rbSa.TabStop = true;
            this.rbSa.Text = "Super administrador";
            this.rbSa.UseVisualStyleBackColor = true;
            // 
            // vwUsuarios
            // 
            reportDataSource1.Name = "dsRUsuarios";
            reportDataSource1.Value = this.dsUsuariosBindingSource;
            this.vwUsuarios.LocalReport.DataSources.Add(reportDataSource1);
            this.vwUsuarios.LocalReport.ReportEmbeddedResource = "BibliotecaCapaCliente.Informes.rptUsuarios.rdlc";
            this.vwUsuarios.Location = new System.Drawing.Point(12, 160);
            this.vwUsuarios.Name = "vwUsuarios";
            this.vwUsuarios.ServerReport.BearerToken = null;
            this.vwUsuarios.Size = new System.Drawing.Size(941, 368);
            this.vwUsuarios.TabIndex = 7;
            // 
            // dsUsuarios
            // 
            this.dsUsuarios.DataSetName = "dsUsuarios";
            this.dsUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsUsuariosBindingSource
            // 
            this.dsUsuariosBindingSource.DataSource = this.dsUsuarios;
            this.dsUsuariosBindingSource.Position = 0;
            // 
            // frmFiltroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 540);
            this.Controls.Add(this.vwUsuarios);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFiltroUsuarios";
            this.Text = "frmFiltroUsuarios";
            this.Load += new System.EventHandler(this.frmFiltroUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbUsComun;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbSa;
        private Microsoft.Reporting.WinForms.ReportViewer vwUsuarios;
        private System.Windows.Forms.BindingSource dsUsuariosBindingSource;
        private dsUsuarios dsUsuarios;
    }
}