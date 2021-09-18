
namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 23);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "txtNum2";
            this.textBox1.Location = new System.Drawing.Point(374, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 36);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.AccessibleDescription = "txtNum1";
            this.textBox2.Location = new System.Drawing.Point(58, 107);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 36);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "btnOperar";
            this.button1.Location = new System.Drawing.Point(58, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Operar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "btnLimpiar";
            this.button2.Location = new System.Drawing.Point(215, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AccessibleDescription = "btnCerrar";
            this.button3.Location = new System.Drawing.Point(374, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AccessibleDescription = "btnConvertirABinario";
            this.button4.Location = new System.Drawing.Point(58, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 39);
            this.button4.TabIndex = 6;
            this.button4.Text = "Convertir a Binario";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AccessibleDescription = "btnConvertirADecimal";
            this.button5.Location = new System.Drawing.Point(289, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(225, 39);
            this.button5.TabIndex = 7;
            this.button5.Text = "Converti a Decimal";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(530, 54);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 194);
            this.textBox3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "lblResultado";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resultado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Emanuel Camejo 2°D";
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}

