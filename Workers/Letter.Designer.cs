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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Letter));
            this.textBoxTheme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAttach = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonSend = new System.Windows.Forms.Button();
            this.listBoxAttach = new System.Windows.Forms.ListBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTheme
            // 
            this.textBoxTheme.BackColor = System.Drawing.Color.Lavender;
            this.textBoxTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTheme.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTheme.ForeColor = System.Drawing.Color.Black;
            this.textBoxTheme.Location = new System.Drawing.Point(112, 174);
            this.textBoxTheme.Name = "textBoxTheme";
            this.textBoxTheme.Size = new System.Drawing.Size(275, 24);
            this.textBoxTheme.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тема:";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.Color.Lavender;
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMessage.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMessage.ForeColor = System.Drawing.Color.Black;
            this.textBoxMessage.Location = new System.Drawing.Point(112, 210);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(275, 155);
            this.textBoxMessage.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сообщение:";
            // 
            // buttonAttach
            // 
            this.buttonAttach.BackColor = System.Drawing.Color.Transparent;
            this.buttonAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAttach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttach.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAttach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonAttach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAttach.ImageKey = "icons8-attach-100.png";
            this.buttonAttach.ImageList = this.imageList1;
            this.buttonAttach.Location = new System.Drawing.Point(407, 300);
            this.buttonAttach.Name = "buttonAttach";
            this.buttonAttach.Size = new System.Drawing.Size(140, 37);
            this.buttonAttach.TabIndex = 8;
            this.buttonAttach.Text = "        Прикрепить";
            this.buttonAttach.UseVisualStyleBackColor = false;
            this.buttonAttach.Click += new System.EventHandler(this.buttonAttach_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-attach-100.png");
            this.imageList1.Images.SetKeyName(1, "icons8-paper-plane1-100.png");
            this.imageList1.Images.SetKeyName(2, "icons8-home-128.png");
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.Transparent;
            this.buttonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSend.ImageKey = "icons8-paper-plane1-100.png";
            this.buttonSend.ImageList = this.imageList1;
            this.buttonSend.Location = new System.Drawing.Point(259, 371);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(128, 37);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "      Отправить";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // listBoxAttach
            // 
            this.listBoxAttach.BackColor = System.Drawing.Color.White;
            this.listBoxAttach.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAttach.ForeColor = System.Drawing.Color.Black;
            this.listBoxAttach.FormattingEnabled = true;
            this.listBoxAttach.ItemHeight = 16;
            this.listBoxAttach.Location = new System.Drawing.Point(407, 210);
            this.listBoxAttach.Name = "listBoxAttach";
            this.listBoxAttach.Size = new System.Drawing.Size(138, 84);
            this.listBoxAttach.TabIndex = 10;
            this.listBoxAttach.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxAttach_MouseDoubleClick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(0, 63);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(566, 85);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.ImageKey = "icons8-home-128.png";
            this.buttonHome.ImageList = this.imageList1;
            this.buttonHome.Location = new System.Drawing.Point(508, 154);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(39, 34);
            this.buttonHome.TabIndex = 12;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Letter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 423);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.listBoxAttach);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonAttach);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTheme);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.MaximumSize = new System.Drawing.Size(565, 423);
            this.MinimumSize = new System.Drawing.Size(565, 423);
            this.Name = "Letter";
            this.Text = "Письмо";
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}