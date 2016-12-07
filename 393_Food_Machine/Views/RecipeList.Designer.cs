namespace _393_Food_Machine
{
    partial class RecipeList
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
            this.recipeFilter = new System.Windows.Forms.ComboBox();
            this.recipeSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recipeListBox = new System.Windows.Forms.ListBox();
            this.newRecipeButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.filterValue = new System.Windows.Forms.TextBox();
            this.filterOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recipeFilter
            // 
            this.recipeFilter.FormattingEnabled = true;
            this.recipeFilter.Items.AddRange(new object[] {
            "Calories",
            "Category",
            "Cost",
            "Ingredient",
            "No Filter"});
            this.recipeFilter.Location = new System.Drawing.Point(51, 40);
            this.recipeFilter.Name = "recipeFilter";
            this.recipeFilter.Size = new System.Drawing.Size(121, 21);
            this.recipeFilter.TabIndex = 0;
            this.recipeFilter.SelectedIndexChanged += new System.EventHandler(this.recipeFilter_SelectedIndexChanged);
            // 
            // recipeSort
            // 
            this.recipeSort.FormattingEnabled = true;
            this.recipeSort.Items.AddRange(new object[] {
            "Category",
            "Recently Added",
            "Oldest",
            "Calories (Low)",
            "Calories (High)",
            "Prep Time (Low)",
            "Prep Time (High)",
            "Number of Servings (Low)",
            "Number of Servings (High)",
            "Number of Ingredients (Low)",
            "Number of Ingredients (High)",
            "Cost (Low)",
            "Cost (High)"});
            this.recipeSort.Location = new System.Drawing.Point(384, 39);
            this.recipeSort.Name = "recipeSort";
            this.recipeSort.Size = new System.Drawing.Size(147, 21);
            this.recipeSort.TabIndex = 1;
            this.recipeSort.SelectedIndexChanged += new System.EventHandler(this.recipeSort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(51, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(381, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sort:";
            // 
            // recipeListBox
            // 
            this.recipeListBox.FormattingEnabled = true;
            this.recipeListBox.Location = new System.Drawing.Point(54, 78);
            this.recipeListBox.Name = "recipeListBox";
            this.recipeListBox.Size = new System.Drawing.Size(477, 173);
            this.recipeListBox.TabIndex = 4;
            this.recipeListBox.SelectedIndexChanged += new System.EventHandler(this.recipeListBox_SelectedIndexChanged);
            // 
            // newRecipeButton
            // 
            this.newRecipeButton.Location = new System.Drawing.Point(185, 256);
            this.newRecipeButton.Name = "newRecipeButton";
            this.newRecipeButton.Size = new System.Drawing.Size(75, 23);
            this.newRecipeButton.TabIndex = 5;
            this.newRecipeButton.Text = "New Recipe";
            this.newRecipeButton.UseVisualStyleBackColor = true;
            this.newRecipeButton.Click += new System.EventHandler(this.newRecipeButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(304, 256);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 6;
            this.importButton.Text = "Import Recipe";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(1, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(81, 23);
            this.backButton.TabIndex = 38;
            this.backButton.Text = "< Home";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // filterValue
            // 
            this.filterValue.Location = new System.Drawing.Point(178, 40);
            this.filterValue.Name = "filterValue";
            this.filterValue.Size = new System.Drawing.Size(48, 20);
            this.filterValue.TabIndex = 39;
            // 
            // filterOK
            // 
            this.filterOK.Location = new System.Drawing.Point(233, 39);
            this.filterOK.Name = "filterOK";
            this.filterOK.Size = new System.Drawing.Size(38, 23);
            this.filterOK.TabIndex = 40;
            this.filterOK.Text = "OK";
            this.filterOK.UseVisualStyleBackColor = true;
            this.filterOK.Click += new System.EventHandler(this.filterOK_Click);
            // 
            // RecipeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.filterOK);
            this.Controls.Add(this.filterValue);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.newRecipeButton);
            this.Controls.Add(this.recipeListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recipeSort);
            this.Controls.Add(this.recipeFilter);
            this.Name = "RecipeList";
            this.Text = "Recipe List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox recipeFilter;
        private System.Windows.Forms.ComboBox recipeSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox recipeListBox;
        private System.Windows.Forms.Button newRecipeButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox filterValue;
        private System.Windows.Forms.Button filterOK;
    }
}

