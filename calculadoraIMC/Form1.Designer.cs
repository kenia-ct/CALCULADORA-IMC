namespace calculadoraIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtPeso = new TextBox();
            txtEstatura = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Italic);
            label1.Location = new Point(204, 106);
            label1.Name = "label1";
            label1.Size = new Size(34, 16);
            label1.TabIndex = 0;
            label1.Text = "Peso:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Italic);
            label2.Location = new Point(204, 169);
            label2.Name = "label2";
            label2.Size = new Size(58, 16);
            label2.TabIndex = 1;
            label2.Text = "Estatura: ";
            // 
            // txtPeso
            // 
            txtPeso.BackColor = Color.RosyBrown;
            txtPeso.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Italic);
            txtPeso.Location = new Point(284, 102);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 20);
            txtPeso.TabIndex = 2;
            // 
            // txtEstatura
            // 
            txtEstatura.BackColor = Color.RosyBrown;
            txtEstatura.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Italic);
            txtEstatura.Location = new Point(284, 161);
            txtEstatura.Name = "txtEstatura";
            txtEstatura.Size = new Size(100, 20);
            txtEstatura.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Italic);
            button1.Location = new Point(238, 229);
            button1.Name = "button1";
            button1.Size = new Size(103, 46);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(515, 312);
            Controls.Add(button1);
            Controls.Add(txtEstatura);
            Controls.Add(txtPeso);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Indice de Masa Corporal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPeso;
        private TextBox txtEstatura;
        private Button button1;
    }
}
