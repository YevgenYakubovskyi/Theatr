
namespace Theatr.PL.Views
{
    partial class TicketWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.newsList = new System.Windows.Forms.ListView();
            this.IdT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamePerformance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticketCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticketState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(512, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 42);
            this.button1.TabIndex = 32;
            this.button1.Text = "Go back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.ForeColor = System.Drawing.Color.Azure;
            this.button2.Location = new System.Drawing.Point(288, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 42);
            this.button2.TabIndex = 34;
            this.button2.Text = "Performance List";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.ForeColor = System.Drawing.Color.Azure;
            this.button3.Location = new System.Drawing.Point(70, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 42);
            this.button3.TabIndex = 35;
            this.button3.Text = "Buy selected broned ticket";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // newsList
            // 
            this.newsList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.newsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdT,
            this.NamePerformance,
            this.Date,
            this.ticketCategory,
            this.ticketState});
            this.newsList.Font = new System.Drawing.Font("Sitka Banner", 10.8F);
            this.newsList.FullRowSelect = true;
            this.newsList.HideSelection = false;
            this.newsList.Location = new System.Drawing.Point(42, 30);
            this.newsList.MultiSelect = false;
            this.newsList.Name = "newsList";
            this.newsList.Size = new System.Drawing.Size(700, 267);
            this.newsList.TabIndex = 36;
            this.newsList.UseCompatibleStateImageBehavior = false;
            this.newsList.View = System.Windows.Forms.View.Details;
            this.newsList.SelectedIndexChanged += new System.EventHandler(this.newsList_SelectedIndexChanged);
            // 
            // IdT
            // 
            this.IdT.Text = "IdT";
            this.IdT.Width = 0;
            // 
            // NamePerformance
            // 
            this.NamePerformance.Text = "Name of performances";
            this.NamePerformance.Width = 215;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 128;
            // 
            // ticketCategory
            // 
            this.ticketCategory.Text = "Ticket category";
            this.ticketCategory.Width = 115;
            // 
            // ticketState
            // 
            this.ticketState.Text = "Ticket state";
            this.ticketState.Width = 91;
            // 
            // TicketWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newsList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TicketWindow";
            this.Text = "TicketWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView newsList;
        private System.Windows.Forms.ColumnHeader NamePerformance;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader ticketCategory;
        private System.Windows.Forms.ColumnHeader ticketState;
        private System.Windows.Forms.ColumnHeader IdT;
    }
}