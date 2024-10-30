namespace LibraryApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button checkAvailabilityButton;
        private Button issueBookButton;
        private Button selectBookButton;
        private ComboBox comboBoxBookType;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.checkAvailabilityButton = new System.Windows.Forms.Button();
            this.issueBookButton = new System.Windows.Forms.Button();
            this.selectBookButton = new System.Windows.Forms.Button();
            this.comboBoxBookType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkAvailabilityButton
            // 
            this.checkAvailabilityButton.Location = new System.Drawing.Point(50, 150);
            this.checkAvailabilityButton.Name = "checkAvailabilityButton";
            this.checkAvailabilityButton.Size = new System.Drawing.Size(200, 40);
            this.checkAvailabilityButton.TabIndex = 0;
            this.checkAvailabilityButton.Text = "Проверить доступность";
            this.checkAvailabilityButton.UseVisualStyleBackColor = true;
            this.checkAvailabilityButton.Click += new System.EventHandler(this.CheckAvailabilityButton_Click);
            // 
            // issueBookButton
            // 
            this.issueBookButton.Location = new System.Drawing.Point(50, 210);
            this.issueBookButton.Name = "issueBookButton";
            this.issueBookButton.Size = new System.Drawing.Size(200, 40);
            this.issueBookButton.TabIndex = 1;
            this.issueBookButton.Text = "Выдать книгу";
            this.issueBookButton.UseVisualStyleBackColor = true;
            this.issueBookButton.Click += new System.EventHandler(this.IssueBookButton_Click);
            // 
            // selectBookButton
            // 
            this.selectBookButton.Location = new System.Drawing.Point(50, 50);
            this.selectBookButton.Name = "selectBookButton";
            this.selectBookButton.Size = new System.Drawing.Size(200, 40);
            this.selectBookButton.TabIndex = 2;
            this.selectBookButton.Text = "Выбрать книгу";
            this.selectBookButton.UseVisualStyleBackColor = true;
            this.selectBookButton.Click += new System.EventHandler(this.SelectBookButton_Click);
            // 
            // comboBoxBookType
            // 
            this.comboBoxBookType.FormattingEnabled = true;
            this.comboBoxBookType.Items.AddRange(new object[] {
            "Художественная книга",
            "Научная книга",
            "Энциклопедия"});
            this.comboBoxBookType.Location = new System.Drawing.Point(50, 100);
            this.comboBoxBookType.Name = "comboBoxBookType";
            this.comboBoxBookType.Size = new System.Drawing.Size(200, 24);
            this.comboBoxBookType.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.comboBoxBookType);
            this.Controls.Add(this.selectBookButton);
            this.Controls.Add(this.issueBookButton);
            this.Controls.Add(this.checkAvailabilityButton);
            this.Name = "MainForm";
            this.Text = "Библиотека";
            this.ResumeLayout(false);
        }
    }
}
