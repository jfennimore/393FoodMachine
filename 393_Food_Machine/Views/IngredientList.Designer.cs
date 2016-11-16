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
            this.newIngredientButton = new System.Windows.Forms.Button();
            this.ingredientListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ingredientSort = new System.Windows.Forms.ComboBox();
            this.ingredientFilter = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // newIngredientButton
            // 
            this.newIngredientButton.Location = new System.Drawing.Point(244, 261);
            this.newIngredientButton.Name = "newIngredientButton";
            this.newIngredientButton.Size = new System.Drawing.Size(91, 23);
            this.newIngredientButton.TabIndex = 12;
            this.newIngredientButton.Text = "New Ingredient";
            this.newIngredientButton.UseVisualStyleBackColor = true;
            // 
            // ingredientListBox
            // 
            this.ingredientListBox.FormattingEnabled = true;
            this.ingredientListBox.Location = new System.Drawing.Point(46, 82);
            this.ingredientListBox.Name = "ingredientListBox";
            this.ingredientListBox.Size = new System.Drawing.Size(477, 82);
            this.ingredientListBox.TabIndex = 11;
            this.ingredientListBox.SelectedIndexChanged += new System.EventHandler(this.ingredientListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sort:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filter:";
            // 
            // ingredientSort
            // 
            this.ingredientSort.FormattingEnabled = true;
            this.ingredientSort.Location = new System.Drawing.Point(402, 43);
            this.ingredientSort.Name = "ingredientSort";
            this.ingredientSort.Size = new System.Drawing.Size(121, 21);
            this.ingredientSort.TabIndex = 8;
            // 
            // ingredientFilter
            // 
            this.ingredientFilter.FormattingEnabled = true;
            this.ingredientFilter.Items.AddRange(new object[] {
            "Calories",
            "Category",
            "Cost",
            "Ingredient "});
            this.ingredientFilter.Location = new System.Drawing.Point(43, 44);
            this.ingredientFilter.Name = "ingredientFilter";
            this.ingredientFilter.Size = new System.Drawing.Size(121, 21);
            this.ingredientFilter.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // newIngredientUnit
            // 
            this.newIngredientUnit.FormattingEnabled = true;
            this.newIngredientUnit.Location = new System.Drawing.Point(276, 199);
            this.newIngredientUnit.Name = "newIngredientUnit";
            this.newIngredientUnit.Size = new System.Drawing.Size(73, 21);
            this.newIngredientUnit.TabIndex = 33;
            // 
            // newIngredientCalories
            // 
            this.newIngredientCalories.Location = new System.Drawing.Point(219, 199);
            this.newIngredientCalories.Name = "newIngredientCalories";
            this.newIngredientCalories.Size = new System.Drawing.Size(51, 20);
            this.newIngredientCalories.TabIndex = 32;
            this.newIngredientCalories.Text = "(Calories)";
            // 
            // newIngredientName
            // 
            this.newIngredientName.Location = new System.Drawing.Point(46, 199);
            this.newIngredientName.Name = "newIngredientName";
            this.newIngredientName.Size = new System.Drawing.Size(167, 20);
            this.newIngredientName.TabIndex = 31;
            this.newIngredientName.Text = "(New Ingredient Name)";
            // 
            // editIngredientRemove
            // 
            this.editIngredientRemove.Location = new System.Drawing.Point(497, 168);
            this.editIngredientRemove.Name = "editIngredientRemove";
            this.editIngredientRemove.Size = new System.Drawing.Size(56, 23);
            this.editIngredientRemove.TabIndex = 30;
            this.editIngredientRemove.Text = "Remove";
            this.editIngredientRemove.UseVisualStyleBackColor = true;
            // 
            // editIngredientConfirm
            // 
            this.editIngredientConfirm.Location = new System.Drawing.Point(437, 168);
            this.editIngredientConfirm.Name = "editIngredientConfirm";
            this.editIngredientConfirm.Size = new System.Drawing.Size(54, 23);
            this.editIngredientConfirm.TabIndex = 29;
            this.editIngredientConfirm.Text = "Confirm";
            this.editIngredientConfirm.UseVisualStyleBackColor = true;
            // 
            // editIngredientUnit
            // 
            this.editIngredientUnit.FormattingEnabled = true;
            this.editIngredientUnit.Location = new System.Drawing.Point(276, 170);
            this.editIngredientUnit.Name = "editIngredientUnit";
            this.editIngredientUnit.Size = new System.Drawing.Size(73, 21);
            this.editIngredientUnit.TabIndex = 28;
            // 
            // editIngredientCalories
            // 
            this.editIngredientCalories.Location = new System.Drawing.Point(219, 170);
            this.editIngredientCalories.Name = "editIngredientCalories";
            this.editIngredientCalories.Size = new System.Drawing.Size(51, 20);
            this.editIngredientCalories.TabIndex = 27;
            this.editIngredientCalories.Text = "(Calories)";
            // 
            // editIngredientName
            // 
            this.editIngredientName.Location = new System.Drawing.Point(46, 170);
            this.editIngredientName.Name = "editIngredientName";
            this.editIngredientName.Size = new System.Drawing.Size(167, 20);
            this.editIngredientName.TabIndex = 26;
            this.editIngredientName.Text = "(Existing Ingredient Name)";
            // 
            // editCategoryBox
            // 
            this.editCategoryBox.FormattingEnabled = true;
            this.editCategoryBox.Location = new System.Drawing.Point(356, 170);
            this.editCategoryBox.Name = "editCategoryBox";
            this.editCategoryBox.Size = new System.Drawing.Size(75, 21);
            this.editCategoryBox.TabIndex = 35;
            // 
            // newCategoryBox
            // 
            this.newCategoryBox.FormattingEnabled = true;
            this.newCategoryBox.Location = new System.Drawing.Point(356, 199);
            this.newCategoryBox.Name = "newCategoryBox";
            this.newCategoryBox.Size = new System.Drawing.Size(75, 21);
            this.newCategoryBox.TabIndex = 36;
            // 
            // IngredientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.newCategoryBox);
            this.Controls.Add(this.editCategoryBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newIngredientUnit);
            this.Controls.Add(this.newIngredientCalories);
            this.Controls.Add(this.newIngredientName);
            this.Controls.Add(this.editIngredientRemove);
            this.Controls.Add(this.editIngredientConfirm);
            this.Controls.Add(this.editIngredientUnit);
            this.Controls.Add(this.editIngredientCalories);
            this.Controls.Add(this.editIngredientName);
            this.Controls.Add(this.newIngredientButton);
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

        private System.Windows.Forms.Button newIngredientButton;
        private System.Windows.Forms.ListBox ingredientListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ingredientSort;
        private System.Windows.Forms.ComboBox ingredientFilter;
        private System.Windows.Forms.Button button1;
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
    }
}