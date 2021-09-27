namespace MVCWindowsFormsApplication
{
    partial class Vista
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
            this.IntroTextBox = new System.Windows.Forms.Label();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.CambioLabel = new System.Windows.Forms.Label();
            this.pesetasButton = new System.Windows.Forms.Button();
            this.eurosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IntroTextBox
            // 
            this.IntroTextBox.AutoSize = true;
            this.IntroTextBox.Location = new System.Drawing.Point(74, 27);
            this.IntroTextBox.Name = "IntroTextBox";
            this.IntroTextBox.Size = new System.Drawing.Size(215, 17);
            this.IntroTextBox.TabIndex = 0;
            this.IntroTextBox.Text = "¿Que cantidad desea introducir?";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(99, 66);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(161, 22);
            this.cantidadTextBox.TabIndex = 1;
            // 
            // CambioLabel
            // 
            this.CambioLabel.AutoSize = true;
            this.CambioLabel.Location = new System.Drawing.Point(112, 118);
            this.CambioLabel.Name = "CambioLabel";
            this.CambioLabel.Size = new System.Drawing.Size(12, 17);
            this.CambioLabel.TabIndex = 2;
            this.CambioLabel.Text = ".";
            // 
            // pesetasButton
            // 
            this.pesetasButton.Location = new System.Drawing.Point(64, 168);
            this.pesetasButton.Name = "pesetasButton";
            this.pesetasButton.Size = new System.Drawing.Size(93, 23);
            this.pesetasButton.TabIndex = 3;
            this.pesetasButton.Text = "A pesetas";
            this.pesetasButton.UseVisualStyleBackColor = true;
            this.pesetasButton.Click += new System.EventHandler(this.pesetasButton_Click);
            // 
            // eurosButton
            // 
            this.eurosButton.Location = new System.Drawing.Point(231, 168);
            this.eurosButton.Name = "eurosButton";
            this.eurosButton.Size = new System.Drawing.Size(75, 23);
            this.eurosButton.TabIndex = 4;
            this.eurosButton.Text = "A euros";
            this.eurosButton.UseVisualStyleBackColor = true;
            this.eurosButton.Click += new System.EventHandler(this.eurosButton_Click);
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 239);
            this.Controls.Add(this.eurosButton);
            this.Controls.Add(this.pesetasButton);
            this.Controls.Add(this.CambioLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.IntroTextBox);
            this.Name = "Vista";
            this.Text = "Vista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IntroTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.Label CambioLabel;
        private System.Windows.Forms.Button pesetasButton;
        private System.Windows.Forms.Button eurosButton;
    }
}