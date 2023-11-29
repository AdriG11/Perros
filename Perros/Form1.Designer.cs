namespace Perros
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombrePerro = new TextBox();
            txtRaza = new TextBox();
            txtEdadPerro = new TextBox();
            btnMostrar = new Button();
            btnGuardar = new Button();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtCostoPerro = new TextBox();
            txtNombreGato = new TextBox();
            txtCostoGato = new TextBox();
            txtEdadGato = new TextBox();
            txtColorGato = new TextBox();
            btnGuardarGato = new Button();
            dgV_01 = new DataGridView();
            dgV_02 = new DataGridView();
            btnMostrarGato = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            tabPage2 = new TabPage();
            btnMotrar2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgV_01).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgV_02).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 75);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 120);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Raza";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 170);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            // 
            // txtNombrePerro
            // 
            txtNombrePerro.Location = new Point(189, 75);
            txtNombrePerro.Name = "txtNombrePerro";
            txtNombrePerro.Size = new Size(125, 27);
            txtNombrePerro.TabIndex = 3;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(189, 120);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(125, 27);
            txtRaza.TabIndex = 4;
            // 
            // txtEdadPerro
            // 
            txtEdadPerro.Location = new Point(189, 163);
            txtEdadPerro.Name = "txtEdadPerro";
            txtEdadPerro.Size = new Size(125, 27);
            txtEdadPerro.TabIndex = 5;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(397, 120);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(106, 46);
            btnMostrar.TabIndex = 6;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(383, 36);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(176, 59);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar Perros Perro";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(45, 43);
            label4.Name = "label4";
            label4.Size = new Size(100, 31);
            label4.TabIndex = 8;
            label4.Text = "PERROS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 108);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 10;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 163);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 11;
            label7.Text = "Color de Pelo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(94, 211);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 12;
            label8.Text = "Edad";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(94, 265);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 13;
            label9.Text = "Costo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(101, 214);
            label10.Name = "label10";
            label10.Size = new Size(47, 20);
            label10.TabIndex = 14;
            label10.Text = "Costo";
            // 
            // txtCostoPerro
            // 
            txtCostoPerro.Location = new Point(189, 214);
            txtCostoPerro.Name = "txtCostoPerro";
            txtCostoPerro.Size = new Size(125, 27);
            txtCostoPerro.TabIndex = 15;
            // 
            // txtNombreGato
            // 
            txtNombreGato.Location = new Point(192, 108);
            txtNombreGato.Name = "txtNombreGato";
            txtNombreGato.Size = new Size(125, 27);
            txtNombreGato.TabIndex = 16;
            // 
            // txtCostoGato
            // 
            txtCostoGato.Location = new Point(192, 258);
            txtCostoGato.Name = "txtCostoGato";
            txtCostoGato.Size = new Size(125, 27);
            txtCostoGato.TabIndex = 17;
            // 
            // txtEdadGato
            // 
            txtEdadGato.Location = new Point(192, 211);
            txtEdadGato.Name = "txtEdadGato";
            txtEdadGato.Size = new Size(125, 27);
            txtEdadGato.TabIndex = 18;
            // 
            // txtColorGato
            // 
            txtColorGato.Location = new Point(192, 163);
            txtColorGato.Name = "txtColorGato";
            txtColorGato.Size = new Size(125, 27);
            txtColorGato.TabIndex = 19;
            // 
            // btnGuardarGato
            // 
            btnGuardarGato.Location = new Point(337, 108);
            btnGuardarGato.Name = "btnGuardarGato";
            btnGuardarGato.Size = new Size(151, 57);
            btnGuardarGato.TabIndex = 20;
            btnGuardarGato.Text = "Guardar Perros Gato";
            btnGuardarGato.UseVisualStyleBackColor = true;
            btnGuardarGato.Click += btnGuardarGato_Click;
            // 
            // dgV_01
            // 
            dgV_01.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgV_01.Location = new Point(320, 233);
            dgV_01.Name = "dgV_01";
            dgV_01.RowHeadersWidth = 51;
            dgV_01.RowTemplate.Height = 29;
            dgV_01.Size = new Size(497, 157);
            dgV_01.TabIndex = 21;
            // 
            // dgV_02
            // 
            dgV_02.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgV_02.Location = new Point(348, 259);
            dgV_02.Name = "dgV_02";
            dgV_02.RowHeadersWidth = 51;
            dgV_02.RowTemplate.Height = 29;
            dgV_02.Size = new Size(490, 148);
            dgV_02.TabIndex = 22;
            // 
            // btnMostrarGato
            // 
            btnMostrarGato.Location = new Point(352, 192);
            btnMostrarGato.Name = "btnMostrarGato";
            btnMostrarGato.Size = new Size(93, 46);
            btnMostrarGato.TabIndex = 23;
            btnMostrarGato.Text = "Mostrar";
            btnMostrarGato.UseVisualStyleBackColor = true;
            btnMostrarGato.Click += btnMostrarGato_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(875, 457);
            tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnGuardarGato);
            tabPage1.Controls.Add(dgV_02);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(btnMostrarGato);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txtColorGato);
            tabPage1.Controls.Add(txtNombreGato);
            tabPage1.Controls.Add(txtEdadGato);
            tabPage1.Controls.Add(txtCostoGato);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(867, 424);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "GATOS";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(62, 40);
            label5.Name = "label5";
            label5.Size = new Size(86, 31);
            label5.TabIndex = 9;
            label5.Text = "GATOS";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnMotrar2);
            tabPage2.Controls.Add(txtNombrePerro);
            tabPage2.Controls.Add(dgV_01);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtCostoPerro);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtRaza);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtEdadPerro);
            tabPage2.Controls.Add(btnGuardar);
            tabPage2.Controls.Add(btnMostrar);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(867, 424);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "PERROS";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // btnMotrar2
            // 
            btnMotrar2.Location = new Point(650, 68);
            btnMotrar2.Name = "btnMotrar2";
            btnMotrar2.Size = new Size(127, 60);
            btnMotrar2.TabIndex = 22;
            btnMotrar2.Text = "mostrar2";
            btnMotrar2.UseVisualStyleBackColor = true;
            btnMotrar2.Click += btnMotrar2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 452);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgV_01).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgV_02).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombrePerro;
        private TextBox txtRaza;
        private TextBox txtEdadPerro;
        private Button btnMostrar;
        private Button btnGuardar;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtCostoPerro;
        private TextBox txtNombreGato;
        private TextBox txtCostoGato;
        private TextBox txtEdadGato;
        private TextBox txtColorGato;
        private Button btnGuardarGato;
        private DataGridView dgV_01;
        private DataGridView dgV_02;
        private Button btnMostrarGato;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label5;
        private TabPage tabPage2;
        private Button btnMotrar2;
    }
}