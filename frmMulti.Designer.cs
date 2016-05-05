namespace project_451
{
    partial class frmMulti
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
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer1.Location = new System.Drawing.Point(167, 135);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(340, 36);
            this.btnAnswer1.TabIndex = 0;
            this.btnAnswer1.Text = "answer1";
            this.btnAnswer1.UseVisualStyleBackColor = false;
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer2.Location = new System.Drawing.Point(167, 177);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(340, 36);
            this.btnAnswer2.TabIndex = 1;
            this.btnAnswer2.Text = "answer2";
            this.btnAnswer2.UseVisualStyleBackColor = false;
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer3.Location = new System.Drawing.Point(167, 219);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(340, 36);
            this.btnAnswer3.TabIndex = 2;
            this.btnAnswer3.Text = "answer3";
            this.btnAnswer3.UseVisualStyleBackColor = false;
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer4.Location = new System.Drawing.Point(167, 261);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(340, 36);
            this.btnAnswer4.TabIndex = 3;
            this.btnAnswer4.Text = "answer4";
            this.btnAnswer4.UseVisualStyleBackColor = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.lblQuestion.Location = new System.Drawing.Point(91, 24);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(493, 90);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "Placeholder string Placeholder string Placeholder string Placeholder string Place" +
    "holder string Placeholder string Placeholder string Placeholder string Placehold" +
    "er string Placeholder string ";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(675, 334);
            this.ControlBox = false;
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMulti";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Multiple Choice question";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Label lblQuestion;
    }
}