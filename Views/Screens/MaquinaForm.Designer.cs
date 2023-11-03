namespace Views
{
    partial class MaquinaForm
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
            btnCrear = new Button();
            model = new TextBox();
            name = new TextBox();
            descripcion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(59, 68, 83);
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Location = new Point(419, 301);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(198, 56);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += clickCrearMaquina;
            // 
            // model
            // 
            model.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            model.Location = new Point(156, 122);
            model.Name = "model";
            model.Size = new Size(168, 29);
            model.TabIndex = 1;
            // 
            // name
            // 
            name.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(449, 122);
            name.Name = "name";
            name.Size = new Size(168, 29);
            name.TabIndex = 2;
            // 
            // descripcion
            // 
            descripcion.Location = new Point(156, 172);
            descripcion.Multiline = true;
            descripcion.Name = "descripcion";
            descripcion.Size = new Size(461, 90);
            descripcion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 128);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 4;
            label1.Text = " MODELO M:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(358, 128);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 5;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 207);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 6;
            label3.Text = "DESCRIPCION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(217, 40);
            label4.Name = "label4";
            label4.Size = new Size(236, 20);
            label4.TabIndex = 7;
            label4.Text = "agregar una nueva maquinia";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(59, 68, 83);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(204, 301);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(198, 56);
            btnBack.TabIndex = 8;
            btnBack.Text = "VOLVER AL INICIO";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnVolverInicio;
            // 
            // MaquinaForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 390);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(descripcion);
            Controls.Add(name);
            Controls.Add(model);
            Controls.Add(btnCrear);
            Name = "MaquinaForm";
            Text = "MaquinaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrear;
        private TextBox model;
        private TextBox name;
        private TextBox descripcion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnBack;
    }
}