using EnvDTE;
using Views.Utilities;

namespace Views
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnCrear = new Button();
            btnPrueba = new Button();
            pictureBox1 = new PictureBox();
            btnResultados = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnServices = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(59, 68, 83);
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Location = new Point(70, 265);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(137, 50);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "CREAR MAQUINA";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += clickBtnCrearMaquina;
            // 
            // btnPrueba
            // 
            btnPrueba.BackColor = Color.FromArgb(59, 68, 83);
            btnPrueba.Cursor = Cursors.Hand;
            btnPrueba.FlatStyle = FlatStyle.Flat;
            btnPrueba.Location = new Point(248, 265);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(137, 50);
            btnPrueba.TabIndex = 1;
            btnPrueba.Text = "INICIAR PRUEBA";
            btnPrueba.UseVisualStyleBackColor = false;
            btnPrueba.Click += clickBtnIniciarPrueba;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 127);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnResultados
            // 
            btnResultados.BackColor = Color.FromArgb(59, 68, 83);
            btnResultados.Cursor = Cursors.Hand;
            btnResultados.FlatStyle = FlatStyle.Flat;
            btnResultados.Location = new Point(414, 265);
            btnResultados.Name = "btnResultados";
            btnResultados.Size = new Size(137, 50);
            btnResultados.TabIndex = 2;
            btnResultados.Text = "CONSULTAR";
            btnResultados.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(248, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 127);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(414, 122);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(137, 127);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(586, 122);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(137, 127);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // btnServices
            // 
            btnServices.BackColor = Color.FromArgb(59, 68, 83);
            btnServices.Cursor = Cursors.Hand;
            btnServices.FlatStyle = FlatStyle.Flat;
            btnServices.Location = new Point(586, 265);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(137, 50);
            btnServices.TabIndex = 6;
            btnServices.Text = "SERVICIOS";
            btnServices.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 41, 51);
            ClientSize = new Size(800, 450);
            Controls.Add(btnServices);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnResultados);
            Controls.Add(pictureBox1);
            Controls.Add(btnPrueba);
            Controls.Add(btnCrear);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrear;
        private Button btnPrueba;
        private PictureBox pictureBox1;
        private Button btnResultados;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnServices;
    }
}