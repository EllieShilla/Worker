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
    public partial class UserProfile : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        bool isEdit = false;
        DataEntities db = new DataEntities();
        string n, s, p;
        int user_id;
        public UserProfile(string name, string fam, string otc, int id)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme("#003e64", "#001932", "#003e64", "#0091c8", TextShade.WHITE);

            toolTip1.SetToolTip(buttonHome, "Домой");

            user_id = id;
            UserRole();
            textBoxSurname.Text = fam;
            textBoxName.Text = name;
            textBoxPatronymic.Text = otc;
            s = fam;
            n = name;
            p = otc;
            TextInf();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEdit == true)
                {
                    var user = db.Users.FirstOrDefault(i => i.Surname == s && i.Name == n && i.Patronymic == p);    //редактирование
                    string chekpass = XOR(textBox2.Text);
                    var role = db.Role.FirstOrDefault(i => i.Title == comboBox1.SelectedItem.ToString());

                    user.Surname = textBoxSurname.Text;
                    user.Name = textBoxName.Text;
                    user.Patronymic = textBoxPatronymic.Text;
                    user.IDRole = role.id;
                    user.Password = chekpass;
                    user.Email = textBoxEmail.Text;
                    user.Email_password = textBox4.Text;
                    db.SaveChanges();
                    MessageBox.Show("Данные изменены");

                    UsersForm usersForm = new UsersForm(user_id);            //НОВЫЕ ИЗМЕНЕНИЯ
                    usersForm.Show();
                    this.Close();
                }
                else if (isEdit != true)
                {

                    var buff = db.Users;
                    bool check = false;
                    var role = db.Role.FirstOrDefault(i => i.Title == comboBox1.SelectedItem.ToString());
                    var fio = db.Users.FirstOrDefault(i => i.Surname == textBoxSurname.Text && i.Name == textBoxName.Text && i.Patronymic == textBoxPatronymic.Text);   //НОВЫЕ ИЗМЕНЕНИЯ

                    if (fio == null)
                    {

                        foreach (var q in buff)   //проверка логинов на повторение
                        {
                            if (XOR(q.Login) == textBox1.Text)
                            {
                                check = true;
                                break;
                            }
                        }

                        if (check == false)   //добавление
                        {
                            string cheklog = XOR(textBox1.Text);
                            string chekpass = XOR(textBox2.Text);

                            Users users = new Users
                            {
                                Surname = textBoxSurname.Text,
                                Name = textBoxName.Text,
                                Patronymic = textBoxPatronymic.Text,
                                IDRole = role.id,
                                Login = cheklog,
                                Password = chekpass,
                                Email = textBoxEmail.Text,
                                Email_password = textBox4.Text
                            };

                            db.Users.Add(users);
                            db.SaveChanges();
                            MessageBox.Show("Данные сохранены");

                            UsersForm usersForm = new UsersForm(user_id);  //НОВЫЕ ИЗМЕНЕНИЯ
                            usersForm.Show();
                            this.Close();
                        }
                        else
                        {

                            MessageBox.Show("Введенный логин уже существует");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с указанными ФИО был добавлен ранее");
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(user_id);
            mainForm.Show();
            this.Close();
        }

        public string XOR(string buff)   //шифрование
        {
            StringBuilder szInputStringBuild = new StringBuilder(buff);
            StringBuilder szOutStringBuild = new StringBuilder(buff.Length);
            char Textch;

            for (int iCount = 0; iCount < buff.Length; iCount++)
            {
                Textch = szInputStringBuild[iCount];
                Textch = (char)(Textch ^ 7534);
                szOutStringBuild.Append(Textch);
            }
            return szOutStringBuild.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxSurname.Text = "";
            textBoxName.Text = "";
            textBoxPatronymic.Text = "";
            textBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBoxEmail.Text = "";
            textBox4.Text = "";

            UsersForm usersForm = new UsersForm(user_id);
            usersForm.Show();
            this.Close();

        }

        public void TextInf() //заполнение textbox
        {
            var user = db.Users.FirstOrDefault(i => i.Surname == textBoxSurname.Text && i.Name == textBoxName.Text && i.Patronymic == textBoxPatronymic.Text);

            if (user != null)
            {
                textBox1.ReadOnly = true;
                isEdit = true;
                comboBox1.SelectedItem = user.Role.Title;
                textBox1.Text = XOR(user.Login);
                textBox2.Text = XOR(user.Password);
                textBoxEmail.Text = user.Email;
                textBox4.Text = user.Email_password;

                if (user.id != user_id)  //если человек зашел к себе в анкету ему высветятся его пароли если к кому-то другому они будут скрыты
                {
                    textBox4.Visible = false;
                    textBox2.Visible = false;
                    textBoxEmail.ReadOnly = true;
                }
                else
                {
                    textBox4.Visible = true;
                    textBox2.Visible = true;
                    textBoxEmail.ReadOnly = false;
                }

                var checkRole = db.Users.FirstOrDefault(i => i.id == user_id);

                if (checkRole.Role.Title != "Менеджер")
                {
                    textBoxSurname.ReadOnly = true;
                    textBoxName.ReadOnly = true;
                    textBoxPatronymic.ReadOnly = true;
                    textBox1.ReadOnly = true;
                    comboBox1.Enabled = false;
                    textBox1.ReadOnly = true;
                    textBox2.ReadOnly = true;
                    textBoxEmail.ReadOnly = true;
                    textBox4.ReadOnly = true;

                    if (user.id == user_id)
                    {
                        textBox2.ReadOnly = false;
                        textBoxEmail.ReadOnly = false;
                        textBox4.ReadOnly = false;
                    }
                }
            }
        }

        public void UserRole()
        {
            var role = db.Role;

            foreach (var item in role)
            {
                comboBox1.Items.Add(item.Title);
            }
            comboBox1.SelectedItem = "HR";
        }
    }
}
