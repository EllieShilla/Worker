namespace Workers
{
    partial class SubjectsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectsForm));
            this.materialContextMenuStripSubTech = new MaterialSkinPlus.Controls.MaterialContextMenuStrip();
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddTech = new System.Windows.Forms.Button();
            this.comboBoxTech = new System.Windows.Forms.ComboBox();
            this.listBoxTech = new System.Windows.Forms.ListBox();
            this.buttonAddSub = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonHome = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDelSub = new System.Windows.Forms.Button();
            this.buttonDelTech = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.materialContextMenuStripSubTech.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // materialContextMenuStripSubTech
            // 
            this.materialContextMenuStripSubTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStripSubTech.Depth = 0;
            this.materialContextMenuStripSubTech.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStripSubTech.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1});
            this.materialContextMenuStripSubTech.MouseState = MaterialSkinPlus.MouseState.HOVER;
            this.materialContextMenuStripSubTech.Name = "materialContextMenuStripSub";
            this.materialContextMenuStripSubTech.Size = new System.Drawing.Size(159, 56);
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("редактироватьToolStripMenuItem1.Image")));
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(158, 26);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("удалитьToolStripMenuItem1.Image")));
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(158, 26);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(-1, 64);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(298, 74);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(25, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Технологии";
            // 
            // buttonAddTech
            // 
            this.buttonAddTech.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddTech.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddTech.BackgroundImage")));
            this.buttonAddTech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddTech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTech.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonAddTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTech.Location = new System.Drawing.Point(120, 171);
            this.buttonAddTech.Name = "buttonAddTech";
            this.buttonAddTech.Size = new System.Drawing.Size(23, 24);
            this.buttonAddTech.TabIndex = 17;
            this.buttonAddTech.UseVisualStyleBackColor = false;
            this.buttonAddTech.Click += new System.EventHandler(this.buttonAddTech_Click);
            // 
            // comboBoxTech
            // 
            this.comboBoxTech.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTech.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTech.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTech.FormattingEnabled = true;
            this.comboBoxTech.Location = new System.Drawing.Point(29, 231);
            this.comboBoxTech.Name = "comboBoxTech";
            this.comboBoxTech.Size = new System.Drawing.Size(249, 24);
            this.comboBoxTech.TabIndex = 19;
            this.comboBoxTech.SelectedIndexChanged += new System.EventHandler(this.comboBoxTech_SelectedIndexChanged);
            // 
            // listBoxTech
            // 
            this.listBoxTech.BackColor = System.Drawing.Color.Lavender;
            this.listBoxTech.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTech.ForeColor = System.Drawing.Color.Black;
            this.listBoxTech.FormattingEnabled = true;
            this.listBoxTech.ItemHeight = 16;
            this.listBoxTech.Location = new System.Drawing.Point(27, 267);
            this.listBoxTech.Name = "listBoxTech";
            this.listBoxTech.Size = new System.Drawing.Size(249, 148);
            this.listBoxTech.TabIndex = 21;
            this.listBoxTech.SelectedIndexChanged += new System.EventHandler(this.listBoxTech_SelectedIndexChanged);
            // 
            // buttonAddSub
            // 
            this.buttonAddSub.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSub.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonAddSub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddSub.ImageKey = "icons8-add-100.png";
            this.buttonAddSub.ImageList = this.imageList1;
            this.buttonAddSub.Location = new System.Drawing.Point(27, 461);
            this.buttonAddSub.Name = "buttonAddSub";
            this.buttonAddSub.Size = new System.Drawing.Size(250, 40);
            this.buttonAddSub.TabIndex = 23;
            this.buttonAddSub.Text = "       Добавить предмет";
            this.buttonAddSub.UseVisualStyleBackColor = false;
            this.buttonAddSub.Click += new System.EventHandler(this.buttonAddSub_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-add-100.png");
            this.imageList1.Images.SetKeyName(1, "icons8-minus-100.png");
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHome.BackgroundImage")));
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Location = new System.Drawing.Point(253, 144);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(39, 34);
            this.buttonHome.TabIndex = 24;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lavender;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(27, 431);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 24);
            this.textBox1.TabIndex = 25;
            this.textBox1.Click += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonDelSub
            // 
            this.buttonDelSub.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelSub.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonDelSub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelSub.ImageKey = "icons8-minus-100.png";
            this.buttonDelSub.ImageList = this.imageList1;
            this.buttonDelSub.Location = new System.Drawing.Point(27, 507);
            this.buttonDelSub.Name = "buttonDelSub";
            this.buttonDelSub.Size = new System.Drawing.Size(250, 40);
            this.buttonDelSub.TabIndex = 26;
            this.buttonDelSub.Text = "       Удалить предмет";
            this.buttonDelSub.UseVisualStyleBackColor = false;
            this.buttonDelSub.Click += new System.EventHandler(this.buttonDelSub_Click);
            // 
            // buttonDelTech
            // 
            this.buttonDelTech.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelTech.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelTech.BackgroundImage")));
            this.buttonDelTech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelTech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelTech.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(100)))));
            this.buttonDelTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelTech.Location = new System.Drawing.Point(149, 171);
            this.buttonDelTech.Name = "buttonDelTech";
            this.buttonDelTech.Size = new System.Drawing.Size(23, 24);
            this.buttonDelTech.TabIndex = 27;
            this.buttonDelTech.UseVisualStyleBackColor = false;
            this.buttonDelTech.Click += new System.EventHandler(this.buttonDelTech_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Lavender;
            this.textBox2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(120, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 24);
            this.textBox2.TabIndex = 28;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 557);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonDelTech);
            this.Controls.Add(this.buttonDelSub);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonAddSub);
            this.Controls.Add(this.listBoxTech);
            this.Controls.Add(this.comboBoxTech);
            this.Controls.Add(this.buttonAddTech);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(297, 557);
            this.MinimumSize = new System.Drawing.Size(297, 557);
            this.Name = "SubjectsForm";
            this.Text = "Технологии и предметы";
            this.materialContextMenuStripSubTech.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkinPlus.Controls.MaterialContextMenuStrip materialContextMenuStripSubTech;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddTech;
        private System.Windows.Forms.ComboBox comboBoxTech;
        private System.Windows.Forms.ListBox listBoxTech;
        private System.Windows.Forms.Button buttonAddSub;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonDelSub;
        private System.Windows.Forms.Button buttonDelTech;
        private System.Windows.Forms.TextBox textBox2;
    }
}