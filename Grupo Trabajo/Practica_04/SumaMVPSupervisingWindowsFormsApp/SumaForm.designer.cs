namespace SumaMVPSupervisingWindowsFormsApp
{
    partial class SumaForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labResultado = new System.Windows.Forms.Label();
            this.butSumar = new System.Windows.Forms.Button();
            this.labMensaje = new System.Windows.Forms.Label();
            this.textNumeroB = new System.Windows.Forms.TextBox();
            this.textNumeroA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labResultado
            // 
            this.labResultado.AutoSize = true;
            this.labResultado.Location = new System.Drawing.Point(109, 219);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(0, 13);
            this.labResultado.TabIndex = 9;
            // 
            // butSumar
            // 
            this.butSumar.Location = new System.Drawing.Point(110, 169);
            this.butSumar.Name = "butSumar";
            this.butSumar.Size = new System.Drawing.Size(75, 20);
            this.butSumar.TabIndex = 8;
            this.butSumar.Text = "Sumar";
            this.butSumar.UseVisualStyleBackColor = true;
            // 
            // labMensaje
            // 
            this.labMensaje.AutoSize = true;
            this.labMensaje.Location = new System.Drawing.Point(90, 27);
            this.labMensaje.Name = "labMensaje";
            this.labMensaje.Size = new System.Drawing.Size(116, 13);
            this.labMensaje.TabIndex = 7;
            this.labMensaje.Text = "Introduzca los números";
            // 
            // textNumeroB
            // 
            this.textNumeroB.Location = new System.Drawing.Point(97, 121);
            this.textNumeroB.Name = "textNumeroB";
            this.textNumeroB.Size = new System.Drawing.Size(100, 20);
            this.textNumeroB.TabIndex = 6;
            // 
            // textNumeroA
            // 
            this.textNumeroA.Location = new System.Drawing.Point(97, 64);
            this.textNumeroA.Name = "textNumeroA";
            this.textNumeroA.Size = new System.Drawing.Size(100, 20);
            this.textNumeroA.TabIndex = 5;
            // 
            // SumaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.butSumar);
            this.Controls.Add(this.labMensaje);
            this.Controls.Add(this.textNumeroB);
            this.Controls.Add(this.textNumeroA);
            this.MaximizeBox = false;
            this.Name = "SumaForm";
            this.Text = "Suma MVP Supervising";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labResultado;
        private System.Windows.Forms.Button butSumar;
        private System.Windows.Forms.Label labMensaje;
        private System.Windows.Forms.TextBox textNumeroB;
        private System.Windows.Forms.TextBox textNumeroA;
    }
}

