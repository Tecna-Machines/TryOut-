namespace Views.Screens
{
    partial class PruebaForm
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            optionsMachineSelect = new ComboBox();
            selectProduct = new ComboBox();
            labelProduct = new Label();
            comboBox1 = new ComboBox();
            selectFormato = new Label();
            textBox2 = new TextBox();
            observaciones = new Label();
            btnVolver = new Button();
            btnListo = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(528, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 26);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 217);
            label1.Name = "label1";
            label1.Size = new Size(145, 13);
            label1.TabIndex = 1;
            label1.Text = "Velocidad teorica Piezas / hs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 100);
            label2.Name = "label2";
            label2.Size = new Size(71, 13);
            label2.TabIndex = 3;
            label2.Text = "MODELO M -";
            // 
            // optionsMachineSelect
            // 
            optionsMachineSelect.FormattingEnabled = true;
            optionsMachineSelect.Location = new Point(120, 97);
            optionsMachineSelect.Name = "optionsMachineSelect";
            optionsMachineSelect.Size = new Size(253, 21);
            optionsMachineSelect.TabIndex = 4;
            // 
            // selectProduct
            // 
            selectProduct.FormattingEnabled = true;
            selectProduct.Location = new Point(471, 97);
            selectProduct.Name = "selectProduct";
            selectProduct.Size = new Size(253, 21);
            selectProduct.TabIndex = 5;
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Location = new Point(397, 100);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(68, 13);
            labelProduct.TabIndex = 6;
            labelProduct.Text = "PRODUCTO";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(473, 140);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 21);
            comboBox1.TabIndex = 7;
            // 
            // selectFormato
            // 
            selectFormato.AutoSize = true;
            selectFormato.Location = new Point(405, 143);
            selectFormato.Name = "selectFormato";
            selectFormato.Size = new Size(60, 13);
            selectFormato.TabIndex = 8;
            selectFormato.Text = "FORMATO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 137);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 39);
            textBox2.TabIndex = 9;
            // 
            // observaciones
            // 
            observaciones.AutoSize = true;
            observaciones.Location = new Point(18, 143);
            observaciones.Name = "observaciones";
            observaciones.Size = new Size(98, 13);
            observaciones.TabIndex = 10;
            observaciones.Text = "OBSERVACIONES";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(122, 314);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(129, 49);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "VOLVER AL INICIO";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += volverInicio;
            // 
            // btnListo
            // 
            btnListo.Location = new Point(307, 314);
            btnListo.Name = "btnListo";
            btnListo.Size = new Size(158, 49);
            btnListo.TabIndex = 12;
            btnListo.Text = "LISTO PARA LA PRUEBA";
            btnListo.UseVisualStyleBackColor = true;
            // 
            // PruebaForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListo);
            Controls.Add(btnVolver);
            Controls.Add(observaciones);
            Controls.Add(textBox2);
            Controls.Add(selectFormato);
            Controls.Add(comboBox1);
            Controls.Add(labelProduct);
            Controls.Add(selectProduct);
            Controls.Add(optionsMachineSelect);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "PruebaForm";
            Text = "PruebaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ComboBox optionsMachineSelect;
        private ComboBox selectProduct;
        private Label labelProduct;
        private ComboBox comboBox1;
        private Label selectFormato;
        private TextBox textBox2;
        private Label observaciones;
        private Button btnVolver;
        private Button btnListo;
    }
}