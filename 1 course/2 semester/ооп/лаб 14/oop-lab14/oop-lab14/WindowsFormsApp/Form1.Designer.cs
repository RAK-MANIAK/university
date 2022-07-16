namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unZIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptSelectedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptSelectedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.archiveToolStripMenuItem,
            this.encryptionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(380, 36);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 30);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // chooseToolStripMenuItem
            // 
            this.chooseToolStripMenuItem.Name = "chooseToolStripMenuItem";
            this.chooseToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.chooseToolStripMenuItem.Text = "Обрати";
            this.chooseToolStripMenuItem.Click += new System.EventHandler(this.chooseToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.clearToolStripMenuItem.Text = "Очистити";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiveToolStripMenuItem1,
            this.unZIPToolStripMenuItem});
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.archiveToolStripMenuItem.Text = "Архівування";
            // 
            // archiveToolStripMenuItem1
            // 
            this.archiveToolStripMenuItem1.Name = "archiveToolStripMenuItem1";
            this.archiveToolStripMenuItem1.Size = new System.Drawing.Size(218, 30);
            this.archiveToolStripMenuItem1.Text = "ZIP-Архівація";
            this.archiveToolStripMenuItem1.Click += new System.EventHandler(this.archiveToolStripMenuItem1_Click);
            // 
            // unZIPToolStripMenuItem
            // 
            this.unZIPToolStripMenuItem.Name = "unZIPToolStripMenuItem";
            this.unZIPToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.unZIPToolStripMenuItem.Text = "Розархівувати";
            this.unZIPToolStripMenuItem.Click += new System.EventHandler(this.unZIPToolStripMenuItem_Click);
            // 
            // encryptionToolStripMenuItem
            // 
            this.encryptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptSelectedFilesToolStripMenuItem,
            this.decryptSelectedFilesToolStripMenuItem});
            this.encryptionToolStripMenuItem.Name = "encryptionToolStripMenuItem";
            this.encryptionToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.encryptionToolStripMenuItem.Text = "Шифрування";
            // 
            // encryptSelectedFilesToolStripMenuItem
            // 
            this.encryptSelectedFilesToolStripMenuItem.Name = "encryptSelectedFilesToolStripMenuItem";
            this.encryptSelectedFilesToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.encryptSelectedFilesToolStripMenuItem.Text = "Зашифрувати";
            this.encryptSelectedFilesToolStripMenuItem.Click += new System.EventHandler(this.encryptSelectedFilesToolStripMenuItem_Click);
            // 
            // decryptSelectedFilesToolStripMenuItem
            // 
            this.decryptSelectedFilesToolStripMenuItem.Name = "decryptSelectedFilesToolStripMenuItem";
            this.decryptSelectedFilesToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.decryptSelectedFilesToolStripMenuItem.Text = "Розшифрувати";
            this.decryptSelectedFilesToolStripMenuItem.Click += new System.EventHandler(this.decryptSelectedFilesToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.DisplayMember = "Name";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(35, 77);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(301, 179);
            this.listBox1.TabIndex = 1;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxFile_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxFile_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 320);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(432, 413);
            this.MinimumSize = new System.Drawing.Size(396, 359);
            this.Name = "Form1";
            this.Text = "лаб 14 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unZIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptSelectedFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptSelectedFilesToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}

