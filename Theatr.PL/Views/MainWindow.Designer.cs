
namespace Theatr.PL.Views
{
    partial class MainWindow
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
            this.registrationButton = new System.Windows.Forms.Button();
            this.autorizationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.Teal;
            this.registrationButton.ForeColor = System.Drawing.Color.Azure;
            this.registrationButton.Location = new System.Drawing.Point(12, 65);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(183, 74);
            this.registrationButton.TabIndex = 0;
            this.registrationButton.Text = "Registration";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // autorizationButton
            // 
            this.autorizationButton.BackColor = System.Drawing.Color.Teal;
            this.autorizationButton.ForeColor = System.Drawing.Color.Azure;
            this.autorizationButton.Location = new System.Drawing.Point(213, 65);
            this.autorizationButton.Name = "autorizationButton";
            this.autorizationButton.Size = new System.Drawing.Size(183, 74);
            this.autorizationButton.TabIndex = 1;
            this.autorizationButton.Text = "Autorization";
            this.autorizationButton.UseVisualStyleBackColor = false;
            this.autorizationButton.Click += new System.EventHandler(this.autorizationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(125, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Theatr \"Izauma\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(416, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autorizationButton);
            this.Controls.Add(this.registrationButton);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button autorizationButton;
        private System.Windows.Forms.Label label1;
    }
}