namespace Workers
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonWorkers = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonComment = new System.Windows.Forms.Button();
            this.buttonChat = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWorkers
            // 
            this.buttonWorkers.BackColor = System.Drawing.Color.White;
            this.buttonWorkers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWorkers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkers.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWorkers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonWorkers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWorkers.ImageIndex = 4;
            this.buttonWorkers.ImageList = this.imageList1;
            this.buttonWorkers.Location = new System.Drawing.Point(34, 221);
            this.buttonWorkers.Name = "buttonWorkers";
            this.buttonWorkers.Size = new System.Drawing.Size(218, 25);
            this.buttonWorkers.TabIndex = 0;
            this.buttonWorkers.Text = "Сотрудники";
            this.buttonWorkers.UseVisualStyleBackColor = false;
            this.buttonWorkers.Click += new System.EventHandler(this.buttonWorkers_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-business-group-64.png");
            this.imageList1.Images.SetKeyName(1, "icons8-cloud-link-64.png");
            this.imageList1.Images.SetKeyName(2, "icons8-communication-64.png");
            this.imageList1.Images.SetKeyName(3, "icons8-exit-64.png");
            this.imageList1.Images.SetKeyName(4, "icons8-information-64.png");
            this.imageList1.Images.SetKeyName(5, "icons8-working-parents-64.png");
            // 
            // buttonComment
            // 
            this.buttonComment.BackColor = System.Drawing.Color.White;
            this.buttonComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonComment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComment.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonComment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComment.ImageIndex = 1;
            this.buttonComment.ImageList = this.imageList1;
            this.buttonComment.Location = new System.Drawing.Point(34, 250);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(218, 25);
            this.buttonComment.TabIndex = 1;
            this.buttonComment.Text = "Предметы и технологии";
            this.buttonComment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonComment.UseVisualStyleBackColor = false;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // buttonChat
            // 
            this.buttonChat.BackColor = System.Drawing.Color.White;
            this.buttonChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChat.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChat.ImageIndex = 2;
            this.buttonChat.ImageList = this.imageList1;
            this.buttonChat.Location = new System.Drawing.Point(34, 279);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new System.Drawing.Size(218, 25);
            this.buttonChat.TabIndex = 3;
            this.buttonChat.Text = "Чат";
            this.buttonChat.UseVisualStyleBackColor = false;
            this.buttonChat.Click += new System.EventHandler(this.buttonChat_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.ImageIndex = 3;
            this.buttonExit.ImageList = this.imageList1;
            this.buttonExit.Location = new System.Drawing.Point(34, 308);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(218, 25);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(0, 63);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(283, 67);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.White;
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.ImageKey = "icons8-information-64.png";
            this.buttonInfo.ImageList = this.imageList1;
            this.buttonInfo.Location = new System.Drawing.Point(220, 133);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(32, 33);
            this.buttonInfo.TabIndex = 7;
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.White;
            this.buttonUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsers.ImageIndex = 0;
            this.buttonUsers.ImageList = this.imageList1;
            this.buttonUsers.Location = new System.Drawing.Point(34, 190);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(218, 25);
            this.buttonUsers.TabIndex = 4;
            this.buttonUsers.Text = "Пользователи";
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 353);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonChat);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.buttonWorkers);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximumSize = new System.Drawing.Size(283, 353);
            this.MinimumSize = new System.Drawing.Size(283, 353);
            this.Name = "MainForm";
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWorkers;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.Button buttonChat;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}