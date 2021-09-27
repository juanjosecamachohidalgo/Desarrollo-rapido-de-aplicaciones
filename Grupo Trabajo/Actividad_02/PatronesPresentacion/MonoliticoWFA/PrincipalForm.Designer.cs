namespace MonoliticoWFA
{
    partial class PrincipalForm
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
            this.listaActividadesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.precioEstimadoLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.precioActualTextBox = new System.Windows.Forms.TextBox();
            this.actualizarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaActividadesComboBox
            // 
            this.listaActividadesComboBox.FormattingEnabled = true;
            this.listaActividadesComboBox.Location = new System.Drawing.Point(174, 51);
            this.listaActividadesComboBox.Name = "listaActividadesComboBox";
            this.listaActividadesComboBox.Size = new System.Drawing.Size(184, 21);
            this.listaActividadesComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actividad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio Estimado";
            // 
            // precioEstimadoLabel
            // 
            this.precioEstimadoLabel.AutoSize = true;
            this.precioEstimadoLabel.Location = new System.Drawing.Point(174, 101);
            this.precioEstimadoLabel.Name = "precioEstimadoLabel";
            this.precioEstimadoLabel.Size = new System.Drawing.Size(13, 13);
            this.precioEstimadoLabel.TabIndex = 3;
            this.precioEstimadoLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PrecioActual";
            // 
            // precioActualTextBox
            // 
            this.precioActualTextBox.Location = new System.Drawing.Point(174, 161);
            this.precioActualTextBox.Name = "precioActualTextBox";
            this.precioActualTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioActualTextBox.TabIndex = 5;
            // 
            // actualizarButton
            // 
            this.actualizarButton.Enabled = false;
            this.actualizarButton.Location = new System.Drawing.Point(177, 239);
            this.actualizarButton.Name = "actualizarButton";
            this.actualizarButton.Size = new System.Drawing.Size(75, 23);
            this.actualizarButton.TabIndex = 6;
            this.actualizarButton.Text = "Actualizar";
            this.actualizarButton.UseVisualStyleBackColor = true;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 290);
            this.Controls.Add(this.actualizarButton);
            this.Controls.Add(this.precioActualTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.precioEstimadoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaActividadesComboBox);
            this.Name = "PrincipalForm";
            this.Text = "Coste Actividades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listaActividadesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label precioEstimadoLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox precioActualTextBox;
        private System.Windows.Forms.Button actualizarButton;
    }
}

