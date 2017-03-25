namespace ExpertSystem
{
    partial class ChooseTopic
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
            this.topic1Button = new System.Windows.Forms.Button();
            this.topic2Button = new System.Windows.Forms.Button();
            this.topic3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topic1Button
            // 
            this.topic1Button.Location = new System.Drawing.Point(192, 67);
            this.topic1Button.Name = "topic1Button";
            this.topic1Button.Size = new System.Drawing.Size(119, 36);
            this.topic1Button.TabIndex = 0;
            this.topic1Button.Text = "Topic 1";
            this.topic1Button.UseVisualStyleBackColor = true;
            this.topic1Button.Click += new System.EventHandler(this.topic1Button_Click);
            // 
            // topic2Button
            // 
            this.topic2Button.Location = new System.Drawing.Point(192, 109);
            this.topic2Button.Name = "topic2Button";
            this.topic2Button.Size = new System.Drawing.Size(119, 36);
            this.topic2Button.TabIndex = 1;
            this.topic2Button.Text = "Topic 2";
            this.topic2Button.UseVisualStyleBackColor = true;
            // 
            // topic3Button
            // 
            this.topic3Button.Location = new System.Drawing.Point(192, 151);
            this.topic3Button.Name = "topic3Button";
            this.topic3Button.Size = new System.Drawing.Size(119, 36);
            this.topic3Button.TabIndex = 2;
            this.topic3Button.Text = "Topic 3";
            this.topic3Button.UseVisualStyleBackColor = true;
            // 
            // ChooseTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 287);
            this.Controls.Add(this.topic3Button);
            this.Controls.Add(this.topic2Button);
            this.Controls.Add(this.topic1Button);
            this.Name = "ChooseTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseTopic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button topic1Button;
        private System.Windows.Forms.Button topic2Button;
        private System.Windows.Forms.Button topic3Button;

    }
}