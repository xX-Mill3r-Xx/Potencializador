
namespace Potenciador
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Potencia = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.txt_ValorDig = new System.Windows.Forms.TextBox();
            this.txt_ValorPotencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 43);
            this.label3.TabIndex = 11;
            this.label3.Text = "Calcular Potencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "A Potencia deste numero é:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Base";
            // 
            // btn_Potencia
            // 
            this.btn_Potencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Potencia.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Potencia.Location = new System.Drawing.Point(80, 324);
            this.btn_Potencia.Name = "btn_Potencia";
            this.btn_Potencia.Size = new System.Drawing.Size(272, 96);
            this.btn_Potencia.TabIndex = 8;
            this.btn_Potencia.Text = "Math.Pow";
            this.btn_Potencia.UseVisualStyleBackColor = true;
            this.btn_Potencia.Click += new System.EventHandler(this.btn_Potencia_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Result.Location = new System.Drawing.Point(80, 255);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(272, 63);
            this.txt_Result.TabIndex = 7;
            this.txt_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ValorDig
            // 
            this.txt_ValorDig.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_ValorDig.Location = new System.Drawing.Point(260, 141);
            this.txt_ValorDig.Name = "txt_ValorDig";
            this.txt_ValorDig.Size = new System.Drawing.Size(92, 63);
            this.txt_ValorDig.TabIndex = 6;
            this.txt_ValorDig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ValorPotencia
            // 
            this.txt_ValorPotencia.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_ValorPotencia.Location = new System.Drawing.Point(80, 141);
            this.txt_ValorPotencia.Name = "txt_ValorPotencia";
            this.txt_ValorPotencia.Size = new System.Drawing.Size(92, 63);
            this.txt_ValorPotencia.TabIndex = 12;
            this.txt_ValorPotencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(254, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Expoente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(206, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "^";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ValorPotencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Potencia);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.txt_ValorDig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Potencia;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.TextBox txt_ValorDig;
        private System.Windows.Forms.TextBox txt_ValorPotencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

