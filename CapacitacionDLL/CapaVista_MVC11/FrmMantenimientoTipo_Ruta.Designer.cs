namespace CapaVista_MVC11
{
    partial class FrmMantenimientoTipo_Ruta
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
            this.DgvListaTipo_Ruta = new System.Windows.Forms.DataGridView();
            this.PnlDatos = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtDescripcionTipo_Ruta = new System.Windows.Forms.TextBox();
            this.TxtNombreTipo_Ruta = new System.Windows.Forms.TextBox();
            this.BtnHabilitar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboI1 = new Capa_Vista_Comboi.ComboI();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnAyudar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaTipo_Ruta)).BeginInit();
            this.PnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListaTipo_Ruta
            // 
            this.DgvListaTipo_Ruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaTipo_Ruta.Location = new System.Drawing.Point(49, 328);
            this.DgvListaTipo_Ruta.Name = "DgvListaTipo_Ruta";
            this.DgvListaTipo_Ruta.RowHeadersWidth = 51;
            this.DgvListaTipo_Ruta.RowTemplate.Height = 24;
            this.DgvListaTipo_Ruta.Size = new System.Drawing.Size(713, 150);
            this.DgvListaTipo_Ruta.TabIndex = 0;
            this.DgvListaTipo_Ruta.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvListaTipo_Ruta_CellMouseClick);
            // 
            // PnlDatos
            // 
            this.PnlDatos.BackColor = System.Drawing.Color.DarkCyan;
            this.PnlDatos.Controls.Add(this.BtnEliminar);
            this.PnlDatos.Controls.Add(this.BtnModificar);
            this.PnlDatos.Controls.Add(this.BtnGuardar);
            this.PnlDatos.Controls.Add(this.TxtDescripcionTipo_Ruta);
            this.PnlDatos.Controls.Add(this.TxtNombreTipo_Ruta);
            this.PnlDatos.Location = new System.Drawing.Point(520, 39);
            this.PnlDatos.Name = "PnlDatos";
            this.PnlDatos.Size = new System.Drawing.Size(242, 255);
            this.PnlDatos.TabIndex = 1;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(53, 207);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(138, 23);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(53, 166);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(138, 23);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(53, 128);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(138, 23);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Agregar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtDescripcionTipo_Ruta
            // 
            this.TxtDescripcionTipo_Ruta.Location = new System.Drawing.Point(25, 87);
            this.TxtDescripcionTipo_Ruta.Name = "TxtDescripcionTipo_Ruta";
            this.TxtDescripcionTipo_Ruta.Size = new System.Drawing.Size(194, 22);
            this.TxtDescripcionTipo_Ruta.TabIndex = 1;
            // 
            // TxtNombreTipo_Ruta
            // 
            this.TxtNombreTipo_Ruta.Location = new System.Drawing.Point(25, 26);
            this.TxtNombreTipo_Ruta.Name = "TxtNombreTipo_Ruta";
            this.TxtNombreTipo_Ruta.Size = new System.Drawing.Size(194, 22);
            this.TxtNombreTipo_Ruta.TabIndex = 0;
            // 
            // BtnHabilitar
            // 
            this.BtnHabilitar.Location = new System.Drawing.Point(68, 256);
            this.BtnHabilitar.Name = "BtnHabilitar";
            this.BtnHabilitar.Size = new System.Drawing.Size(119, 23);
            this.BtnHabilitar.TabIndex = 2;
            this.BtnHabilitar.Text = "Habilitar";
            this.BtnHabilitar.UseVisualStyleBackColor = true;
            this.BtnHabilitar.Click += new System.EventHandler(this.BtnHabilitar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(448, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // comboI1
            // 
            this.comboI1.Location = new System.Drawing.Point(68, 80);
            this.comboI1.Name = "comboI1";
            this.comboI1.Size = new System.Drawing.Size(448, 24);
            this.comboI1.TabIndex = 4;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(219, 256);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(75, 23);
            this.BtnImprimir.TabIndex = 5;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnAyudar
            // 
            this.BtnAyudar.Location = new System.Drawing.Point(342, 256);
            this.BtnAyudar.Name = "BtnAyudar";
            this.BtnAyudar.Size = new System.Drawing.Size(98, 23);
            this.BtnAyudar.TabIndex = 6;
            this.BtnAyudar.Text = "Ayudas";
            this.BtnAyudar.UseVisualStyleBackColor = true;
            this.BtnAyudar.Click += new System.EventHandler(this.BtnAyudar_Click);
            // 
            // FrmMantenimientoTipo_Ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 535);
            this.Controls.Add(this.BtnAyudar);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.comboI1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnHabilitar);
            this.Controls.Add(this.PnlDatos);
            this.Controls.Add(this.DgvListaTipo_Ruta);
            this.Name = "FrmMantenimientoTipo_Ruta";
            this.Text = "FrmMantenimientoTipo_Ruta";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaTipo_Ruta)).EndInit();
            this.PnlDatos.ResumeLayout(false);
            this.PnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaTipo_Ruta;
        private System.Windows.Forms.Panel PnlDatos;
        private System.Windows.Forms.TextBox TxtDescripcionTipo_Ruta;
        private System.Windows.Forms.TextBox TxtNombreTipo_Ruta;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnHabilitar;
        private System.Windows.Forms.ComboBox comboBox1;
        private Capa_Vista_Comboi.ComboI comboI1;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnAyudar;
    }
}