namespace parkingApp
{
    partial class frmEstacionamiento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblCosto = new Label();
            label5 = new Label();
            lblFecha = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            txtHoraFin = new MaskedTextBox();
            txtHoraInicio = new MaskedTextBox();
            txtPlaca = new TextBox();
            btnRegistrar = new Button();
            btnSalir = new Button();
            btnCancelar = new Button();
            lvRegistro = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 15);
            label1.TabIndex = 0;
            label1.Text = "CONTROL REGISTRO ESTACIONAMIENTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "PLACA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 37);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "COSTO POR DIA $";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.BorderStyle = BorderStyle.FixedSingle;
            lblCosto.Location = new Point(178, 52);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(12, 17);
            lblCosto.TabIndex = 3;
            lblCosto.Text = "l";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 19);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "FECHA";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BorderStyle = BorderStyle.FixedSingle;
            lblFecha.Location = new Point(104, 19);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(2, 17);
            lblFecha.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 44);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 6;
            label7.Text = "HORA DE INICIO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 69);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 7;
            label8.Text = "HORA DE SALIDA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblFecha);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtHoraFin);
            groupBox1.Controls.Add(txtHoraInicio);
            groupBox1.Location = new Point(381, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(214, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "FECHA Y HORA";
            // 
            // txtHoraFin
            // 
            txtHoraFin.Location = new Point(104, 69);
            txtHoraFin.Mask = "90:00";
            txtHoraFin.Name = "txtHoraFin";
            txtHoraFin.Size = new Size(100, 23);
            txtHoraFin.TabIndex = 10;
            txtHoraFin.ValidatingType = typeof(DateTime);
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.Location = new Point(104, 41);
            txtHoraInicio.Mask = "90:00";
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.Size = new Size(100, 23);
            txtHoraInicio.TabIndex = 9;
            txtHoraInicio.ValidatingType = typeof(DateTime);
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(62, 34);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(74, 23);
            txtPlaca.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(12, 114);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(82, 23);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 295);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(98, 295);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lvRegistro
            // 
            lvRegistro.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lvRegistro.GridLines = true;
            lvRegistro.Location = new Point(12, 152);
            lvRegistro.Name = "lvRegistro";
            lvRegistro.Size = new Size(583, 137);
            lvRegistro.TabIndex = 14;
            lvRegistro.UseCompatibleStateImageBehavior = false;
            lvRegistro.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "PLACA";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "FECHA";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "HORA DE INCIO";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "HORA SALIDA";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "HORAS TOTALES";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "COSTO/HORA";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "TOTAL";
            // 
            // frmEstacionamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 344);
            Controls.Add(lvRegistro);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPlaca);
            Controls.Add(lblCosto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmEstacionamiento";
            Text = "Control de registro estacionamiento";
            Load += frmEstacionamiento_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblCosto;
        private Label label5;
        private Label lblFecha;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private TextBox txtPlaca;
        private MaskedTextBox txtHoraInicio;
        private MaskedTextBox txtHoraFin;
        private Button btnRegistrar;
        private Button btnSalir;
        private Button btnCancelar;
        private ListView lvRegistro;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}
