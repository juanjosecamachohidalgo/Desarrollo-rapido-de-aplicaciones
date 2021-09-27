namespace SaludoMVPPasivoWindowsFormsApp
{
    partial class SaludoForm
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
            this.saludoButton = new System.Windows.Forms.Button();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.saludoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saludoButton
            // 
            this.saludoButton.Location = new System.Drawing.Point(57, 112);
            this.saludoButton.Name = "saludoButton";
            this.saludoButton.Size = new System.Drawing.Size(149, 23);
            this.saludoButton.TabIndex = 0;
            this.saludoButton.Text = "Saludo";
            this.saludoButton.UseVisualStyleBackColor = true;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(37, 25);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(139, 17);
            this.nombreLabel.TabIndex = 1;
            this.nombreLabel.Text = "¿Cuál es tu nombre?";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(40, 66);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(198, 22);
            this.nombreTextBox.TabIndex = 2;
            // 
            // saludoLabel
            // 
            this.saludoLabel.AutoSize = true;
            this.saludoLabel.Location = new System.Drawing.Point(80, 177);
            this.saludoLabel.Name = "saludoLabel";
            this.saludoLabel.Size = new System.Drawing.Size(37, 17);
            this.saludoLabel.TabIndex = 3;
            this.saludoLabel.Text = "Hola";
            // 
            // SaludoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.saludoLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.saludoButton);
            this.Name = "SaludoForm";
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saludoButton;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label saludoLabel;
    }
}