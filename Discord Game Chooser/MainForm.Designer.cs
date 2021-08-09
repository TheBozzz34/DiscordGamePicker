namespace Discord_Game_Chooser
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabTextBox = new System.Windows.Forms.TabPage();
            this.tabSaveLoad = new System.Windows.Forms.TabPage();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listFavourites = new System.Windows.Forms.ListBox();
            this.Tabs.SuspendLayout();
            this.tabTextBox.SuspendLayout();
            this.tabSaveLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(6, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(285, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.Location = new System.Drawing.Point(297, 6);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.tabTextBox);
            this.Tabs.Controls.Add(this.tabSaveLoad);
            this.Tabs.Location = new System.Drawing.Point(13, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(386, 232);
            this.Tabs.TabIndex = 2;
            // 
            // tabTextBox
            // 
            this.tabTextBox.Controls.Add(this.txtName);
            this.tabTextBox.Controls.Add(this.btnChange);
            this.tabTextBox.Location = new System.Drawing.Point(4, 22);
            this.tabTextBox.Name = "tabTextBox";
            this.tabTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.tabTextBox.Size = new System.Drawing.Size(378, 206);
            this.tabTextBox.TabIndex = 0;
            this.tabTextBox.Text = "Pick Game";
            this.tabTextBox.UseVisualStyleBackColor = true;
            // 
            // tabSaveLoad
            // 
            this.tabSaveLoad.Controls.Add(this.btnLoad);
            this.tabSaveLoad.Controls.Add(this.btnSave);
            this.tabSaveLoad.Controls.Add(this.listFavourites);
            this.tabSaveLoad.Location = new System.Drawing.Point(4, 22);
            this.tabSaveLoad.Name = "tabSaveLoad";
            this.tabSaveLoad.Padding = new System.Windows.Forms.Padding(3);
            this.tabSaveLoad.Size = new System.Drawing.Size(378, 206);
            this.tabSaveLoad.TabIndex = 1;
            this.tabSaveLoad.Text = "Favourites";
            this.tabSaveLoad.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(297, 37);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(297, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // listFavourites
            // 
            this.listFavourites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFavourites.FormattingEnabled = true;
            this.listFavourites.Location = new System.Drawing.Point(7, 7);
            this.listFavourites.Name = "listFavourites";
            this.listFavourites.Size = new System.Drawing.Size(284, 186);
            this.listFavourites.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 251);
            this.Controls.Add(this.Tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Discord Game Spoofer";
            this.Tabs.ResumeLayout(false);
            this.tabTextBox.ResumeLayout(false);
            this.tabTextBox.PerformLayout();
            this.tabSaveLoad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabTextBox;
        private System.Windows.Forms.TabPage tabSaveLoad;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listFavourites;
    }
}

