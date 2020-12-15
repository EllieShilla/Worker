namespace Workers
{
    partial class EditPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPost));
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonSavePost = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePickerFired = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAccept = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.buttonHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(0, 64);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(512, 74);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // buttonSavePost
            // 
            this.buttonSavePost.Location = new System.Drawing.Point(191, 239);
            this.buttonSavePost.Name = "buttonSavePost";
            this.buttonSavePost.Size = new System.Drawing.Size(129, 33);
            this.buttonSavePost.TabIndex = 15;
            this.buttonSavePost.Text = "Сохранить";
            this.buttonSavePost.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 161);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Должность";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(158, 201);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 16);
            this.label17.TabIndex = 13;
            this.label17.Text = "Дата увольнения:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(158, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "Дата приема:";
            // 
            // dateTimePickerFired
            // 
            this.dateTimePickerFired.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerFired.Location = new System.Drawing.Point(288, 197);
            this.dateTimePickerFired.Name = "dateTimePickerFired";
            this.dateTimePickerFired.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFired.TabIndex = 11;
            // 
            // dateTimePickerAccept
            // 
            this.dateTimePickerAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerAccept.Location = new System.Drawing.Point(288, 157);
            this.dateTimePickerAccept.Name = "dateTimePickerAccept";
            this.dateTimePickerAccept.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAccept.TabIndex = 10;
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Location = new System.Drawing.Point(17, 201);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPost.TabIndex = 9;
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(437, 256);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 23);
            this.buttonHome.TabIndex = 16;
            this.buttonHome.Text = "Домой";
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // EditPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 291);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonSavePost);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dateTimePickerFired);
            this.Controls.Add(this.dateTimePickerAccept);
            this.Controls.Add(this.comboBoxPost);
            this.Controls.Add(this.pictureBox6);
            this.Name = "EditPost";
            this.Text = "EditPost";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button buttonSavePost;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePickerFired;
        private System.Windows.Forms.DateTimePicker dateTimePickerAccept;
        private System.Windows.Forms.ComboBox comboBoxPost;
        private System.Windows.Forms.Button buttonHome;
    }
}