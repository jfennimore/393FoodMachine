namespace _393_Food_Machine.Views
{
    partial class EditStore
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
            this.newIngrButton = new System.Windows.Forms.Button();
            this.newIngredientPrice = new System.Windows.Forms.TextBox();
            this.newIngredientName = new System.Windows.Forms.TextBox();
            this.editIngredientRemove = new System.Windows.Forms.Button();
            this.editIngredientConfirm = new System.Windows.Forms.Button();
            this.editIngredientPrice = new System.Windows.Forms.TextBox();
            this.editIngredientName = new System.Windows.Forms.TextBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.ingredientListBox = new System.Windows.Forms.ListBox();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "< Home";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // newIngrButton
            // 
            this.newIngrButton.Location = new System.Drawing.Point(337, 198);
            this.newIngrButton.Name = "newIngrButton";
            this.newIngrButton.Size = new System.Drawing.Size(75, 23);
            this.newIngrButton.TabIndex = 37;
            this.newIngrButton.Text = "Add New";
            this.newIngrButton.UseVisualStyleBackColor = true;
            this.newIngrButton.Click += new System.EventHandler(this.newIngrButton_Click);
            // 
            // newIngredientPrice
            // 
            this.newIngredientPrice.Location = new System.Drawing.Point(270, 199);
            this.newIngredientPrice.Name = "newIngredientPrice";
            this.newIngredientPrice.Size = new System.Drawing.Size(51, 20);
            this.newIngredientPrice.TabIndex = 35;
            this.newIngredientPrice.Text = "(Price)";
            // 
            // newIngredientName
            // 
            this.newIngredientName.Location = new System.Drawing.Point(86, 200);
            this.newIngredientName.Name = "newIngredientName";
            this.newIngredientName.Size = new System.Drawing.Size(167, 20);
            this.newIngredientName.TabIndex = 34;
            this.newIngredientName.Text = "(New Ingredient Name)";
            // 
            // editIngredientRemove
            // 
            this.editIngredientRemove.Location = new System.Drawing.Point(418, 169);
            this.editIngredientRemove.Name = "editIngredientRemove";
            this.editIngredientRemove.Size = new System.Drawing.Size(75, 23);
            this.editIngredientRemove.TabIndex = 33;
            this.editIngredientRemove.Text = "Remove";
            this.editIngredientRemove.UseVisualStyleBackColor = true;
            this.editIngredientRemove.Click += new System.EventHandler(this.editIngredientRemove_Click);
            // 
            // editIngredientConfirm
            // 
            this.editIngredientConfirm.Location = new System.Drawing.Point(337, 169);
            this.editIngredientConfirm.Name = "editIngredientConfirm";
            this.editIngredientConfirm.Size = new System.Drawing.Size(75, 23);
            this.editIngredientConfirm.TabIndex = 32;
            this.editIngredientConfirm.Text = "Confirm";
            this.editIngredientConfirm.UseVisualStyleBackColor = true;
            this.editIngredientConfirm.Click += new System.EventHandler(this.editIngredientConfirm_Click);
            // 
            // editIngredientPrice
            // 
            this.editIngredientPrice.Location = new System.Drawing.Point(270, 170);
            this.editIngredientPrice.Name = "editIngredientPrice";
            this.editIngredientPrice.Size = new System.Drawing.Size(51, 20);
            this.editIngredientPrice.TabIndex = 30;
            this.editIngredientPrice.Text = "(Price)";
            // 
            // editIngredientName
            // 
            this.editIngredientName.Location = new System.Drawing.Point(86, 171);
            this.editIngredientName.Name = "editIngredientName";
            this.editIngredientName.Size = new System.Drawing.Size(167, 20);
            this.editIngredientName.TabIndex = 29;
            this.editIngredientName.Text = "(Existing Ingredient Name)";
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsLabel.Location = new System.Drawing.Point(82, 52);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(138, 19);
            this.ingredientsLabel.TabIndex = 28;
            this.ingredientsLabel.Text = "Ingredient Prices";
            // 
            // ingredientListBox
            // 
            this.ingredientListBox.FormattingEnabled = true;
            this.ingredientListBox.Location = new System.Drawing.Point(86, 74);
            this.ingredientListBox.Name = "ingredientListBox";
            this.ingredientListBox.Size = new System.Drawing.Size(416, 82);
            this.ingredientListBox.TabIndex = 27;
            this.ingredientListBox.SelectedIndexChanged += new System.EventHandler(this.ingredientListBox_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(237, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(110, 24);
            this.title.TabIndex = 38;
            this.title.Text = "Store Name";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.title);
            this.Controls.Add(this.newIngrButton);
            this.Controls.Add(this.newIngredientPrice);
            this.Controls.Add(this.newIngredientName);
            this.Controls.Add(this.editIngredientRemove);
            this.Controls.Add(this.editIngredientConfirm);
            this.Controls.Add(this.editIngredientPrice);
            this.Controls.Add(this.editIngredientName);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.ingredientListBox);
            this.Controls.Add(this.backButton);
            this.Name = "EditStore";
            this.Text = "EditStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button newIngrButton;
        private System.Windows.Forms.TextBox newIngredientPrice;
        private System.Windows.Forms.TextBox newIngredientName;
        private System.Windows.Forms.Button editIngredientRemove;
        private System.Windows.Forms.Button editIngredientConfirm;
        private System.Windows.Forms.TextBox editIngredientPrice;
        private System.Windows.Forms.TextBox editIngredientName;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.ListBox ingredientListBox;
        private System.Windows.Forms.Label title;
    }
}