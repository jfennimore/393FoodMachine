namespace _393_Food_Machine.Views
{
    partial class HomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recipeButton = new System.Windows.Forms.Button();
            this.groceryButton = new System.Windows.Forms.Button();
            this.storeButton = new System.Windows.Forms.Button();
            this.ingredientButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Food Machine";
            // 
            // recipeButton
            // 
            this.recipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeButton.Location = new System.Drawing.Point(193, 94);
            this.recipeButton.Name = "recipeButton";
            this.recipeButton.Size = new System.Drawing.Size(235, 32);
            this.recipeButton.TabIndex = 0;
            this.recipeButton.Text = "Recipes";
            this.recipeButton.UseVisualStyleBackColor = true;
            this.recipeButton.Click += new System.EventHandler(this.recipeButton_Click);
            // 
            // groceryButton
            // 
            this.groceryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groceryButton.Location = new System.Drawing.Point(193, 208);
            this.groceryButton.Name = "groceryButton";
            this.groceryButton.Size = new System.Drawing.Size(235, 32);
            this.groceryButton.TabIndex = 1;
            this.groceryButton.Text = "Grocery Lists";
            this.groceryButton.UseVisualStyleBackColor = true;
            // 
            // storeButton
            // 
            this.storeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeButton.Location = new System.Drawing.Point(193, 170);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new System.Drawing.Size(235, 32);
            this.storeButton.TabIndex = 2;
            this.storeButton.Text = "Stores";
            this.storeButton.UseVisualStyleBackColor = true;
            this.storeButton.Click += new System.EventHandler(this.storeButton_Click);
            // 
            // ingredientButton
            // 
            this.ingredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientButton.Location = new System.Drawing.Point(193, 132);
            this.ingredientButton.Name = "ingredientButton";
            this.ingredientButton.Size = new System.Drawing.Size(235, 32);
            this.ingredientButton.TabIndex = 3;
            this.ingredientButton.Text = "Ingredients";
            this.ingredientButton.UseVisualStyleBackColor = true;
            this.ingredientButton.Click += new System.EventHandler(this.ingredientButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ingredientButton);
            this.Controls.Add(this.storeButton);
            this.Controls.Add(this.groceryButton);
            this.Controls.Add(this.recipeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button recipeButton;
        private System.Windows.Forms.Button groceryButton;
        private System.Windows.Forms.Button storeButton;
        private System.Windows.Forms.Button ingredientButton;
        private System.Windows.Forms.Button button1;
    }
}