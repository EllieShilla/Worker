namespace Workers
{
    partial class Subjects
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
            this.materialContextMenuStripSubTech = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxSub = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTech = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.materialContextMenuStripSubTech.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialContextMenuStripSubTech
            // 
            this.materialContextMenuStripSubTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStripSubTech.Depth = 0;
            this.materialContextMenuStripSubTech.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1});
            this.materialContextMenuStripSubTech.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStripSubTech.Name = "materialContextMenuStripSub";
            this.materialContextMenuStripSubTech.Size = new System.Drawing.Size(155, 48);
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            // 
            // listBoxSub
            // 
            this.listBoxSub.ContextMenuStrip = this.materialContextMenuStripSubTech;
            this.listBoxSub.FormattingEnabled = true;
            this.listBoxSub.Location = new System.Drawing.Point(24, 196);
            this.listBoxSub.Name = "listBoxSub";
            this.listBoxSub.Size = new System.Drawing.Size(296, 199);
            this.listBoxSub.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Предметы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Технологии";
            // 
            // comboBoxTech
            // 
            this.comboBoxTech.ContextMenuStrip = this.materialContextMenuStripSubTech;
            this.comboBoxTech.FormattingEnabled = true;
            this.comboBoxTech.Location = new System.Drawing.Point(24, 147);
            this.comboBoxTech.Name = "comboBoxTech";
            this.comboBoxTech.Size = new System.Drawing.Size(168, 21);
            this.comboBoxTech.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(24, 85);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 425);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxSub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTech);
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.materialContextMenuStripSubTech.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStripSubTech;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ListBox listBoxSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTech;
        private System.Windows.Forms.Button buttonAdd;
    }
}