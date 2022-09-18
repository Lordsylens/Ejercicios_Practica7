namespace Ejercicios_Practica7
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
            this.numero1 = new System.Windows.Forms.Label();
            this.numero2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numero1
            // 
            this.numero1.AutoSize = true;
            this.numero1.Location = new System.Drawing.Point(158, 115);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(65, 13);
            this.numero1.TabIndex = 0;
            this.numero1.Text = "Numero 1 ->";
            // 
            // numero2
            // 
            this.numero2.AutoSize = true;
            this.numero2.Location = new System.Drawing.Point(158, 166);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(65, 13);
            this.numero2.TabIndex = 1;
            this.numero2.Text = "Numero 2 ->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "El resultdado es ->";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(385, 112);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(75, 23);
            this.suma.TabIndex = 5;
            this.suma.Text = "Sumar";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(385, 163);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(75, 23);
            this.resta.TabIndex = 6;
            this.resta.Text = "Restar";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(385, 215);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(75, 23);
            this.multiplicar.TabIndex = 7;
            this.multiplicar.Text = "Multiplicar";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(385, 254);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(75, 23);
            this.dividir.TabIndex = 8;
            this.dividir.Text = "Dividir";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(385, 301);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 9;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 357);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numero1;
        private System.Windows.Forms.Label numero2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button limpiar;
    }
}

