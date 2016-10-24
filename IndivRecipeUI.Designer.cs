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
            this.descriptionListBox = new System.Windows.Forms.ListBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
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
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(412, 13);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // editRecipeButton
            // 
            this.editRecipeButton.Location = new System.Drawing.Point(493, 13);
            this.editRecipeButton.Name = "editRecipeButton";
            this.editRecipeButton.Size = new System.Drawing.Size(75, 23);
            this.editRecipeButton.TabIndex = 2;
            this.editRecipeButton.Text = "Edit Recipe";
            this.editRecipeButton.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(202, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(138, 27);
            this.title.TabIndex = 3;
            this.title.Text = "Recipe Title";
            // 
            // ingredientListBox
            // 
            this.ingredientListBox.FormattingEnabled = true;
            this.ingredientListBox.Location = new System.Drawing.Point(71, 79);
            this.ingredientListBox.Name = "ingredientListBox";
            this.ingredientListBox.Size = new System.Drawing.Size(416, 82);
            this.ingredientListBox.TabIndex = 4;
            // 
            // descriptionListBox
            // 
            this.descriptionListBox.FormattingEnabled = true;
            this.descriptionListBox.Location = new System.Drawing.Point(71, 190);
            this.descriptionListBox.Name = "descriptionListBox";
            this.descriptionListBox.Size = new System.Drawing.Size(416, 95);
            this.descriptionListBox.TabIndex = 5;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsLabel.Location = new System.Drawing.Point(67, 57);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(94, 19);
            this.ingredientsLabel.TabIndex = 6;
            this.ingredientsLabel.Text = "Ingredients";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(67, 168);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(188, 19);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Preparation Description";
            // 
            // IndivRecipeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 297);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.descriptionListBox);
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
        private System.Windows.Forms.ListBox descriptionListBox;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Label descriptionLabel;
    }
}