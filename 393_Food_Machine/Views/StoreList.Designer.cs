namespace _393_Food_Machine.Views
{
    partial class StoreList
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
            this.storeListBox = new System.Windows.Forms.ListBox();
            this.newStoreButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // storeListBox
            // 
            this.storeListBox.FormattingEnabled = true;
            this.storeListBox.Location = new System.Drawing.Point(44, 39);
            this.storeListBox.Name = "storeListBox";
            this.storeListBox.Size = new System.Drawing.Size(191, 173);
            this.storeListBox.TabIndex = 0;
            this.storeListBox.SelectedIndexChanged += new System.EventHandler(this.storeListBox_SelectedIndexChanged);
            // 
            // newStoreButton
            // 
            this.newStoreButton.Location = new System.Drawing.Point(101, 218);
            this.newStoreButton.Name = "newStoreButton";
            this.newStoreButton.Size = new System.Drawing.Size(75, 23);
            this.newStoreButton.TabIndex = 1;
            this.newStoreButton.Text = "New Store";
            this.newStoreButton.UseVisualStyleBackColor = true;
            this.newStoreButton.Click += new System.EventHandler(this.newStoreButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 10);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "< Home";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // StoreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.newStoreButton);
            this.Controls.Add(this.storeListBox);
            this.Name = "StoreList";
            this.Text = "Stores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox storeListBox;
        private System.Windows.Forms.Button newStoreButton;
        private System.Windows.Forms.Button backButton;
    }
}