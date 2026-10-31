namespace TextForge
{
    partial class ForgeForm
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
            this.txtTargetFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWriteHere = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultHere = new System.Windows.Forms.TextBox();
            this.pnlActionBar = new System.Windows.Forms.Panel();
            this.btnForgeNew = new System.Windows.Forms.Button();
            this.btnForgePath = new System.Windows.Forms.Button();
            this.btnForgeName = new System.Windows.Forms.Button();
            this.btnForgeWrite = new System.Windows.Forms.Button();
            this.btnForgeRead = new System.Windows.Forms.Button();
            this.btnForgeLines = new System.Windows.Forms.Button();
            this.btnForgeAll = new System.Windows.Forms.Button();
            this.btnForgeChars = new System.Windows.Forms.Button();
            this.btnForgeAppend = new System.Windows.Forms.Button();
            this.btnForgeDelete = new System.Windows.Forms.Button();
            this.btnForgeClear = new System.Windows.Forms.Button();
            this.pnlActionBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = false;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1040, 60);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Text = "File Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = false;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Name";
            // 
            // txtTargetFile
            // 
            this.txtTargetFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTargetFile.Location = new System.Drawing.Point(25, 104);
            this.txtTargetFile.Name = "txtTargetFile";
            this.txtTargetFile.Size = new System.Drawing.Size(480, 26);
            this.txtTargetFile.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = false;
            this.label3.Location = new System.Drawing.Point(25, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Text";
            // 
            // txtWriteHere
            // 
            this.txtWriteHere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.txtWriteHere.Location = new System.Drawing.Point(25, 172);
            this.txtWriteHere.Multiline = true;
            this.txtWriteHere.Name = "txtWriteHere";
            this.txtWriteHere.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWriteHere.Size = new System.Drawing.Size(480, 262);
            this.txtWriteHere.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = false;
            this.label4.Location = new System.Drawing.Point(535, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(480, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "File Content / Result";
            // 
            // txtResultHere
            // 
            this.txtResultHere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultHere.Location = new System.Drawing.Point(535, 104);
            this.txtResultHere.Multiline = true;
            this.txtResultHere.Name = "txtResultHere";
            this.txtResultHere.ReadOnly = true;
            this.txtResultHere.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultHere.Size = new System.Drawing.Size(480, 330);
            this.txtResultHere.TabIndex = 6;
            // 
            // pnlActionBar
            // 
            this.pnlActionBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActionBar.Location = new System.Drawing.Point(0, 455);
            this.pnlActionBar.Name = "pnlActionBar";
            this.pnlActionBar.Size = new System.Drawing.Size(1040, 195);
            this.pnlActionBar.Controls.Add(this.btnForgeNew);
            this.pnlActionBar.Controls.Add(this.btnForgePath);
            this.pnlActionBar.Controls.Add(this.btnForgeName);
            this.pnlActionBar.Controls.Add(this.btnForgeWrite);
            this.pnlActionBar.Controls.Add(this.btnForgeRead);
            this.pnlActionBar.Controls.Add(this.btnForgeLines);
            this.pnlActionBar.Controls.Add(this.btnForgeAll);
            this.pnlActionBar.Controls.Add(this.btnForgeChars);
            this.pnlActionBar.Controls.Add(this.btnForgeAppend);
            this.pnlActionBar.Controls.Add(this.btnForgeDelete);
            this.pnlActionBar.Controls.Add(this.btnForgeClear);
            // 
            // btnForgeNew
            // 
            this.btnForgeNew.Location = new System.Drawing.Point(25, 20);
            this.btnForgeNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnForgeNew.Name = "btnForgeNew";
            this.btnForgeNew.Size = new System.Drawing.Size(235, 46);
            this.btnForgeNew.TabIndex = 7;
            this.btnForgeNew.Text = "Create File";
            this.btnForgeNew.UseVisualStyleBackColor = true;
            this.btnForgeNew.Click += new System.EventHandler(this.btnForgeNew_Click);
            // 
            // btnForgePath
            // 
            this.btnForgePath.Location = new System.Drawing.Point(275, 20);
            this.btnForgePath.Margin = new System.Windows.Forms.Padding(5);
            this.btnForgePath.Name = "btnForgePath";
            this.btnForgePath.Size = new System.Drawing.Size(235, 46);
            this.btnForgePath.TabIndex = 8;
            this.btnForgePath.Text = "Create New File Path";
            this.btnForgePath.UseVisualStyleBackColor = true;
            this.btnForgePath.Click += new System.EventHandler(this.btnForgePath_Click);
            // 
            // btnForgeName
            // 
            this.btnForgeName.Location = new System.Drawing.Point(525, 20);
            this.btnForgeName.Margin = new System.Windows.Forms.Padding(5);
            this.btnForgeName.Name = "btnForgeName";
            this.btnForgeName.Size = new System.Drawing.Size(235, 46);
            this.btnForgeName.TabIndex = 9;
            this.btnForgeName.Text = "Create New File Name";
            this.btnForgeName.UseVisualStyleBackColor = true;
            this.btnForgeName.Click += new System.EventHandler(this.btnForgeName_Click);
            // 
            // btnForgeWrite
            // 
            this.btnForgeWrite.Location = new System.Drawing.Point(775, 20);
            this.btnForgeWrite.Margin = new System.Windows.Forms.Padding(5);
            this.btnForgeWrite.Name = "btnForgeWrite";
            this.btnForgeWrite.Size = new System.Drawing.Size(235, 46);
            this.btnForgeWrite.TabIndex = 10;
            this.btnForgeWrite.Text = "Write File";
            this.btnForgeWrite.UseVisualStyleBackColor = true;
            this.btnForgeWrite.Click += new System.EventHandler(this.btnForgeWrite_Click);
            // 
            // btnForgeRead
            // 
            this.btnForgeRead.Location = new System.Drawing.Point(25, 76);
            this.btnForgeRead.Margin = new System.Windows.Forms.Padding(5);
            this.btnForgeRead.Name = "btnForgeRead";
            this.btnForgeRead.Size = new System.Drawing.Size(235, 46);
            this.btnForgeRead.TabIndex = 11;
            this.btnForgeRead.Text = "Read File";
            this.btnForgeRead.UseVisualStyleBackColor = true;
            this.btnForgeRead.Click += new System.EventHandler(this.btnForgeRead_Click);
            // 
            // btnForgeLines
            // 
            this.btnForgeLines.Location = new System.Drawing.Point(275, 76);
            this.btnForgeLines.Margin = new System.Windows.Forms.Padding(5);
            this.btnForgeLines.Name = "btnForgeLines";
            this.btnForgeLines.Size = new System.Drawing.Size(235, 46);
            this.btnForgeLines.TabIndex = 12;
            this.btnForgeLines.Text = "Read Using ReadLine()";
            this.btnForgeLines.UseVisualStyleBackColor = true;
            this.btnForgeLines.Click += new System.EventHandler(this.btnForgeLines_Click);
            // 
            // btnForgeAll
            // 
            this.btnForgeAll.Location = new System.Drawing.Point(525, 76);
            this.btnForgeAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnForgeAll.Name = "btnForgeAll";
            this.btnForgeAll.Size = new System.Drawing.Size(235, 46);
            this.btnForgeAll.TabIndex = 13;
            this.btnForgeAll.Text = "Read Using ReadAllText()";
            this.btnForgeAll.UseVisualStyleBackColor = true;
            this.btnForgeAll.Click += new System.EventHandler(this.btnForgeAll_Click);
            // 
            // btnForgeChars
            // 
            this.btnForgeChars.Location = new System.Drawing.Point(775, 76);
            this.btnForgeChars.Margin = new System.Windows.Forms.Padding(5);
            this.btnForgeChars.Name = "btnForgeChars";
            this.btnForgeChars.Size = new System.Drawing.Size(235, 46);
            this.btnForgeChars.TabIndex = 14;
            this.btnForgeChars.Text = "Read() Function";
            this.btnForgeChars.UseVisualStyleBackColor = true;
            this.btnForgeChars.Click += new System.EventHandler(this.btnForgeChars_Click);
            // 
            // btnForgeAppend
            // 
            this.btnForgeAppend.Location = new System.Drawing.Point(25, 132);
            this.btnForgeAppend.Margin = new System.Windows.Forms.Padding(5);
            this.btnForgeAppend.Name = "btnForgeAppend";
            this.btnForgeAppend.Size = new System.Drawing.Size(235, 46);
            this.btnForgeAppend.TabIndex = 15;
            this.btnForgeAppend.Text = "Append File";
            this.btnForgeAppend.UseVisualStyleBackColor = true;
            this.btnForgeAppend.Click += new System.EventHandler(this.btnForgeAppend_Click);
            // 
            // btnForgeDelete
            // 
            this.btnForgeDelete.Location = new System.Drawing.Point(275, 132);
            this.btnForgeDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnForgeDelete.Name = "btnForgeDelete";
            this.btnForgeDelete.Size = new System.Drawing.Size(235, 46);
            this.btnForgeDelete.TabIndex = 16;
            this.btnForgeDelete.Text = "Delete File";
            this.btnForgeDelete.UseVisualStyleBackColor = true;
            this.btnForgeDelete.Click += new System.EventHandler(this.btnForgeDelete_Click);
            // 
            // btnForgeClear
            // 
            this.btnForgeClear.Location = new System.Drawing.Point(525, 132);
            this.btnForgeClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnForgeClear.Name = "btnForgeClear";
            this.btnForgeClear.Size = new System.Drawing.Size(235, 46);
            this.btnForgeClear.TabIndex = 17;
            this.btnForgeClear.Text = "Clear";
            this.btnForgeClear.UseVisualStyleBackColor = true;
            this.btnForgeClear.Click += new System.EventHandler(this.btnForgeClear_Click);
            // 
            // ForgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTargetFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWriteHere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResultHere);
            this.Controls.Add(this.pnlActionBar);
            this.MinimumSize = new System.Drawing.Size(960, 620);
            this.Name = "ForgeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextForge - Create, Write, Read";
            this.pnlActionBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTargetFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWriteHere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultHere;
        private System.Windows.Forms.Panel pnlActionBar;
        private System.Windows.Forms.Button btnForgeNew;
        private System.Windows.Forms.Button btnForgePath;
        private System.Windows.Forms.Button btnForgeName;
        private System.Windows.Forms.Button btnForgeWrite;
        private System.Windows.Forms.Button btnForgeRead;
        private System.Windows.Forms.Button btnForgeLines;
        private System.Windows.Forms.Button btnForgeAll;
        private System.Windows.Forms.Button btnForgeChars;
        private System.Windows.Forms.Button btnForgeAppend;
        private System.Windows.Forms.Button btnForgeDelete;
        private System.Windows.Forms.Button btnForgeClear;
    }
}
