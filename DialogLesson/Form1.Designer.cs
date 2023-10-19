namespace DialogLesson
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changeColorBtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.changeFontBtn = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFolderBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(170, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Second Label";
            // 
            // changeColorBtn
            // 
            this.changeColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeColorBtn.Location = new System.Drawing.Point(12, 89);
            this.changeColorBtn.Name = "changeColorBtn";
            this.changeColorBtn.Size = new System.Drawing.Size(174, 37);
            this.changeColorBtn.TabIndex = 1;
            this.changeColorBtn.Text = "Change Color";
            this.changeColorBtn.UseVisualStyleBackColor = true;
            this.changeColorBtn.Click += new System.EventHandler(this.changeColorBtn_Click);
            // 
            // changeFontBtn
            // 
            this.changeFontBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeFontBtn.Location = new System.Drawing.Point(203, 89);
            this.changeFontBtn.Name = "changeFontBtn";
            this.changeFontBtn.Size = new System.Drawing.Size(174, 37);
            this.changeFontBtn.TabIndex = 1;
            this.changeFontBtn.Text = "Change Font";
            this.changeFontBtn.UseVisualStyleBackColor = true;
            this.changeFontBtn.Click += new System.EventHandler(this.changeFontBtn_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontDialog1.MaxSize = 20;
            this.fontDialog1.ShowColor = true;
            // 
            // openFolderBtn
            // 
            this.openFolderBtn.AutoSize = true;
            this.openFolderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFolderBtn.Location = new System.Drawing.Point(392, 89);
            this.openFolderBtn.Name = "openFolderBtn";
            this.openFolderBtn.Size = new System.Drawing.Size(181, 37);
            this.openFolderBtn.TabIndex = 1;
            this.openFolderBtn.Text = "Browser Folder";
            this.openFolderBtn.UseVisualStyleBackColor = true;
            this.openFolderBtn.Click += new System.EventHandler(this.openFolderBtn_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 132);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(404, 236);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // openBtn
            // 
            this.openBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openBtn.Location = new System.Drawing.Point(17, 374);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(174, 37);
            this.openBtn.TabIndex = 1;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(247, 374);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(174, 37);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.openFolderBtn);
            this.Controls.Add(this.changeFontBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.changeColorBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeColorBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button changeFontBtn;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button openFolderBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}

