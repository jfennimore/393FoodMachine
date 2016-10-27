namespace _393_Food_Machine
{
    partial class EditRecipe
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.ingredientListBox = new System.Windows.Forms.ListBox();
            this.servingsBox = new System.Windows.Forms.TextBox();
            this.prepTimeBox = new System.Windows.Forms.TextBox();
            this.servingsLabel = new System.Windows.Forms.Label();
            this.prepTimeLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(13, 13);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(425, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(506, 13);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(203, 48);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(156, 20);
            this.title.TabIndex = 3;
            this.title.Text = "Recipe Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(249, 181);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(188, 19);
            this.descriptionLabel.TabIndex = 11;
            this.descriptionLabel.Text = "Preparation Description";
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsLabel.Location = new System.Drawing.Point(80, 70);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(94, 19);
            this.ingredientsLabel.TabIndex = 10;
            this.ingredientsLabel.Text = "Ingredients";
            // 
            // ingredientListBox
            // 
            this.ingredientListBox.FormattingEnabled = true;
            this.ingredientListBox.Location = new System.Drawing.Point(84, 92);
            this.ingredientListBox.Name = "ingredientListBox";
            this.ingredientListBox.Size = new System.Drawing.Size(416, 82);
            this.ingredientListBox.TabIndex = 8;
            // 
            // servingsBox
            // 
            this.servingsBox.Location = new System.Drawing.Point(84, 203);
            this.servingsBox.Name = "servingsBox";
            this.servingsBox.Size = new System.Drawing.Size(100, 20);
            this.servingsBox.TabIndex = 12;
            // 
            // prepTimeBox
            // 
            this.prepTimeBox.Location = new System.Drawing.Point(84, 254);
            this.prepTimeBox.Name = "prepTimeBox";
            this.prepTimeBox.Size = new System.Drawing.Size(100, 20);
            this.prepTimeBox.TabIndex = 13;
            // 
            // servingsLabel
            // 
            this.servingsLabel.AutoSize = true;
            this.servingsLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servingsLabel.Location = new System.Drawing.Point(80, 181);
            this.servingsLabel.Name = "servingsLabel";
            this.servingsLabel.Size = new System.Drawing.Size(76, 19);
            this.servingsLabel.TabIndex = 14;
            this.servingsLabel.Text = "Servings";
            // 
            // prepTimeLabel
            // 
            this.prepTimeLabel.AutoSize = true;
            this.prepTimeLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepTimeLabel.Location = new System.Drawing.Point(80, 232);
            this.prepTimeLabel.Name = "prepTimeLabel";
            this.prepTimeLabel.Size = new System.Drawing.Size(134, 19);
            this.prepTimeLabel.TabIndex = 15;
            this.prepTimeLabel.Text = "Prep Time (min.)";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(253, 203);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(247, 71);
            this.descriptionTextBox.TabIndex = 16;
            this.descriptionTextBox.Text = "";
            // 
            // EditRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.prepTimeLabel);
            this.Controls.Add(this.servingsLabel);
            this.Controls.Add(this.prepTimeBox);
            this.Controls.Add(this.servingsBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.ingredientListBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "EditRecipe";
            this.Text = "Edit Recipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.ListBox ingredientListBox;
        private System.Windows.Forms.TextBox servingsBox;
        private System.Windows.Forms.TextBox prepTimeBox;
        private System.Windows.Forms.Label servingsLabel;
        private System.Windows.Forms.Label prepTimeLabel;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
    }
}