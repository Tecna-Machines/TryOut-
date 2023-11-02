using EnvDTE;

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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(59, 68, 83);
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.Location = new Point(70, 209);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(137, 50);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "CREAR MAQUINA";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += clickBtnCrearMaquina;
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(248, 209);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(137, 50);
            btnPrueba.TabIndex = 1;
            btnPrueba.Text = "INICIAR PRUEBA";
            btnPrueba.UseVisualStyleBackColor = true;
            btnPrueba.Click += clickBtnIniciarPrueba;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 127);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 41, 51);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnPrueba);
            Controls.Add(btnCrear);
            Name = "Home";
            Text = "Form1";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrear;
        private Button btnPrueba;
        private PictureBox pictureBox1;
    }
}