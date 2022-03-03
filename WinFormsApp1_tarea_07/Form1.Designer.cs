
namespace WinFormsApp1_tarea_07
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
            this.txtBx_entrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_calcular = new System.Windows.Forms.Button();
            this.txtBx_salida_tarea_07 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_salida_tarea_08 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBx_entrada
            // 
            this.txtBx_entrada.Location = new System.Drawing.Point(130, 59);
            this.txtBx_entrada.Name = "txtBx_entrada";
            this.txtBx_entrada.Size = new System.Drawing.Size(225, 27);
            this.txtBx_entrada.TabIndex = 0;
            this.txtBx_entrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_entrada_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese numero";
            // 
            // bttn_calcular
            // 
            this.bttn_calcular.Location = new System.Drawing.Point(361, 59);
            this.bttn_calcular.Name = "bttn_calcular";
            this.bttn_calcular.Size = new System.Drawing.Size(94, 29);
            this.bttn_calcular.TabIndex = 2;
            this.bttn_calcular.Text = "Calcular";
            this.bttn_calcular.UseVisualStyleBackColor = true;
            this.bttn_calcular.Click += new System.EventHandler(this.bttn_calcular_Click);
            // 
            // txtBx_salida_tarea_07
            // 
            this.txtBx_salida_tarea_07.Location = new System.Drawing.Point(12, 92);
            this.txtBx_salida_tarea_07.Name = "txtBx_salida_tarea_07";
            this.txtBx_salida_tarea_07.Size = new System.Drawing.Size(443, 27);
            this.txtBx_salida_tarea_07.TabIndex = 3;
            this.txtBx_salida_tarea_07.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_salida_tarea_07_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tarea_07";
            // 
            // txtBx_salida_tarea_08
            // 
            this.txtBx_salida_tarea_08.Location = new System.Drawing.Point(12, 159);
            this.txtBx_salida_tarea_08.Name = "txtBx_salida_tarea_08";
            this.txtBx_salida_tarea_08.Size = new System.Drawing.Size(443, 27);
            this.txtBx_salida_tarea_08.TabIndex = 5;
            this.txtBx_salida_tarea_08.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_salida_tarea_08_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tarea_08";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBx_salida_tarea_08);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBx_salida_tarea_07);
            this.Controls.Add(this.bttn_calcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx_entrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_entrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_calcular;
        private System.Windows.Forms.TextBox txtBx_salida_tarea_07;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBx_salida_tarea_08;
        private System.Windows.Forms.Label label3;
    }
}

