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
    public partial class UsersForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;


        //SelectionMode НУЖНО ВЫБРАТЬ FullRowESelect!!!

        DataEntities db = new DataEntities();
        string name = "", fam = "", otc = "";
        int id = 0;

        private void buttonHome_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(id);
            mainForm.Show();
            this.Close();
        }

        private void dataGridViewUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                fam = dataGridViewUsers.CurrentRow.Cells[0].Value.ToString();
                name = dataGridViewUsers.CurrentRow.Cells[1].Value.ToString();
                otc = dataGridViewUsers.CurrentRow.Cells[2].Value.ToString();

                UserProfile userProfile = new UserProfile(name, fam, otc, id);
                userProfile.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                var checkRole = db.Users.FirstOrDefault(i => i.id == id);

                if (checkRole.Role.Title == "Менеджер")
                {
                    UserProfile userProfile = new UserProfile("", "", "", id);
                    userProfile.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Вы не можете добавлять новых пользователей");
                }
            }
        }

        public UsersForm(int user_id)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme("#003e64", "#001932", "#003e64", "#0091c8", TextShade.WHITE);

            toolTip1.SetToolTip(buttonHome, "Домой");

            id = user_id;
            Markup();
            Inf();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile("", "", "", id);   //НОВЫЕ ИЗМЕНЕНИЯ
            userProfile.Show();
            this.Close();
        }

        public void Markup()
        {
            DataGridViewTextBoxColumn surname = new DataGridViewTextBoxColumn();
            surname.Name = "Фамилия";
            dataGridViewUsers.Columns.Add(surname);
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            name.Name = "Имя";
            dataGridViewUsers.Columns.Add(name);
            DataGridViewTextBoxColumn pat = new DataGridViewTextBoxColumn();
            pat.Name = "Отчество";
            dataGridViewUsers.Columns.Add(pat);
            DataGridViewTextBoxColumn point = new DataGridViewTextBoxColumn();
            point.Name = "Должность";
            dataGridViewUsers.Columns.Add(point);

        }

        public void Inf()       // вывод всех user
        {
            var checkRole = db.Users.FirstOrDefault(i => i.id == id);

            if (checkRole.Role.Title == "Менеджер")
            {
                var user = db.Users.OrderBy(i => i.Surname).ThenBy(i => i.Name).ThenBy(i => i.Patronymic);

                foreach (var item in user)
                {
                    dataGridViewUsers.Rows.Add(item.Surname, item.Name, item.Patronymic, item.Role.Title);
                }

            }
            else
            {
                dataGridViewUsers.Rows.Add(checkRole.Surname, checkRole.Name, checkRole.Patronymic, checkRole.Role.Title);     //НОВЫЕ ИЗМЕНЕНИЯ
                buttonAddUser.Enabled = false;
            }
        }

    }
}
