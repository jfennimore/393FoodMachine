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
            this.editIngredientName = new System.Windows.Forms.TextBox();
            this.editIngredientAmount = new System.Windows.Forms.TextBox();
            this.editIngredientUnit = new System.Windows.Forms.ComboBox();
            this.editIngredientConfirm = new System.Windows.Forms.Button();
            this.editIngredientRemove = new System.Windows.Forms.Button();
            this.newIngrButton = new System.Windows.Forms.Button();
            this.newIngredientUnit = new System.Windows.Forms.ComboBox();
            this.newIngredientAmount = new System.Windows.Forms.TextBox();
            this.newIngredientName = new System.Windows.Forms.TextBox();
            this.recipeCategoryBox = new System.Windows.Forms.ComboBox();
            this.dishTypeCombo = new System.Windows.Forms.ComboBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(13, 13);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
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
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(506, 13);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 15;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(202, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(156, 20);
            this.title.TabIndex = 0;
            this.title.Text = "Recipe Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(249, 252);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(188, 19);
            this.descriptionLabel.TabIndex = 19;
            this.descriptionLabel.Text = "Preparation Description";
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsLabel.Location = new System.Drawing.Point(80, 70);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(94, 19);
            this.ingredientsLabel.TabIndex = 20;
            this.ingredientsLabel.Text = "Ingredients";
            // 
            // ingredientListBox
            // 
            this.ingredientListBox.FormattingEnabled = true;
            this.ingredientListBox.Location = new System.Drawing.Point(84, 92);
            this.ingredientListBox.Name = "ingredientListBox";
            this.ingredientListBox.Size = new System.Drawing.Size(416, 82);
            this.ingredientListBox.TabIndex = 18;
            this.ingredientListBox.SelectedIndexChanged += new System.EventHandler(this.ingredientListBox_SelectedIndexChanged);
            // 
            // servingsBox
            // 
            this.servingsBox.Location = new System.Drawing.Point(84, 274);
            this.servingsBox.Name = "servingsBox";
            this.servingsBox.Size = new System.Drawing.Size(100, 20);
            this.servingsBox.TabIndex = 12;
            // 
            // prepTimeBox
            // 
            this.prepTimeBox.Location = new System.Drawing.Point(84, 325);
            this.prepTimeBox.Name = "prepTimeBox";
            this.prepTimeBox.Size = new System.Drawing.Size(100, 20);
            this.prepTimeBox.TabIndex = 13;
            // 
            // servingsLabel
            // 
            this.servingsLabel.AutoSize = true;
            this.servingsLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servingsLabel.Location = new System.Drawing.Point(80, 252);
            this.servingsLabel.Name = "servingsLabel";
            this.servingsLabel.Size = new System.Drawing.Size(76, 19);
            this.servingsLabel.TabIndex = 21;
            this.servingsLabel.Text = "Servings";
            // 
            // prepTimeLabel
            // 
            this.prepTimeLabel.AutoSize = true;
            this.prepTimeLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepTimeLabel.Location = new System.Drawing.Point(80, 303);
            this.prepTimeLabel.Name = "prepTimeLabel";
            this.prepTimeLabel.Size = new System.Drawing.Size(134, 19);
            this.prepTimeLabel.TabIndex = 22;
            this.prepTimeLabel.Text = "Prep Time (min.)";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(253, 274);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(247, 71);
            this.descriptionTextBox.TabIndex = 14;
            this.descriptionTextBox.Text = "";
            // 
            // editIngredientName
            // 
            this.editIngredientName.Location = new System.Drawing.Point(84, 189);
            this.editIngredientName.Name = "editIngredientName";
            this.editIngredientName.Size = new System.Drawing.Size(167, 20);
            this.editIngredientName.TabIndex = 7;
            this.editIngredientName.Text = "(Existing Ingredient Name)";
            // 
            // editIngredientAmount
            // 
            this.editIngredientAmount.Location = new System.Drawing.Point(268, 188);
            this.editIngredientAmount.Name = "editIngredientAmount";
            this.editIngredientAmount.Size = new System.Drawing.Size(51, 20);
            this.editIngredientAmount.TabIndex = 8;
            this.editIngredientAmount.Text = "(Amount)";
            // 
            // editIngredientUnit
            // 
            this.editIngredientUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.editIngredientUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.editIngredientUnit.FormattingEnabled = true;
            this.editIngredientUnit.Location = new System.Drawing.Point(334, 188);
            this.editIngredientUnit.Name = "editIngredientUnit";
            this.editIngredientUnit.Size = new System.Drawing.Size(73, 21);
            this.editIngredientUnit.TabIndex = 9;
            // 
            // editIngredientConfirm
            // 
            this.editIngredientConfirm.Location = new System.Drawing.Point(413, 187);
            this.editIngredientConfirm.Name = "editIngredientConfirm";
            this.editIngredientConfirm.Size = new System.Drawing.Size(75, 23);
            this.editIngredientConfirm.TabIndex = 10;
            this.editIngredientConfirm.Text = "Confirm";
            this.editIngredientConfirm.UseVisualStyleBackColor = true;
            this.editIngredientConfirm.Click += new System.EventHandler(this.editIngredientConfirm_Click);
            // 
            // editIngredientRemove
            // 
            this.editIngredientRemove.Location = new System.Drawing.Point(494, 187);
            this.editIngredientRemove.Name = "editIngredientRemove";
            this.editIngredientRemove.Size = new System.Drawing.Size(75, 23);
            this.editIngredientRemove.TabIndex = 11;
            this.editIngredientRemove.Text = "Remove";
            this.editIngredientRemove.UseVisualStyleBackColor = true;
            this.editIngredientRemove.Click += new System.EventHandler(this.editIngredientRemove_Click);
            // 
            // newIngrButton
            // 
            this.newIngrButton.Location = new System.Drawing.Point(413, 216);
            this.newIngrButton.Name = "newIngrButton";
            this.newIngrButton.Size = new System.Drawing.Size(75, 23);
            this.newIngrButton.TabIndex = 6;
            this.newIngrButton.Text = "Add New";
            this.newIngrButton.UseVisualStyleBackColor = true;
            this.newIngrButton.Click += new System.EventHandler(this.newIngrButton_Click);
            // 
            // newIngredientUnit
            // 
            this.newIngredientUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.newIngredientUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.newIngredientUnit.FormattingEnabled = true;
            this.newIngredientUnit.Location = new System.Drawing.Point(334, 217);
            this.newIngredientUnit.Name = "newIngredientUnit";
            this.newIngredientUnit.Size = new System.Drawing.Size(73, 21);
            this.newIngredientUnit.TabIndex = 5;
            // 
            // newIngredientAmount
            // 
            this.newIngredientAmount.Location = new System.Drawing.Point(268, 217);
            this.newIngredientAmount.Name = "newIngredientAmount";
            this.newIngredientAmount.Size = new System.Drawing.Size(51, 20);
            this.newIngredientAmount.TabIndex = 4;
            this.newIngredientAmount.Text = "(Amount)";
            // 
            // newIngredientName
            // 
            this.newIngredientName.Location = new System.Drawing.Point(84, 218);
            this.newIngredientName.Name = "newIngredientName";
            this.newIngredientName.Size = new System.Drawing.Size(167, 20);
            this.newIngredientName.TabIndex = 3;
            this.newIngredientName.Text = "(New Ingredient Name)";
            // 
            // recipeCategoryBox
            // 
            this.recipeCategoryBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.recipeCategoryBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.recipeCategoryBox.FormattingEnabled = true;
            this.recipeCategoryBox.Location = new System.Drawing.Point(202, 39);
            this.recipeCategoryBox.Name = "recipeCategoryBox";
            this.recipeCategoryBox.Size = new System.Drawing.Size(156, 21);
            this.recipeCategoryBox.TabIndex = 1;
            // 
            // dishTypeCombo
            // 
            this.dishTypeCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dishTypeCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dishTypeCombo.FormattingEnabled = true;
            this.dishTypeCombo.Location = new System.Drawing.Point(202, 66);
            this.dishTypeCombo.Name = "dishTypeCombo";
            this.dishTypeCombo.Size = new System.Drawing.Size(156, 21);
            this.dishTypeCombo.TabIndex = 2;
            this.dishTypeCombo.Text = "<Let us guess Dish Type!>";
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(37, 218);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(41, 21);
            this.browseButton.TabIndex = 23;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // EditRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 370);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.dishTypeCombo);
            this.Controls.Add(this.recipeCategoryBox);
            this.Controls.Add(this.newIngrButton);
            this.Controls.Add(this.newIngredientUnit);
            this.Controls.Add(this.newIngredientAmount);
            this.Controls.Add(this.newIngredientName);
            this.Controls.Add(this.editIngredientRemove);
            this.Controls.Add(this.editIngredientConfirm);
            this.Controls.Add(this.editIngredientUnit);
            this.Controls.Add(this.editIngredientAmount);
            this.Controls.Add(this.editIngredientName);
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
        private System.Windows.Forms.TextBox editIngredientName;
        private System.Windows.Forms.TextBox editIngredientAmount;
        private System.Windows.Forms.ComboBox editIngredientUnit;
        private System.Windows.Forms.Button editIngredientConfirm;
        private System.Windows.Forms.Button editIngredientRemove;
        private System.Windows.Forms.Button newIngrButton;
        private System.Windows.Forms.ComboBox newIngredientUnit;
        private System.Windows.Forms.TextBox newIngredientAmount;
        private System.Windows.Forms.TextBox newIngredientName;
        private System.Windows.Forms.ComboBox recipeCategoryBox;
        private System.Windows.Forms.ComboBox dishTypeCombo;
        private System.Windows.Forms.Button browseButton;
    }
}