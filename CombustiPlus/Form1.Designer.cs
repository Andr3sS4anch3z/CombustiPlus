namespace CombustiPlus
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
            btnDespachar = new Button();
            btnCotizar = new Button();
            nudGalones = new NumericUpDown();
            cmbPago = new ComboBox();
            cmbCombustible = new ComboBox();
            txtPlaca = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lstDetalle = new ListBox();
            groupBox3 = new GroupBox();
            btnPorCombustible = new Button();
            lstDespachos = new ListBox();
            lblResumen = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDespachar);
            groupBox1.Controls.Add(btnCotizar);
            groupBox1.Controls.Add(nudGalones);
            groupBox1.Controls.Add(cmbPago);
            groupBox1.Controls.Add(cmbCombustible);
            groupBox1.Controls.Add(txtPlaca);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 212);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Despacho";
            // 
            // btnDespachar
            // 
            btnDespachar.Location = new Point(209, 177);
            btnDespachar.Name = "btnDespachar";
            btnDespachar.Size = new Size(188, 29);
            btnDespachar.TabIndex = 8;
            btnDespachar.Text = "Despachar";
            btnDespachar.UseVisualStyleBackColor = true;
            btnDespachar.Click += btnDespachar_Click;
            // 
            // btnCotizar
            // 
            btnCotizar.Location = new Point(8, 177);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(195, 29);
            btnCotizar.TabIndex = 1;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += btnCotizar_Click;
            // 
            // nudGalones
            // 
            nudGalones.Location = new Point(116, 102);
            nudGalones.Name = "nudGalones";
            nudGalones.Size = new Size(150, 27);
            nudGalones.TabIndex = 7;
            // 
            // cmbPago
            // 
            cmbPago.FormattingEnabled = true;
            cmbPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cmbPago.Location = new Point(116, 135);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(262, 28);
            cmbPago.TabIndex = 6;
            // 
            // cmbCombustible
            // 
            cmbCombustible.FormattingEnabled = true;
            cmbCombustible.Items.AddRange(new object[] { "Regular", "Premiun", "Gasoil" });
            cmbCombustible.Location = new Point(116, 71);
            cmbCombustible.Name = "cmbCombustible";
            cmbCombustible.Size = new Size(262, 28);
            cmbCombustible.TabIndex = 5;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(116, 38);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(262, 27);
            txtPlaca.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 135);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 104);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Galones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Combustible:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Placa:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstDetalle);
            groupBox2.Location = new Point(26, 235);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(403, 212);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle";
            // 
            // lstDetalle
            // 
            lstDetalle.FormattingEnabled = true;
            lstDetalle.Location = new Point(6, 26);
            lstDetalle.Name = "lstDetalle";
            lstDetalle.Size = new Size(391, 184);
            lstDetalle.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnPorCombustible);
            groupBox3.Controls.Add(lstDespachos);
            groupBox3.Location = new Point(456, 17);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(538, 302);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Despachos del dia";
            // 
            // btnPorCombustible
            // 
            btnPorCombustible.Location = new Point(6, 267);
            btnPorCombustible.Name = "btnPorCombustible";
            btnPorCombustible.Size = new Size(194, 29);
            btnPorCombustible.TabIndex = 1;
            btnPorCombustible.Text = "Galones por combustible";
            btnPorCombustible.UseVisualStyleBackColor = true;
            btnPorCombustible.Click += btnPorCombustible_Click;
            // 
            // lstDespachos
            // 
            lstDespachos.FormattingEnabled = true;
            lstDespachos.Location = new Point(6, 19);
            lstDespachos.Name = "lstDespachos";
            lstDespachos.Size = new Size(526, 244);
            lstDespachos.TabIndex = 0;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(456, 322);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(0, 20);
            lblResumen.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 450);
            Controls.Add(lblResumen);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblResumen;
        private TextBox txtPlaca;
        private NumericUpDown nudGalones;
        private ComboBox cmbPago;
        private ComboBox cmbCombustible;
        private Button btnDespachar;
        private Button btnCotizar;
        private ListBox lstDetalle;
        private Button btnPorCombustible;
        private ListBox lstDespachos;
    }
}
