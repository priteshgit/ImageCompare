namespace ImageComparer
{
    partial class FormImageComparer
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxImage1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxImage2 = new System.Windows.Forms.PictureBox();
            this.textBoxFolder1 = new System.Windows.Forms.TextBox();
            this.textBoxFolder2 = new System.Windows.Forms.TextBox();
            this.LabelFolder2 = new System.Windows.Forms.Label();
            this.LabelFolder1 = new System.Windows.Forms.Label();
            this.labelImage1 = new System.Windows.Forms.Label();
            this.labelImage2 = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxSuffix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 75);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxImage1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxImage2);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 445);
            this.splitContainer1.SplitterDistance = 575;
            this.splitContainer1.TabIndex = 1;
            // 
            // pictureBoxImage1
            // 
            this.pictureBoxImage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImage1.Name = "pictureBoxImage1";
            this.pictureBoxImage1.Size = new System.Drawing.Size(575, 445);
            this.pictureBoxImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage1.TabIndex = 0;
            this.pictureBoxImage1.TabStop = false;
            // 
            // pictureBoxImage2
            // 
            this.pictureBoxImage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage2.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImage2.Name = "pictureBoxImage2";
            this.pictureBoxImage2.Size = new System.Drawing.Size(521, 445);
            this.pictureBoxImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage2.TabIndex = 0;
            this.pictureBoxImage2.TabStop = false;
            // 
            // textBoxFolder1
            // 
            this.textBoxFolder1.Location = new System.Drawing.Point(85, 7);
            this.textBoxFolder1.Name = "textBoxFolder1";
            this.textBoxFolder1.Size = new System.Drawing.Size(323, 20);
            this.textBoxFolder1.TabIndex = 2;
            // 
            // textBoxFolder2
            // 
            this.textBoxFolder2.Location = new System.Drawing.Point(621, 5);
            this.textBoxFolder2.Name = "textBoxFolder2";
            this.textBoxFolder2.Size = new System.Drawing.Size(304, 20);
            this.textBoxFolder2.TabIndex = 3;
            // 
            // LabelFolder2
            // 
            this.LabelFolder2.AutoSize = true;
            this.LabelFolder2.Location = new System.Drawing.Point(573, 12);
            this.LabelFolder2.Name = "LabelFolder2";
            this.LabelFolder2.Size = new System.Drawing.Size(45, 13);
            this.LabelFolder2.TabIndex = 4;
            this.LabelFolder2.Text = "Folder 2";
            // 
            // LabelFolder1
            // 
            this.LabelFolder1.AutoSize = true;
            this.LabelFolder1.Location = new System.Drawing.Point(36, 12);
            this.LabelFolder1.Name = "LabelFolder1";
            this.LabelFolder1.Size = new System.Drawing.Size(45, 13);
            this.LabelFolder1.TabIndex = 4;
            this.LabelFolder1.Text = "Folder 1";
            // 
            // labelImage1
            // 
            this.labelImage1.AutoSize = true;
            this.labelImage1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImage1.Location = new System.Drawing.Point(36, 49);
            this.labelImage1.Name = "labelImage1";
            this.labelImage1.Size = new System.Drawing.Size(296, 23);
            this.labelImage1.TabIndex = 5;
            this.labelImage1.Text = "Image Name from folder 1";
            // 
            // labelImage2
            // 
            this.labelImage2.AutoSize = true;
            this.labelImage2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImage2.Location = new System.Drawing.Point(587, 49);
            this.labelImage2.Name = "labelImage2";
            this.labelImage2.Size = new System.Drawing.Size(296, 23);
            this.labelImage2.TabIndex = 5;
            this.labelImage2.Text = "Image Name from folder 2";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(433, 28);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 6;
            this.buttonPrevious.Text = "< Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(525, 28);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next >";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(471, -1);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxSuffix
            // 
            this.textBoxSuffix.Location = new System.Drawing.Point(818, 30);
            this.textBoxSuffix.Name = "textBoxSuffix";
            this.textBoxSuffix.Size = new System.Drawing.Size(106, 20);
            this.textBoxSuffix.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(767, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Suffix";
            // 
            // FormImageComparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1113, 532);
            this.Controls.Add(this.textBoxSuffix);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.labelImage2);
            this.Controls.Add(this.labelImage1);
            this.Controls.Add(this.LabelFolder1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelFolder2);
            this.Controls.Add(this.textBoxFolder2);
            this.Controls.Add(this.textBoxFolder1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormImageComparer";
            this.Text = "Image Comparer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBoxImage1;
        private System.Windows.Forms.PictureBox pictureBoxImage2;
        private System.Windows.Forms.TextBox textBoxFolder1;
        private System.Windows.Forms.TextBox textBoxFolder2;
        private System.Windows.Forms.Label LabelFolder2;
        private System.Windows.Forms.Label LabelFolder1;
        private System.Windows.Forms.Label labelImage1;
        private System.Windows.Forms.Label labelImage2;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxSuffix;
        private System.Windows.Forms.Label label1;
    }
}

