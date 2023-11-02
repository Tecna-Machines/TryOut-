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
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(493, 291);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(161, 92);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += clickCrearMaquina;
            // 
            // model
            // 
            model.Location = new Point(231, 113);
            model.Name = "model";
            model.Size = new Size(195, 23);
            model.TabIndex = 1;
            // 
            // name
            // 
            name.Location = new Point(231, 158);
            name.Name = "name";
            name.Size = new Size(195, 23);
            name.TabIndex = 2;
            // 
            // descripcion
            // 
            descripcion.Location = new Point(231, 230);
            descripcion.Multiline = true;
            descripcion.Name = "descripcion";
            descripcion.Size = new Size(195, 153);
            descripcion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 116);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 161);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 233);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 6;
            label3.Text = "descripcion";
            // 
            // MaquinaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}