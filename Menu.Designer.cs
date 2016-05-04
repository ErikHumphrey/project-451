namespace project_451
{
    partial class frmMenu
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
            this.btnPlayAI = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayAI
            // 
            this.btnPlayAI.Location = new System.Drawing.Point(104, 127);
            this.btnPlayAI.Name = "btnPlayAI";
            this.btnPlayAI.Size = new System.Drawing.Size(215, 33);
            this.btnPlayAI.TabIndex = 0;
            this.btnPlayAI.Text = "Play against three computers";
            this.btnPlayAI.UseVisualStyleBackColor = true;
            this.btnPlayAI.Click += new System.EventHandler(this.btnPlayAI_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(104, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Play hotseat multiplayer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(104, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Quit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue Bold", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-5, -5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 115);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project 451";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "by Erik Humphrey";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(415, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlayAI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "frmMenu";
            this.Text = "Project 451";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayAI;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

