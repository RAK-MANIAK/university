namespace Arrays1DWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.count1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.defolt = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.count2 = new System.Windows.Forms.NumericUpDown();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.newm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.count1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість елементів:";
            // 
            // count1
            // 
            this.count1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count1.Location = new System.Drawing.Point(199, 24);
            this.count1.Name = "count1";
            this.count1.Size = new System.Drawing.Size(66, 29);
            this.count1.TabIndex = 1;
            this.count1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.count1.ValueChanged += new System.EventHandler(this.count1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(284, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Генерувати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // defolt
            // 
            this.defolt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.defolt.Location = new System.Drawing.Point(27, 122);
            this.defolt.Name = "defolt";
            this.defolt.RowTemplate.Height = 25;
            this.defolt.Size = new System.Drawing.Size(544, 63);
            this.defolt.TabIndex = 3;
            this.defolt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.defolt_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(42, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сума додатніх чисел, з парним індексом : ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(383, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Розв\'язати";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sum.Location = new System.Drawing.Point(405, 298);
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            this.sum.Size = new System.Drawing.Size(166, 29);
            this.sum.TabIndex = 6;
            this.sum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кількість елементів сортування, з кінця:";
            // 
            // count2
            // 
            this.count2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count2.Location = new System.Drawing.Point(355, 72);
            this.count2.Name = "count2";
            this.count2.Size = new System.Drawing.Size(63, 29);
            this.count2.TabIndex = 8;
            this.count2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(429, 347);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(151, 15);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Маньківський В.В. ВТ-21-1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // newm
            // 
            this.newm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newm.Location = new System.Drawing.Point(27, 204);
            this.newm.Name = "newm";
            this.newm.RowTemplate.Height = 25;
            this.newm.Size = new System.Drawing.Size(544, 63);
            this.newm.TabIndex = 10;
            this.newm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.newm_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arrays1DWinForms.Properties.Resources._91dc1964120315_5ac77335ae374;
            this.ClientSize = new System.Drawing.Size(592, 371);
            this.Controls.Add(this.newm);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.count2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.defolt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.count1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(608, 410);
            this.MinimumSize = new System.Drawing.Size(608, 410);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №4. Завдання 1";
            ((System.ComponentModel.ISupportInitialize)(this.count1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown count1;
        private Button button1;
        private DataGridView defolt;
        private Label label2;
        private Button button2;
        private TextBox sum;
        private Label label3;
        private NumericUpDown count2;
        private LinkLabel linkLabel1;
        private DataGridView newm;
    }
}