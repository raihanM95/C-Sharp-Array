namespace MyWinApp
{
    partial class ArrayForm
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
            this.showRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.ReverseButton = new System.Windows.Forms.Button();
            this.SumButton = new System.Windows.Forms.Button();
            this.CopyArrayButton = new System.Windows.Forms.Button();
            this.DuplicateShowButton = new System.Windows.Forms.Button();
            this.UniqueShowButton = new System.Windows.Forms.Button();
            this.MaxMinButton = new System.Windows.Forms.Button();
            this.EvenOddButton = new System.Windows.Forms.Button();
            this.AscDescButton = new System.Windows.Forms.Button();
            this.InsertNewValueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showRichTextBox
            // 
            this.showRichTextBox.Location = new System.Drawing.Point(35, 86);
            this.showRichTextBox.Name = "showRichTextBox";
            this.showRichTextBox.Size = new System.Drawing.Size(245, 261);
            this.showRichTextBox.TabIndex = 0;
            this.showRichTextBox.Text = "";
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(303, 86);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 1;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(205, 44);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(35, 44);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(154, 20);
            this.numberTextBox.TabIndex = 3;
            // 
            // ReverseButton
            // 
            this.ReverseButton.Location = new System.Drawing.Point(303, 115);
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(75, 23);
            this.ReverseButton.TabIndex = 4;
            this.ReverseButton.Text = "Reverse";
            this.ReverseButton.UseVisualStyleBackColor = true;
            this.ReverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(303, 145);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(75, 23);
            this.SumButton.TabIndex = 5;
            this.SumButton.Text = "Sum";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // CopyArrayButton
            // 
            this.CopyArrayButton.Location = new System.Drawing.Point(303, 175);
            this.CopyArrayButton.Name = "CopyArrayButton";
            this.CopyArrayButton.Size = new System.Drawing.Size(75, 23);
            this.CopyArrayButton.TabIndex = 6;
            this.CopyArrayButton.Text = "Copy Array";
            this.CopyArrayButton.UseVisualStyleBackColor = true;
            this.CopyArrayButton.Click += new System.EventHandler(this.CopyArrayButton_Click);
            // 
            // DuplicateShowButton
            // 
            this.DuplicateShowButton.Location = new System.Drawing.Point(303, 205);
            this.DuplicateShowButton.Name = "DuplicateShowButton";
            this.DuplicateShowButton.Size = new System.Drawing.Size(75, 23);
            this.DuplicateShowButton.TabIndex = 7;
            this.DuplicateShowButton.Text = "Duplicate";
            this.DuplicateShowButton.UseVisualStyleBackColor = true;
            this.DuplicateShowButton.Click += new System.EventHandler(this.DuplicateShowButton_Click);
            // 
            // UniqueShowButton
            // 
            this.UniqueShowButton.Location = new System.Drawing.Point(303, 235);
            this.UniqueShowButton.Name = "UniqueShowButton";
            this.UniqueShowButton.Size = new System.Drawing.Size(75, 23);
            this.UniqueShowButton.TabIndex = 8;
            this.UniqueShowButton.Text = "Unique";
            this.UniqueShowButton.UseVisualStyleBackColor = true;
            this.UniqueShowButton.Click += new System.EventHandler(this.UniqueShowButton_Click);
            // 
            // MaxMinButton
            // 
            this.MaxMinButton.Location = new System.Drawing.Point(303, 265);
            this.MaxMinButton.Name = "MaxMinButton";
            this.MaxMinButton.Size = new System.Drawing.Size(75, 23);
            this.MaxMinButton.TabIndex = 9;
            this.MaxMinButton.Text = "Max/Min";
            this.MaxMinButton.UseVisualStyleBackColor = true;
            this.MaxMinButton.Click += new System.EventHandler(this.MaxMinButton_Click);
            // 
            // EvenOddButton
            // 
            this.EvenOddButton.Location = new System.Drawing.Point(303, 294);
            this.EvenOddButton.Name = "EvenOddButton";
            this.EvenOddButton.Size = new System.Drawing.Size(75, 23);
            this.EvenOddButton.TabIndex = 10;
            this.EvenOddButton.Text = "Even/Odd";
            this.EvenOddButton.UseVisualStyleBackColor = true;
            this.EvenOddButton.Click += new System.EventHandler(this.EvenOddButton_Click);
            // 
            // AscDescButton
            // 
            this.AscDescButton.Location = new System.Drawing.Point(303, 323);
            this.AscDescButton.Name = "AscDescButton";
            this.AscDescButton.Size = new System.Drawing.Size(75, 23);
            this.AscDescButton.TabIndex = 11;
            this.AscDescButton.Text = "ASC/DESC";
            this.AscDescButton.UseVisualStyleBackColor = true;
            this.AscDescButton.Click += new System.EventHandler(this.AscDescButton_Click);
            // 
            // InsertNewValueButton
            // 
            this.InsertNewValueButton.Location = new System.Drawing.Point(303, 44);
            this.InsertNewValueButton.Name = "InsertNewValueButton";
            this.InsertNewValueButton.Size = new System.Drawing.Size(75, 23);
            this.InsertNewValueButton.TabIndex = 12;
            this.InsertNewValueButton.Text = "Insert New";
            this.InsertNewValueButton.UseVisualStyleBackColor = true;
            this.InsertNewValueButton.Click += new System.EventHandler(this.InsertNewValueButton_Click);
            // 
            // ArrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 411);
            this.Controls.Add(this.InsertNewValueButton);
            this.Controls.Add(this.AscDescButton);
            this.Controls.Add(this.EvenOddButton);
            this.Controls.Add(this.MaxMinButton);
            this.Controls.Add(this.UniqueShowButton);
            this.Controls.Add(this.DuplicateShowButton);
            this.Controls.Add(this.CopyArrayButton);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.ReverseButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.showRichTextBox);
            this.Name = "ArrayForm";
            this.Text = "Array Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox showRichTextBox;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button ReverseButton;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button CopyArrayButton;
        private System.Windows.Forms.Button DuplicateShowButton;
        private System.Windows.Forms.Button UniqueShowButton;
        private System.Windows.Forms.Button MaxMinButton;
        private System.Windows.Forms.Button EvenOddButton;
        private System.Windows.Forms.Button AscDescButton;
        private System.Windows.Forms.Button InsertNewValueButton;
    }
}