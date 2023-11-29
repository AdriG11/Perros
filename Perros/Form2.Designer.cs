namespace Perros
{
    partial class Form2
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
            dgvEst = new DataGridView();
            label1 = new Label();
            btnMostrar = new Button();
            txtMaximo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEst).BeginInit();
            SuspendLayout();
            // 
            // dgvEst
            // 
            dgvEst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEst.Location = new Point(95, 157);
            dgvEst.Name = "dgvEst";
            dgvEst.RowHeadersWidth = 51;
            dgvEst.RowTemplate.Height = 29;
            dgvEst.Size = new Size(605, 188);
            dgvEst.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 35);
            label1.Name = "label1";
            label1.Size = new Size(144, 26);
            label1.TabIndex = 1;
            label1.Text = "ESTADISTICAS";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(26, 372);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(94, 29);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtMaximo
            // 
            txtMaximo.Location = new Point(425, 71);
            txtMaximo.Multiline = true;
            txtMaximo.Name = "txtMaximo";
            txtMaximo.Size = new Size(244, 53);
            txtMaximo.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMaximo);
            Controls.Add(btnMostrar);
            Controls.Add(label1);
            Controls.Add(dgvEst);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvEst).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnMostrar;
        public TextBox txtMaximo;
        public DataGridView dgvEst;
    }
}