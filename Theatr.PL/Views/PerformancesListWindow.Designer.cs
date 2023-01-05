
namespace Theatr.PL.Views
{
    partial class PerformancesListWindow
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
            this.newsList = new System.Windows.Forms.ListView();
            this.NamePerformance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Authors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.autorizationButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.findComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newsList
            // 
            this.newsList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.newsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NamePerformance,
            this.Date,
            this.Authors,
            this.Genres});
            this.newsList.Font = new System.Drawing.Font("Sitka Banner", 10.8F);
            this.newsList.FullRowSelect = true;
            this.newsList.HideSelection = false;
            this.newsList.Location = new System.Drawing.Point(37, 163);
            this.newsList.MultiSelect = false;
            this.newsList.Name = "newsList";
            this.newsList.Size = new System.Drawing.Size(704, 267);
            this.newsList.TabIndex = 35;
            this.newsList.UseCompatibleStateImageBehavior = false;
            this.newsList.View = System.Windows.Forms.View.Details;
            this.newsList.SelectedIndexChanged += new System.EventHandler(this.activeButton_Click);
            // 
            // NamePerformance
            // 
            this.NamePerformance.Text = "Name of performances";
            this.NamePerformance.Width = 239;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 121;
            // 
            // Authors
            // 
            this.Authors.Text = "Authors";
            this.Authors.Width = 169;
            // 
            // Genres
            // 
            this.Genres.Text = "Genres";
            this.Genres.Width = 165;
            // 
            // autorizationButton
            // 
            this.autorizationButton.BackColor = System.Drawing.Color.Teal;
            this.autorizationButton.ForeColor = System.Drawing.Color.Azure;
            this.autorizationButton.Location = new System.Drawing.Point(37, 446);
            this.autorizationButton.Name = "autorizationButton";
            this.autorizationButton.Size = new System.Drawing.Size(167, 51);
            this.autorizationButton.TabIndex = 36;
            this.autorizationButton.Text = "Buy tickets for selected performance";
            this.autorizationButton.UseVisualStyleBackColor = false;
            this.autorizationButton.Click += new System.EventHandler(this.autorizationButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(610, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 51);
            this.button1.TabIndex = 37;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 10.8F);
            this.label3.Location = new System.Drawing.Point(123, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 38;
            this.label3.Text = "Find By:";
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.SkyBlue;
            this.inputBox.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.Location = new System.Drawing.Point(201, 90);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(113, 30);
            this.inputBox.TabIndex = 39;
            // 
            // findComboBox
            // 
            this.findComboBox.BackColor = System.Drawing.Color.SkyBlue;
            this.findComboBox.Font = new System.Drawing.Font("Sitka Banner", 10.8F);
            this.findComboBox.FormattingEnabled = true;
            this.findComboBox.Items.AddRange(new object[] {
            "Name of performance",
            "Author",
            "Genre",
            "Date"});
            this.findComboBox.Location = new System.Drawing.Point(201, 50);
            this.findComboBox.Name = "findComboBox";
            this.findComboBox.Size = new System.Drawing.Size(159, 34);
            this.findComboBox.TabIndex = 40;
            this.findComboBox.SelectedIndexChanged += new System.EventHandler(this.findComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 10.8F);
            this.label2.Location = new System.Drawing.Point(138, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "From:";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeStart.CalendarMonthBackground = System.Drawing.Color.SkyBlue;
            this.dateTimeStart.CalendarTrailingForeColor = System.Drawing.Color.SkyBlue;
            this.dateTimeStart.Enabled = false;
            this.dateTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(201, 129);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(177, 22);
            this.dateTimeStart.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 10.8F);
            this.label4.Location = new System.Drawing.Point(385, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 28);
            this.label4.TabIndex = 43;
            this.label4.Text = "To:";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Enabled = false;
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(426, 129);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(178, 22);
            this.dateTimeEnd.TabIndex = 44;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.PowderBlue;
            this.searchButton.Font = new System.Drawing.Font("Sitka Banner", 10.8F);
            this.searchButton.Location = new System.Drawing.Point(507, 43);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(97, 35);
            this.searchButton.TabIndex = 45;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.PowderBlue;
            this.resetButton.Font = new System.Drawing.Font("Sitka Banner", 10.8F);
            this.resetButton.Location = new System.Drawing.Point(508, 84);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(96, 36);
            this.resetButton.TabIndex = 46;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 10.8F);
            this.label1.Location = new System.Drawing.Point(139, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 28);
            this.label1.TabIndex = 47;
            this.label1.Text = "Value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(253, -8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 43);
            this.label5.TabIndex = 48;
            this.label5.Text = "List of performances";
            // 
            // PerformancesListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(753, 520);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findComboBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.autorizationButton);
            this.Controls.Add(this.newsList);
            this.Name = "PerformancesListWindow";
            this.Text = "PerformancesListWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView newsList;
        private System.Windows.Forms.ColumnHeader NamePerformance;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Authors;
        private System.Windows.Forms.ColumnHeader Genres;
        private System.Windows.Forms.Button autorizationButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.ComboBox findComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}