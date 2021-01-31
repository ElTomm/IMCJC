
namespace IMC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmdIMC = new System.Windows.Forms.Button();
            this.txtd1 = new System.Windows.Forms.TextBox();
            this.txtd2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblpeso.Location = new System.Drawing.Point(359, 44);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(57, 24);
            this.lblpeso.TabIndex = 0;
            this.lblpeso.Text = "Peso";
            this.lblpeso.Click += new System.EventHandler(this.lblpeso_Click);
            this.lblpeso.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblpeso_MouseMove);
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblaltura.Location = new System.Drawing.Point(359, 91);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(64, 24);
            this.lblaltura.TabIndex = 1;
            this.lblaltura.Text = "Altura";
            this.lblaltura.Click += new System.EventHandler(this.lblaltura_Click);
            this.lblaltura.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblaltura_MouseMove);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblResultado.Location = new System.Drawing.Point(462, 148);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(103, 24);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // cmdIMC
            // 
            this.cmdIMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdIMC.Font = new System.Drawing.Font("AR DELANEY", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIMC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdIMC.Location = new System.Drawing.Point(476, 199);
            this.cmdIMC.Name = "cmdIMC";
            this.cmdIMC.Size = new System.Drawing.Size(75, 35);
            this.cmdIMC.TabIndex = 5;
            this.cmdIMC.Text = "IMC";
            this.cmdIMC.UseVisualStyleBackColor = false;
            this.cmdIMC.Click += new System.EventHandler(this.cmdIMC_Click);
            // 
            // txtd1
            // 
            this.txtd1.Location = new System.Drawing.Point(451, 44);
            this.txtd1.Name = "txtd1";
            this.txtd1.Size = new System.Drawing.Size(100, 20);
            this.txtd1.TabIndex = 6;
            // 
            // txtd2
            // 
            this.txtd2.Location = new System.Drawing.Point(451, 91);
            this.txtd2.Name = "txtd2";
            this.txtd2.Size = new System.Drawing.Size(100, 20);
            this.txtd2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 322);
            this.Controls.Add(this.txtd2);
            this.Controls.Add(this.txtd1);
            this.Controls.Add(this.cmdIMC);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblpeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button cmdIMC;
        private System.Windows.Forms.TextBox txtd1;
        private System.Windows.Forms.TextBox txtd2;
    }
}

