namespace FYP
{
    partial class fall1618
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
            this.button1 = new System.Windows.Forms.Button();
            this.InsertStudentInfoButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Show Students Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertStudentInfoButton
            // 
            this.InsertStudentInfoButton.Location = new System.Drawing.Point(59, 69);
            this.InsertStudentInfoButton.Name = "InsertStudentInfoButton";
            this.InsertStudentInfoButton.Size = new System.Drawing.Size(280, 34);
            this.InsertStudentInfoButton.TabIndex = 0;
            this.InsertStudentInfoButton.Text = "&Insert Students Information";
            this.InsertStudentInfoButton.UseVisualStyleBackColor = true;
            this.InsertStudentInfoButton.Click += new System.EventHandler(this.InsertStudentInfoButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // fall1618
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 272);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.InsertStudentInfoButton);
            this.Controls.Add(this.button1);
            this.Name = "fall1618";
            this.Text = "fall1618";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button InsertStudentInfoButton;
        private System.Windows.Forms.Button button3;
    }
}