namespace NTL___Never_too_late
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteLessonButton = new System.Windows.Forms.Button();
            this.deleteLessonComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showRecords = new System.Windows.Forms.Button();
            this.chooseRecordComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteLessonButton);
            this.groupBox1.Controls.Add(this.deleteLessonComboBox);
            this.groupBox1.Font = new System.Drawing.Font("PT Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(38, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuń lekcję";
            // 
            // deleteLessonButton
            // 
            this.deleteLessonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteLessonButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteLessonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteLessonButton.Font = new System.Drawing.Font("PT Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteLessonButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteLessonButton.Location = new System.Drawing.Point(6, 82);
            this.deleteLessonButton.Name = "deleteLessonButton";
            this.deleteLessonButton.Size = new System.Drawing.Size(425, 37);
            this.deleteLessonButton.TabIndex = 1;
            this.deleteLessonButton.Text = "Usuń";
            this.deleteLessonButton.UseVisualStyleBackColor = false;
            this.deleteLessonButton.Click += new System.EventHandler(this.deleteLessonButton_Click);
            // 
            // deleteLessonComboBox
            // 
            this.deleteLessonComboBox.FormattingEnabled = true;
            this.deleteLessonComboBox.Location = new System.Drawing.Point(206, 33);
            this.deleteLessonComboBox.Name = "deleteLessonComboBox";
            this.deleteLessonComboBox.Size = new System.Drawing.Size(225, 26);
            this.deleteLessonComboBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showRecords);
            this.groupBox2.Controls.Add(this.chooseRecordComboBox);
            this.groupBox2.Font = new System.Drawing.Font("PT Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(38, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zobacz najlepsze wyniki testów";
            // 
            // showRecords
            // 
            this.showRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showRecords.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showRecords.Font = new System.Drawing.Font("PT Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showRecords.ForeColor = System.Drawing.Color.Gainsboro;
            this.showRecords.Location = new System.Drawing.Point(6, 85);
            this.showRecords.Name = "showRecords";
            this.showRecords.Size = new System.Drawing.Size(425, 36);
            this.showRecords.TabIndex = 1;
            this.showRecords.Text = "Pokaż najlepsze wyniki";
            this.showRecords.UseVisualStyleBackColor = false;
            this.showRecords.Click += new System.EventHandler(this.showRecords_Click);
            // 
            // chooseRecordComboBox
            // 
            this.chooseRecordComboBox.FormattingEnabled = true;
            this.chooseRecordComboBox.Location = new System.Drawing.Point(206, 38);
            this.chooseRecordComboBox.Name = "chooseRecordComboBox";
            this.chooseRecordComboBox.Size = new System.Drawing.Size(225, 26);
            this.chooseRecordComboBox.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(506, 346);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NTL - Ustawienia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteLessonButton;
        public System.Windows.Forms.ComboBox deleteLessonComboBox;
        private System.Windows.Forms.Button showRecords;
        public System.Windows.Forms.ComboBox chooseRecordComboBox;
    }
}