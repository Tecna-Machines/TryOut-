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
            btnCrear = new Button();
            btnPrueba = new Button();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(70, 209);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(137, 50);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "CREAR MAQUINA";
            btnCrear.UseVisualStyleBackColor = true;
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
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrueba);
            Controls.Add(btnCrear);
            Name = "Home";
            Text = "Form1";
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrear;
        private Button btnPrueba;
    }
}