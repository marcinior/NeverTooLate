namespace NTL___Never_too_late
{
    partial class ChooseLessonForm
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
        public enum lessonType
        {
            test,
            nauka
        }
        public enum lessonType2
        {
            ANG_POL,
            POL_ANG
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {           
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseLessonForm));
            this.chooseLessonButton = new System.Windows.Forms.Button();
            this.lessonTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lessonTypeComboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nickBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chooseLessonButton
            // 
            this.chooseLessonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chooseLessonButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chooseLessonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseLessonButton.Font = new System.Drawing.Font("PT Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseLessonButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.chooseLessonButton.Location = new System.Drawing.Point(52, 197);
            this.chooseLessonButton.Name = "chooseLessonButton";
            this.chooseLessonButton.Size = new System.Drawing.Size(410, 33);
            this.chooseLessonButton.TabIndex = 0;
            this.chooseLessonButton.Text = "Wybierz";
            this.chooseLessonButton.UseVisualStyleBackColor = false;
            this.chooseLessonButton.Click += new System.EventHandler(this.chooseLessonButton_Click);
            // 
            // lessonTypeComboBox
            // 
            this.lessonTypeComboBox.Font = new System.Drawing.Font("PT Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lessonTypeComboBox.FormattingEnabled = true;
            this.lessonTypeComboBox.Items.AddRange(new object[] {
            NTL___Never_too_late.ChooseLessonForm.lessonType.test,
            NTL___Never_too_late.ChooseLessonForm.lessonType.nauka});
            this.lessonTypeComboBox.Location = new System.Drawing.Point(265, 127);
            this.lessonTypeComboBox.Name = "lessonTypeComboBox";
            this.lessonTypeComboBox.Size = new System.Drawing.Size(84, 23);
            this.lessonTypeComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(262, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Typ lekcji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PT Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(49, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temat lekcji";
            // 
            // lessonTypeComboBox2
            // 
            this.lessonTypeComboBox2.Font = new System.Drawing.Font("PT Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lessonTypeComboBox2.FormattingEnabled = true;
            this.lessonTypeComboBox2.Items.AddRange(new object[] {
            NTL___Never_too_late.ChooseLessonForm.lessonType2.ANG_POL,
            NTL___Never_too_late.ChooseLessonForm.lessonType2.POL_ANG});
            this.lessonTypeComboBox2.Location = new System.Drawing.Point(355, 127);
            this.lessonTypeComboBox2.Name = "lessonTypeComboBox2";
            this.lessonTypeComboBox2.Size = new System.Drawing.Size(107, 23);
            this.lessonTypeComboBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PT Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(49, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Przedstaw się :D";
            // 
            // nickBox
            // 
            this.nickBox.Font = new System.Drawing.Font("PT Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nickBox.Location = new System.Drawing.Point(52, 45);
            this.nickBox.Name = "nickBox";
            this.nickBox.Size = new System.Drawing.Size(139, 23);
            this.nickBox.TabIndex = 6;
            // 
            // ChooseLessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(524, 258);
            this.Controls.Add(this.nickBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lessonTypeComboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lessonTypeComboBox);
            this.Controls.Add(this.chooseLessonButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ChooseLessonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NTL - Wybierz lekcję";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button chooseLessonButton;
        public System.Windows.Forms.ComboBox lessonsComboBox;
        private System.Windows.Forms.ComboBox lessonTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lessonTypeComboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nickBox;
    }
}