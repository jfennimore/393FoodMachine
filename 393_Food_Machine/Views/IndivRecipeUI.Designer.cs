namespace _393_Food_Machine
{
    partial class IndivRecipeUI
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
            this.backButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.editRecipeButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.ingredientListBox = new System.Windows.Forms.ListBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.dishTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(81, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "< Recipe List";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(412, 13);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // editRecipeButton
            // 
            this.editRecipeButton.Location = new System.Drawing.Point(493, 13);
            this.editRecipeButton.Name = "editRecipeButton";
            this.editRecipeButton.Size = new System.Drawing.Size(75, 23);
            this.editRecipeButton.TabIndex = 2;
            this.editRecipeButton.Text = "Edit Recipe";
            this.editRecipeButton.UseVisualStyleBackColor = true;
            this.editRecipeButton.Click += new System.EventHandler(this.editRecipeButton_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(202, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(138, 27);
            this.title.TabIndex = 3;
            this.title.Text = "Recipe Title";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ingredientListBox
            // 
            this.ingredientListBox.FormattingEnabled = true;
            this.ingredientListBox.Location = new System.Drawing.Point(71, 94);
            this.ingredientListBox.Name = "ingredientListBox";
            this.ingredientListBox.Size = new System.Drawing.Size(416, 82);
            this.ingredientListBox.TabIndex = 4;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsLabel.Location = new System.Drawing.Point(67, 72);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(94, 19);
            this.ingredientsLabel.TabIndex = 6;
            this.ingredientsLabel.Text = "Ingredients";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(67, 183);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(188, 19);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Preparation Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(71, 206);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(416, 84);
            this.descriptionTextBox.TabIndex = 8;
            this.descriptionTextBox.Text = "";
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(225, 40);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(86, 13);
            this.categoryLabel.TabIndex = 9;
            this.categoryLabel.Text = "Recipe Category";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dishTypeLabel
            // 
            this.dishTypeLabel.AutoSize = true;
            this.dishTypeLabel.Location = new System.Drawing.Point(225, 57);
            this.dishTypeLabel.Name = "dishTypeLabel";
            this.dishTypeLabel.Size = new System.Drawing.Size(55, 13);
            this.dishTypeLabel.TabIndex = 10;
            this.dishTypeLabel.Text = "Dish Type";
            // 
            // IndivRecipeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.dishTypeLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.ingredientListBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.editRecipeButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.backButton);
            this.Name = "IndivRecipeUI";
            this.Text = "IndivRecipeUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button editRecipeButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ListBox ingredientListBox;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label dishTypeLabel;
    }
}