using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkinPlus.Controls;
using MaterialSkinPlus;

namespace Workers
{
    public partial class SubjectsForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        int id;
        DataEntities de;

        public SubjectsForm(int id_user)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme("#003e64", "#001932", "#003e64", "#0091c8", TextShade.WHITE);
            de = new DataEntities();

            UpdteTech();

            id = id_user;
            buttonAddTech.Enabled = false;
            buttonAddSub.Enabled = false;
            comboBoxTech.SelectedIndex = 0;
            toolTip1.SetToolTip(buttonHome, "Домой");
            toolTip1.SetToolTip(buttonAddTech, "Добавить технологию");
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm(id);
            f.Show();
            Close();
        }
        private void comboBoxTech_SelectedIndexChanged(object sender, EventArgs e)
        {
            Updte();
        }

        private void buttonAddSub_Click(object sender, EventArgs e)
        {
            if (comboBoxTech.SelectedItem != null)
            {

                try
                {
                    var cs = de.Technology.Where(t => t.Title == comboBoxTech.SelectedItem.ToString()).Select(t => t.id);
                    int id = 0;
                    foreach (var item in cs)
                        id = item;
                    Subject sub = new Subject
                    {
                        IDTechnology = id,
                        SubjectTitle = textBox1.Text
                    };
                    de.Subject.Add(sub);
                    de.SaveChanges();
                    Updte();
                }
                catch (Exception)
                {

                    MessageBox.Show("Такой технологии не существует!!!");
                }

            }
            else
                MessageBox.Show("Выберите технологию!!!");
            textBox1.Text = null;
        }
        void Updte()
        {
            var cs1 = de.Technology.Where(t => t.Title == comboBoxTech.SelectedItem.ToString()).Select(t => t.id);
            int id = 0;
            foreach (var item in cs1)
                id = item;
            listBoxTech.Items.Clear();
            try
            {
                var cs = de.Subject.Where(t => t.IDTechnology == id).Select(t => t.SubjectTitle);
                foreach (var item in cs)
                    listBoxTech.Items.Add(item);
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка загрузки технологий");
            }

        }
        void UpdteTech()
        {
            comboBoxTech.Items.Clear();
            var cs = de.Technology.Select(t => t.Title);
            foreach (var item in cs)
                comboBoxTech.Items.Add(item);
            comboBoxTech.SelectedIndex = 0;
        }
        private void buttonAddTech_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length >= 3)
            {

                var cs = de.Technology.Where(t => t.Title == textBox2.Text).FirstOrDefault();
                if (cs == null)
                {
                    Technology tch = new Technology
                    {
                        Title = textBox2.Text
                    };
                    de.Technology.Add(tch);
                    de.SaveChanges();
                    UpdteTech();
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Технология" + " " + textBox2.Text + " уже существует!!!");
                    textBox2.Text = "";
                }
            }

        }

        private void comboBoxTech_TextChanged(object sender, EventArgs e)
        {
           
            if (comboBoxTech.Text.Length >= 3)
            {
                buttonAddTech.Enabled = true;
            }
            else
            {
                buttonAddTech.Enabled = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 3)
            {
                buttonAddSub.Enabled = true;
            }
            else
            {
                buttonAddSub.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTech.Text.Length >= 3)
                {
                    if (listBoxTech.Items.Count > 0)
                    {
                        for (int i = 0; i < listBoxTech.Items.Count; i++)
                        {
                            var c = listBoxTech.Items[i].ToString();
                            var cc = de.Subject.Where(t => t.SubjectTitle == c).FirstOrDefault();

                            Subject sub = cc;
                            de.Subject.Remove(sub);
                            de.SaveChanges();
                        }
                    }
                    var cs = de.Technology.Where(t => t.Title == comboBoxTech.SelectedItem.ToString()).FirstOrDefault();

                    Technology tech = cs;
                    de.Technology.Remove(tech);
                    de.SaveChanges();
                }
                else
                    MessageBox.Show("Выберите технологию!!!");
                UpdteTech();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTech.SelectedItem != null)
                {
                    var cs = de.Subject.Where(t => t.SubjectTitle == listBoxTech.SelectedItem.ToString()).FirstOrDefault();

                    Subject sub = cs;
                    de.Subject.Remove(sub);
                    de.SaveChanges();
                }
                else
                    MessageBox.Show("Выберите предмет!!!");
                Updte();
            }
            catch (Exception)
            {

                MessageBox.Show("Такого предмета не существует!!!");
            }
        }

        private void listBoxTech_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDelTech.Enabled = true;
        }

        private void buttonDelTech_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTech.Text.Length >= 3)
                {
                    if (listBoxTech.Items.Count > 0)
                    {
                        for (int i = 0; i < listBoxTech.Items.Count; i++)
                        {
                            var c = listBoxTech.Items[i].ToString();
                            var cc = de.Subject.Where(t => t.SubjectTitle == c).FirstOrDefault();

                            Subject sub = cc;
                            de.Subject.Remove(sub);
                            de.SaveChanges();
                        }
                    }
                    var cs = de.Technology.Where(t => t.Title == comboBoxTech.SelectedItem.ToString()).FirstOrDefault();

                    Technology tech = cs;
                    de.Technology.Remove(tech);
                    de.SaveChanges();
                }
                else
                    MessageBox.Show("Выберите технологию!!!");
                UpdteTech();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDelSub_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTech.SelectedItem != null)
                {
                    var cs = de.Subject.Where(t => t.SubjectTitle == listBoxTech.SelectedItem.ToString()).FirstOrDefault();

                    Subject sub = cs;
                    de.Subject.Remove(sub);
                    de.SaveChanges();
                }
                else
                    MessageBox.Show("Выберите предмет!!!");
                Updte();
            }
            catch (Exception)
            {

                MessageBox.Show("Такого предмета не существует!!!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length >= 3)
            {
                buttonAddTech.Enabled = true;
            }
            else
            {
                buttonAddTech.Enabled = false;
            }
        }

    }
}
