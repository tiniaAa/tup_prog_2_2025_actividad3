namespace Ejercicio1
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnListarIncidentes = new Button();
            btnCrearComisaria = new Button();
            gbx2 = new GroupBox();
            cmbPlaca = new ComboBox();
            groupBox4 = new GroupBox();
            cbxIncidente = new ComboBox();
            btnRegistrarIncidente = new Button();
            tbMotivo = new TextBox();
            tbDNI = new TextBox();
            tbPersona = new TextBox();
            numHoraM = new NumericUpDown();
            numHoraH = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            btnAsignarGuardias = new Button();
            numDesdeMinutos = new NumericUpDown();
            numDesdeHora = new NumericUpDown();
            numDuracion = new NumericUpDown();
            numNROguardia = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            gbx2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHoraM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHoraH).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDesdeMinutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDesdeHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNROguardia).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnListarIncidentes);
            groupBox1.Controls.Add(btnCrearComisaria);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(629, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administracion Comisaria ";
            // 
            // btnListarIncidentes
            // 
            btnListarIncidentes.Location = new Point(322, 46);
            btnListarIncidentes.Name = "btnListarIncidentes";
            btnListarIncidentes.Size = new Size(137, 48);
            btnListarIncidentes.TabIndex = 1;
            btnListarIncidentes.Text = "Listar incidentes (4)";
            btnListarIncidentes.UseVisualStyleBackColor = true;
            btnListarIncidentes.Click += btnListarIncidentes_Click;
            // 
            // btnCrearComisaria
            // 
            btnCrearComisaria.Location = new Point(111, 46);
            btnCrearComisaria.Name = "btnCrearComisaria";
            btnCrearComisaria.Size = new Size(137, 48);
            btnCrearComisaria.TabIndex = 0;
            btnCrearComisaria.Text = "Crear comisaria (1)";
            btnCrearComisaria.UseVisualStyleBackColor = true;
            btnCrearComisaria.Click += btnCrearComisaria_Click;
            // 
            // gbx2
            // 
            gbx2.Controls.Add(cmbPlaca);
            gbx2.Controls.Add(groupBox4);
            gbx2.Controls.Add(groupBox3);
            gbx2.Controls.Add(label1);
            gbx2.Location = new Point(10, 143);
            gbx2.Name = "gbx2";
            gbx2.Size = new Size(631, 510);
            gbx2.TabIndex = 1;
            gbx2.TabStop = false;
            gbx2.Text = "Operaciones sobre  el agente ";
            // 
            // cmbPlaca
            // 
            cmbPlaca.FormattingEnabled = true;
            cmbPlaca.Location = new Point(135, 49);
            cmbPlaca.Name = "cmbPlaca";
            cmbPlaca.Size = new Size(151, 28);
            cmbPlaca.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbxIncidente);
            groupBox4.Controls.Add(btnRegistrarIncidente);
            groupBox4.Controls.Add(tbMotivo);
            groupBox4.Controls.Add(tbDNI);
            groupBox4.Controls.Add(tbPersona);
            groupBox4.Controls.Add(numHoraM);
            groupBox4.Controls.Add(numHoraH);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(6, 262);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(619, 242);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "dministracóin Incidentes";
            // 
            // cbxIncidente
            // 
            cbxIncidente.FormattingEnabled = true;
            cbxIncidente.Items.AddRange(new object[] { "Denuncia ", "Arresto " });
            cbxIncidente.Location = new Point(137, 42);
            cbxIncidente.Name = "cbxIncidente";
            cbxIncidente.Size = new Size(151, 28);
            cbxIncidente.TabIndex = 11;
            // 
            // btnRegistrarIncidente
            // 
            btnRegistrarIncidente.Location = new Point(358, 164);
            btnRegistrarIncidente.Name = "btnRegistrarIncidente";
            btnRegistrarIncidente.Size = new Size(181, 45);
            btnRegistrarIncidente.TabIndex = 10;
            btnRegistrarIncidente.Text = "Registrar incidente (3)";
            btnRegistrarIncidente.UseVisualStyleBackColor = true;
            btnRegistrarIncidente.Click += btnRegistrarIncidente_Click;
            // 
            // tbMotivo
            // 
            tbMotivo.Location = new Point(137, 146);
            tbMotivo.Multiline = true;
            tbMotivo.Name = "tbMotivo";
            tbMotivo.Size = new Size(179, 75);
            tbMotivo.TabIndex = 9;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(339, 109);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(125, 27);
            tbDNI.TabIndex = 8;
            // 
            // tbPersona
            // 
            tbPersona.Location = new Point(137, 109);
            tbPersona.Name = "tbPersona";
            tbPersona.Size = new Size(125, 27);
            tbPersona.TabIndex = 7;
            // 
            // numHoraM
            // 
            numHoraM.Location = new Point(293, 76);
            numHoraM.Name = "numHoraM";
            numHoraM.Size = new Size(150, 27);
            numHoraM.TabIndex = 6;
            // 
            // numHoraH
            // 
            numHoraH.Location = new Point(137, 76);
            numHoraH.Name = "numHoraH";
            numHoraH.Size = new Size(150, 27);
            numHoraH.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 115);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 4;
            label9.Text = "Persona";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 153);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 3;
            label8.Text = "Motivo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(280, 116);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 2;
            label7.Text = "DNI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 45);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 1;
            label6.Text = "Tipo incidente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 83);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 0;
            label5.Text = "Hora";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnAsignarGuardias);
            groupBox3.Controls.Add(numDesdeMinutos);
            groupBox3.Controls.Add(numDesdeHora);
            groupBox3.Controls.Add(numDuracion);
            groupBox3.Controls.Add(numNROguardia);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(6, 110);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(619, 146);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Administracion de guardias ";
            // 
            // btnAsignarGuardias
            // 
            btnAsignarGuardias.Location = new Point(400, 53);
            btnAsignarGuardias.Name = "btnAsignarGuardias";
            btnAsignarGuardias.Size = new Size(139, 61);
            btnAsignarGuardias.TabIndex = 7;
            btnAsignarGuardias.Text = "Asignacion de las guardias (2)";
            btnAsignarGuardias.UseVisualStyleBackColor = true;
            btnAsignarGuardias.Click += btnAsignarGuardias_Click;
            // 
            // numDesdeMinutos
            // 
            numDesdeMinutos.Location = new Point(244, 73);
            numDesdeMinutos.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numDesdeMinutos.Name = "numDesdeMinutos";
            numDesdeMinutos.Size = new Size(65, 27);
            numDesdeMinutos.TabIndex = 6;
            // 
            // numDesdeHora
            // 
            numDesdeHora.Location = new Point(159, 73);
            numDesdeHora.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numDesdeHora.Name = "numDesdeHora";
            numDesdeHora.Size = new Size(61, 27);
            numDesdeHora.TabIndex = 5;
            // 
            // numDuracion
            // 
            numDuracion.Location = new Point(159, 106);
            numDuracion.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numDuracion.Name = "numDuracion";
            numDuracion.Size = new Size(150, 27);
            numDuracion.TabIndex = 4;
            // 
            // numNROguardia
            // 
            numNROguardia.Location = new Point(159, 39);
            numNROguardia.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numNROguardia.Name = "numNROguardia";
            numNROguardia.Size = new Size(150, 27);
            numNROguardia.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 104);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 2;
            label4.Text = "Duracion en M";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 73);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 1;
            label3.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 41);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 0;
            label2.Text = "Nro guardia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 52);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Placa de agente  ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 658);
            Controls.Add(gbx2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            gbx2.ResumeLayout(false);
            gbx2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHoraM).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHoraH).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDesdeMinutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDesdeHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNROguardia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnListarIncidentes;
        private Button btnCrearComisaria;
        private GroupBox gbx2;
        private GroupBox groupBox3;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAsignarGuardias;
        private NumericUpDown numDesdeMinutos;
        private NumericUpDown numDesdeHora;
        private NumericUpDown numDuracion;
        private NumericUpDown numNROguardia;
        private GroupBox groupBox4;
        private Button btnRegistrarIncidente;
        private TextBox tbMotivo;
        private TextBox tbDNI;
        private TextBox tbPersona;
        private NumericUpDown numHoraM;
        private NumericUpDown numHoraH;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cbxIncidente;
        private ComboBox cmbPlaca;
    }
}
