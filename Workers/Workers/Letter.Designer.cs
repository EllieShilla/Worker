namespace Workers
{
    partial class Letter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Letter));
            this.textBoxTheme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAttach = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.listBoxAttach = new System.Windows.Forms.ListBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTheme
            // 
            this.textBoxTheme.Location = new System.Drawing.Point(91, 173);
            this.textBoxTheme.Name = "textBoxTheme";
            this.textBoxTheme.Size = new System.Drawing.Size(257, 20);
            this.textBoxTheme.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тема:";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(91, 209);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(257, 155);
            this.textBoxMessage.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сообщение:";
            // 
            // buttonAttach
            // 
            this.buttonAttach.Location = new System.Drawing.Point(390, 306);
            this.buttonAttach.Name = "buttonAttach";
            this.buttonAttach.Size = new System.Drawing.Size(77, 23);
            this.buttonAttach.TabIndex = 8;
            this.buttonAttach.Text = "Прикрепить";
            this.buttonAttach.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(273, 370);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // listBoxAttach
            // 
            this.listBoxAttach.FormattingEnabled = true;
            this.listBoxAttach.Location = new System.Drawing.Point(366, 209);
            this.listBoxAttach.Name = "listBoxAttach";
            this.listBoxAttach.Size = new System.Drawing.Size(120, 82);
            this.listBoxAttach.TabIndex = 10;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(0, 63);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(501, 74);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(426, 143);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 23);
            this.buttonHome.TabIndex = 12;
            this.buttonHome.Text = "Домой";
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // Letter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 407);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.listBoxAttach);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonAttach);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTheme);
            this.Controls.Add(this.label3);
            this.Name = "Letter";
            this.Text = "Letter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTheme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAttach;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ListBox listBoxAttach;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button buttonHome;
    }
}