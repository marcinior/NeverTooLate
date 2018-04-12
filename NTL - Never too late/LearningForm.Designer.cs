namespace NTL___Never_too_late
{
    partial class LearningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearningForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.endLearningButton = new System.Windows.Forms.Button();
            this.wordTextBox = new System.Windows.Forms.Label();
            this.translateTextBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 61);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // endLearningButton
            // 
            this.endLearningButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.endLearningButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.endLearningButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endLearningButton.Font = new System.Drawing.Font("PT Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endLearningButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.endLearningButton.Location = new System.Drawing.Point(267, 235);
            this.endLearningButton.Name = "endLearningButton";
            this.endLearningButton.Size = new System.Drawing.Size(184, 59);
            this.endLearningButton.TabIndex = 3;
            this.endLearningButton.Text = "Zakończ";
            this.endLearningButton.UseVisualStyleBackColor = false;
            this.endLearningButton.Click += new System.EventHandler(this.endLearningButton_Click);
            // 
            // wordTextBox
            // 
            this.wordTextBox.BackColor = System.Drawing.Color.White;
            this.wordTextBox.Font = new System.Drawing.Font("PT Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wordTextBox.Location = new System.Drawing.Point(29, 90);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(291, 61);
            this.wordTextBox.TabIndex = 4;
            this.wordTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translateTextBox
            // 
            this.translateTextBox.BackColor = System.Drawing.Color.White;
            this.translateTextBox.Font = new System.Drawing.Font("PT Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.translateTextBox.Location = new System.Drawing.Point(415, 90);
            this.translateTextBox.Name = "translateTextBox";
            this.translateTextBox.Size = new System.Drawing.Size(258, 61);
            this.translateTextBox.TabIndex = 5;
            this.translateTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LearningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(703, 332);
            this.Controls.Add(this.translateTextBox);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.endLearningButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LearningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NTL - Nauka";
            this.Load += new System.EventHandler(this.LearningForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button endLearningButton;
        private System.Windows.Forms.Label wordTextBox;
        private System.Windows.Forms.Label translateTextBox;
    }
}