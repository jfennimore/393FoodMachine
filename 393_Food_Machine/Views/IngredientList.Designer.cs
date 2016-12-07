namespace _393_Food_Machine.Views
{
    partial class IngredientList
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
            this.ingredientListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ingredientSort = new System.Windows.Forms.ComboBox();
            this.ingredientFilter = new System.Windows.Forms.ComboBox();
            this.newIngrButton = new System.Windows.Forms.Button();
            this.newIngredientUnit = new System.Windows.Forms.ComboBox();
            this.newIngredientCalories = new System.Windows.Forms.TextBox();
            this.newIngredientName = new System.Windows.Forms.TextBox();
            this.editIngredientRemove = new System.Windows.Forms.Button();
            this.editIngredientConfirm = new System.Windows.Forms.Button();
            this.editIngredientUnit = new System.Windows.Forms.ComboBox();
            this.editIngredientCalories = new System.Windows.Forms.TextBox();
            this.editIngredientName = new System.Windows.Forms.TextBox();
            this.editCategoryBox = new System.Windows.Forms.ComboBox();
            this.newCategoryBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.filterOK = new System.Windows.Forms.Button();
            this.filterValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ingredientListBox
            // 
            this.ingredientListBox.FormattingEnabled = true;
            this.ingredientListBox.Location = new System.Drawing.Point(46, 82);
            this.ingredientListBox.Name = "ingredientListBox";
            this.ingredientListBox.Size = new System.Drawing.Size(477, 82);
            this.ingredientListBox.TabIndex = 16;
            this.ingredientListBox.SelectedIndexChanged += new System.EventHandler(this.ingredientListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sort:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filter:";
            // 
            // ingredientSort
            // 
            this.ingredientSort.FormattingEnabled = true;
            this.ingredientSort.Items.AddRange(new object[] {
            "Alphabetical",
            "Category",
            "Calories (Low)",
            "Calories (High)",
            "No Sort"});
            this.ingredientSort.Location = new System.Drawing.Point(402, 43);
            this.ingredientSort.Name = "ingredientSort";
            this.ingredientSort.Size = new System.Drawing.Size(121, 21);
            this.ingredientSort.TabIndex = 12;
            this.ingredientSort.SelectedIndexChanged += new System.EventHandler(this.ingredientSort_SelectedIndexChanged);
            // 
            // ingredientFilter
            // 
            this.ingredientFilter.FormattingEnabled = true;
            this.ingredientFilter.Items.AddRange(new object[] {
            "Calories",
            "Category",
            "Search",
            "No Filter"});
            this.ingredientFilter.Location = new System.Drawing.Point(43, 44);
            this.ingredientFilter.Name = "ingredientFilter";
            this.ingredientFilter.Size = new System.Drawing.Size(121, 21);
            this.ingredientFilter.TabIndex = 11;
            this.ingredientFilter.SelectedIndexChanged += new System.EventHandler(this.ingredientFilter_SelectedIndexChanged);
            // 
            // newIngrButton
            // 
            this.newIngrButton.Location = new System.Drawing.Point(437, 219);
            this.newIngrButton.Name = "newIngrButton";
            this.newIngrButton.Size = new System.Drawing.Size(67, 23);
            this.newIngrButton.TabIndex = 10;
            this.newIngrButton.Text = "Add New";
            this.newIngrButton.UseVisualStyleBackColor = true;
            this.newIngrButton.Click += new System.EventHandler(this.newIngrButton_Click);
            // 
            // newIngredientUnit
            // 
            this.newIngredientUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.newIngredientUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.newIngredientUnit.FormattingEnabled = true;
            this.newIngredientUnit.Location = new System.Drawing.Point(276, 221);
            this.newIngredientUnit.Name = "newIngredientUnit";
            this.newIngredientUnit.Size = new System.Drawing.Size(73, 21);
            this.newIngredientUnit.TabIndex = 8;
            // 
            // newIngredientCalories
            // 
            this.newIngredientCalories.Location = new System.Drawing.Point(219, 221);
            this.newIngredientCalories.Name = "newIngredientCalories";
            this.newIngredientCalories.Size = new System.Drawing.Size(51, 20);
            this.newIngredientCalories.TabIndex = 7;
            this.newIngredientCalories.Text = "(Calories)";
            // 
            // newIngredientName
            // 
            this.newIngredientName.Location = new System.Drawing.Point(46, 221);
            this.newIngredientName.Name = "newIngredientName";
            this.newIngredientName.Size = new System.Drawing.Size(167, 20);
            this.newIngredientName.TabIndex = 6;
            this.newIngredientName.Text = "(New Ingredient Name)";
            // 
            // editIngredientRemove
            // 
            this.editIngredientRemove.Location = new System.Drawing.Point(497, 190);
            this.editIngredientRemove.Name = "editIngredientRemove";
            this.editIngredientRemove.Size = new System.Drawing.Size(56, 23);
            this.editIngredientRemove.TabIndex = 5;
            this.editIngredientRemove.Text = "Remove";
            this.editIngredientRemove.UseVisualStyleBackColor = true;
            this.editIngredientRemove.Click += new System.EventHandler(this.editIngredientRemove_Click);
            // 
            // editIngredientConfirm
            // 
            this.editIngredientConfirm.Location = new System.Drawing.Point(437, 190);
            this.editIngredientConfirm.Name = "editIngredientConfirm";
            this.editIngredientConfirm.Size = new System.Drawing.Size(54, 23);
            this.editIngredientConfirm.TabIndex = 4;
            this.editIngredientConfirm.Text = "Confirm";
            this.editIngredientConfirm.UseVisualStyleBackColor = true;
            this.editIngredientConfirm.Click += new System.EventHandler(this.editIngredientConfirm_Click);
            // 
            // editIngredientUnit
            // 
            this.editIngredientUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.editIngredientUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.editIngredientUnit.FormattingEnabled = true;
            this.editIngredientUnit.Location = new System.Drawing.Point(276, 192);
            this.editIngredientUnit.Name = "editIngredientUnit";
            this.editIngredientUnit.Size = new System.Drawing.Size(73, 21);
            this.editIngredientUnit.TabIndex = 2;
            // 
            // editIngredientCalories
            // 
            this.editIngredientCalories.Location = new System.Drawing.Point(219, 192);
            this.editIngredientCalories.Name = "editIngredientCalories";
            this.editIngredientCalories.Size = new System.Drawing.Size(51, 20);
            this.editIngredientCalories.TabIndex = 1;
            this.editIngredientCalories.Text = "(Calories)";
            // 
            // editIngredientName
            // 
            this.editIngredientName.Location = new System.Drawing.Point(46, 192);
            this.editIngredientName.Name = "editIngredientName";
            this.editIngredientName.Size = new System.Drawing.Size(167, 20);
            this.editIngredientName.TabIndex = 0;
            this.editIngredientName.Text = "(Existing Ingredient Name)";
            // 
            // editCategoryBox
            // 
            this.editCategoryBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.editCategoryBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.editCategoryBox.FormattingEnabled = true;
            this.editCategoryBox.Location = new System.Drawing.Point(356, 192);
            this.editCategoryBox.Name = "editCategoryBox";
            this.editCategoryBox.Size = new System.Drawing.Size(75, 21);
            this.editCategoryBox.TabIndex = 3;
            // 
            // newCategoryBox
            // 
            this.newCategoryBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.newCategoryBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.newCategoryBox.FormattingEnabled = true;
            this.newCategoryBox.Location = new System.Drawing.Point(356, 221);
            this.newCategoryBox.Name = "newCategoryBox";
            this.newCategoryBox.Size = new System.Drawing.Size(75, 21);
            this.newCategoryBox.TabIndex = 9;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(3, 1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(81, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "< Home";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // filterOK
            // 
            this.filterOK.Location = new System.Drawing.Point(225, 44);
            this.filterOK.Name = "filterOK";
            this.filterOK.Size = new System.Drawing.Size(38, 23);
            this.filterOK.TabIndex = 42;
            this.filterOK.Text = "OK";
            this.filterOK.UseVisualStyleBackColor = true;
            this.filterOK.Click += new System.EventHandler(this.filterOK_Click);
            // 
            // filterValue
            // 
            this.filterValue.Location = new System.Drawing.Point(170, 45);
            this.filterValue.Name = "filterValue";
            this.filterValue.Size = new System.Drawing.Size(48, 20);
            this.filterValue.TabIndex = 41;
            // 
            // IngredientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.filterOK);
            this.Controls.Add(this.filterValue);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.newCategoryBox);
            this.Controls.Add(this.editCategoryBox);
            this.Controls.Add(this.newIngrButton);
            this.Controls.Add(this.newIngredientUnit);
            this.Controls.Add(this.newIngredientCalories);
            this.Controls.Add(this.newIngredientName);
            this.Controls.Add(this.editIngredientRemove);
            this.Controls.Add(this.editIngredientConfirm);
            this.Controls.Add(this.editIngredientUnit);
            this.Controls.Add(this.editIngredientCalories);
            this.Controls.Add(this.editIngredientName);
            this.Controls.Add(this.ingredientListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingredientSort);
            this.Controls.Add(this.ingredientFilter);
            this.Name = "IngredientList";
            this.Text = "IngredientList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ingredientListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ingredientSort;
        private System.Windows.Forms.ComboBox ingredientFilter;
        private System.Windows.Forms.Button newIngrButton;
        private System.Windows.Forms.ComboBox newIngredientUnit;
        private System.Windows.Forms.TextBox newIngredientCalories;
        private System.Windows.Forms.TextBox newIngredientName;
        private System.Windows.Forms.Button editIngredientRemove;
        private System.Windows.Forms.Button editIngredientConfirm;
        private System.Windows.Forms.ComboBox editIngredientUnit;
        private System.Windows.Forms.TextBox editIngredientCalories;
        private System.Windows.Forms.TextBox editIngredientName;
        private System.Windows.Forms.ComboBox editCategoryBox;
        private System.Windows.Forms.ComboBox newCategoryBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button filterOK;
        private System.Windows.Forms.TextBox filterValue;
    }
}