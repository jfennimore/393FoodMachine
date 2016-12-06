namespace _393_Food_Machine.Views
{
    partial class QuickNewIngredient
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
            this.newCategoryBox = new System.Windows.Forms.ComboBox();
            this.newIngrButton = new System.Windows.Forms.Button();
            this.newIngredientUnit = new System.Windows.Forms.ComboBox();
            this.newIngredientCalories = new System.Windows.Forms.TextBox();
            this.newIngredientName = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newCategoryBox
            // 
            this.newCategoryBox.FormattingEnabled = true;
            this.newCategoryBox.Location = new System.Drawing.Point(364, 49);
            this.newCategoryBox.Name = "newCategoryBox";
            this.newCategoryBox.Size = new System.Drawing.Size(75, 21);
            this.newCategoryBox.TabIndex = 14;
            this.newCategoryBox.Text = "(Category)";
            // 
            // newIngrButton
            // 
            this.newIngrButton.Location = new System.Drawing.Point(185, 81);
            this.newIngrButton.Name = "newIngrButton";
            this.newIngrButton.Size = new System.Drawing.Size(67, 23);
            this.newIngrButton.TabIndex = 15;
            this.newIngrButton.Text = "Add New";
            this.newIngrButton.UseVisualStyleBackColor = true;
            this.newIngrButton.Click += new System.EventHandler(this.newIngrButton_Click);
            // 
            // newIngredientUnit
            // 
            this.newIngredientUnit.FormattingEnabled = true;
            this.newIngredientUnit.Location = new System.Drawing.Point(242, 49);
            this.newIngredientUnit.Name = "newIngredientUnit";
            this.newIngredientUnit.Size = new System.Drawing.Size(116, 21);
            this.newIngredientUnit.TabIndex = 13;
            this.newIngredientUnit.Text = "(Most common unit)";
            // 
            // newIngredientCalories
            // 
            this.newIngredientCalories.Location = new System.Drawing.Point(185, 49);
            this.newIngredientCalories.Name = "newIngredientCalories";
            this.newIngredientCalories.Size = new System.Drawing.Size(51, 20);
            this.newIngredientCalories.TabIndex = 12;
            this.newIngredientCalories.Text = "(Calories)";
            // 
            // newIngredientName
            // 
            this.newIngredientName.Location = new System.Drawing.Point(12, 49);
            this.newIngredientName.Name = "newIngredientName";
            this.newIngredientName.Size = new System.Drawing.Size(167, 20);
            this.newIngredientName.TabIndex = 11;
            this.newIngredientName.Text = "(New Ingredient Name)";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(13, 19);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(187, 13);
            this.messageLabel.TabIndex = 16;
            this.messageLabel.Text = "X is not currently an ingredient, add it?";
            // 
            // QuickNewIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 111);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.newCategoryBox);
            this.Controls.Add(this.newIngrButton);
            this.Controls.Add(this.newIngredientUnit);
            this.Controls.Add(this.newIngredientCalories);
            this.Controls.Add(this.newIngredientName);
            this.Name = "QuickNewIngredient";
            this.Text = "QuickNewIngredient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox newCategoryBox;
        private System.Windows.Forms.Button newIngrButton;
        private System.Windows.Forms.ComboBox newIngredientUnit;
        private System.Windows.Forms.TextBox newIngredientCalories;
        private System.Windows.Forms.TextBox newIngredientName;
        private System.Windows.Forms.Label messageLabel;
    }
}