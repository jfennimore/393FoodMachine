﻿namespace _393_Food_Machine.Views
{
    partial class DishTypeSelect
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
            this.okButton = new System.Windows.Forms.Button();
            this.request = new System.Windows.Forms.Label();
            this.dishTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(109, 79);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // request
            // 
            this.request.AutoSize = true;
            this.request.Location = new System.Drawing.Point(78, 23);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(130, 13);
            this.request.TabIndex = 4;
            this.request.Text = "Please select a Dish Type";
            // 
            // dishTypeComboBox
            // 
            this.dishTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dishTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dishTypeComboBox.FormattingEnabled = true;
            this.dishTypeComboBox.Location = new System.Drawing.Point(65, 52);
            this.dishTypeComboBox.Name = "dishTypeComboBox";
            this.dishTypeComboBox.Size = new System.Drawing.Size(158, 21);
            this.dishTypeComboBox.TabIndex = 3;
            // 
            // DishTypeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 125);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.request);
            this.Controls.Add(this.dishTypeComboBox);
            this.Name = "DishTypeSelect";
            this.Text = "DishTypeSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label request;
        private System.Windows.Forms.ComboBox dishTypeComboBox;
    }
}