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
            this.ingredientListBox.Size = new System.Drawing.Size(477, 173);
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
            // IngredientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
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
    }
}