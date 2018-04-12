namespace NTL___Never_too_late
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.polishWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.englishWord = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.saveLesson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // polishWord
            // 
            this.polishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polishWord.Location = new System.Drawing.Point(49, 80);
            this.polishWord.Name = "polishWord";
            this.polishWord.Size = new System.Drawing.Size(215, 23);
            this.polishWord.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Słówko po polsku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PT Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(46, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tłumaczenie po angielsku";
            // 
            // englishWord
            // 
            this.englishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.englishWord.Location = new System.Drawing.Point(49, 157);
            this.englishWord.Name = "englishWord";
            this.englishWord.Size = new System.Drawing.Size(215, 23);
            this.englishWord.TabIndex = 3;
            this.englishWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.englishWord_KeyDown);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("PT Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.ForeColor = System.Drawing.Color.Gainsboro;
            this.add.Location = new System.Drawing.Point(49, 235);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(215, 51);
            this.add.TabIndex = 4;
            this.add.Text = "Dodaj";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // saveLesson
            // 
            this.saveLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveLesson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveLesson.Font = new System.Drawing.Font("PT Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveLesson.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveLesson.Location = new System.Drawing.Point(321, 235);
            this.saveLesson.Name = "saveLesson";
            this.saveLesson.Size = new System.Drawing.Size(175, 51);
            this.saveLesson.TabIndex = 5;
            this.saveLesson.Text = "Zapisz";
            this.saveLesson.UseVisualStyleBackColor = false;
            this.saveLesson.Click += new System.EventHandler(this.saveLesson_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(594, 333);
            this.Controls.Add(this.saveLesson);
            this.Controls.Add(this.add);
            this.Controls.Add(this.englishWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.polishWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NTL - Nowa Lekcja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox polishWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox englishWord;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button saveLesson;
    }
}