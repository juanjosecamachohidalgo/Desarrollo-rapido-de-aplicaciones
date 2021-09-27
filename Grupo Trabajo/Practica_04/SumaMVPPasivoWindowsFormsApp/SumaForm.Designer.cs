namespace SumaMVPPasivoWindowsFormsApp
{
    partial class SumaForm
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
            this.primeraCantidadTextBox = new System.Windows.Forms.TextBox();
            this.segundaCantidadTextBox = new System.Windows.Forms.TextBox();
            this.sumaButton = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // primeraCantidadTextBox
            // 
            this.primeraCantidadTextBox.Location = new System.Drawing.Point(38, 25);
            this.primeraCantidadTextBox.Name = "primeraCantidadTextBox";
            this.primeraCantidadTextBox.Size = new System.Drawing.Size(192, 22);
            this.primeraCantidadTextBox.TabIndex = 0;
            // 
            // segundaCantidadTextBox
            // 
            this.segundaCantidadTextBox.Location = new System.Drawing.Point(38, 80);
            this.segundaCantidadTextBox.Name = "segundaCantidadTextBox";
            this.segundaCantidadTextBox.Size = new System.Drawing.Size(192, 22);
            this.segundaCantidadTextBox.TabIndex = 1;
            // 
            // sumaButton
            // 
            this.sumaButton.Location = new System.Drawing.Point(94, 148);
            this.sumaButton.Name = "sumaButton";
            this.sumaButton.Size = new System.Drawing.Size(75, 23);
            this.sumaButton.TabIndex = 2;
            this.sumaButton.Text = "Sumar";
            this.sumaButton.UseVisualStyleBackColor = true;
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new System.Drawing.Point(38, 207);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(16, 17);
            this.resultadoLabel.TabIndex = 3;
            this.resultadoLabel.Text = "0";
            // 
            // SumaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.sumaButton);
            this.Controls.Add(this.segundaCantidadTextBox);
            this.Controls.Add(this.primeraCantidadTextBox);
            this.Name = "SumaForm";
            this.Text = "SumaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox primeraCantidadTextBox;
        private System.Windows.Forms.TextBox segundaCantidadTextBox;
        private System.Windows.Forms.Button sumaButton;
        private System.Windows.Forms.Label resultadoLabel;
    }
}