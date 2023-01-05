
namespace Theatr.PL.Views
{
    partial class BuyTicketWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ticketCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.performanceNameInWindow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.authorsListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.genreListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yourName = new System.Windows.Forms.Label();
            this.yourLastname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.yourLastname);
            this.panel1.Controls.Add(this.yourName);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.ticketCategory);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.performanceNameInWindow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.authorsListBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buyButton);
            this.panel1.Controls.Add(this.genreListBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 453);
            this.panel1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(436, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 39);
            this.button3.TabIndex = 56;
            this.button3.Text = "Check ticket";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ticketCategory
            // 
            this.ticketCategory.BackColor = System.Drawing.Color.SkyBlue;
            this.ticketCategory.FormattingEnabled = true;
            this.ticketCategory.Items.AddRange(new object[] {
            "VIP",
            "Standart"});
            this.ticketCategory.Location = new System.Drawing.Point(162, 308);
            this.ticketCategory.Name = "ticketCategory";
            this.ticketCategory.Size = new System.Drawing.Size(177, 24);
            this.ticketCategory.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 28);
            this.label7.TabIndex = 54;
            this.label7.Text = "Ticket category:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(436, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 39);
            this.button2.TabIndex = 53;
            this.button2.Text = "Brone";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(347, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 52;
            this.label4.Text = "Your lastname:";
            // 
            // performanceNameInWindow
            // 
            this.performanceNameInWindow.AutoSize = true;
            this.performanceNameInWindow.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.performanceNameInWindow.Location = new System.Drawing.Point(157, 71);
            this.performanceNameInWindow.Name = "performanceNameInWindow";
            this.performanceNameInWindow.Size = new System.Drawing.Size(55, 28);
            this.performanceNameInWindow.TabIndex = 50;
            this.performanceNameInWindow.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(295, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 43);
            this.label1.TabIndex = 49;
            this.label1.Text = "Buying ticket";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(643, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 51);
            this.button1.TabIndex = 38;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // authorsListBox
            // 
            this.authorsListBox.BackColor = System.Drawing.Color.SkyBlue;
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.ItemHeight = 16;
            this.authorsListBox.Location = new System.Drawing.Point(162, 109);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.ScrollAlwaysVisible = true;
            this.authorsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.authorsListBox.Size = new System.Drawing.Size(177, 84);
            this.authorsListBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(347, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 31;
            this.label6.Text = "Your name:";
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.Teal;
            this.buyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buyButton.Location = new System.Drawing.Point(184, 389);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(165, 39);
            this.buyButton.TabIndex = 26;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // genreListBox
            // 
            this.genreListBox.BackColor = System.Drawing.Color.SkyBlue;
            this.genreListBox.FormattingEnabled = true;
            this.genreListBox.ItemHeight = 16;
            this.genreListBox.Location = new System.Drawing.Point(162, 199);
            this.genreListBox.Name = "genreListBox";
            this.genreListBox.ScrollAlwaysVisible = true;
            this.genreListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.genreListBox.Size = new System.Drawing.Size(177, 84);
            this.genreListBox.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Authors:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Genres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Performance:";
            // 
            // yourName
            // 
            this.yourName.AutoSize = true;
            this.yourName.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yourName.Location = new System.Drawing.Point(480, 106);
            this.yourName.Name = "yourName";
            this.yourName.Size = new System.Drawing.Size(55, 28);
            this.yourName.TabIndex = 57;
            this.yourName.Text = "Name";
            // 
            // yourLastname
            // 
            this.yourLastname.AutoSize = true;
            this.yourLastname.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yourLastname.Location = new System.Drawing.Point(480, 142);
            this.yourLastname.Name = "yourLastname";
            this.yourLastname.Size = new System.Drawing.Size(55, 28);
            this.yourLastname.TabIndex = 58;
            this.yourLastname.Text = "Name";
            // 
            // BuyTicketWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "BuyTicketWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArticleEditorWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox genreListBox;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox authorsListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label performanceNameInWindow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ticketCategory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label yourLastname;
        private System.Windows.Forms.Label yourName;
    }
}