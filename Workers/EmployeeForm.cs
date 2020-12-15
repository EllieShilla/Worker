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
using System.Data.Entity;
using System.Configuration;
using System.Data.SqlClient;

namespace Workers
{
    public partial class EmployeeForm : MaterialForm
    {
        //SqlConnection conn;

        //SqlDataAdapter dap;
        DataEntities dataEntities;
        //private readonly MaterialSkinManager materialSkinManager;
        int id_user;
        public EmployeeForm(int id)
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green600, Primary.Green900,
                Primary.Green600, Accent.LightBlue200,
                TextShade.WHITE);


            string[] c = { "Фамилия", "Должность", "Статус", "Технология/Предметы" };
            comboBoxCategory.Items.AddRange(c);
            comboBoxCategory.SelectedIndex = 0;
            id_user = id;
            dataEntities = new DataEntities();
            buttonSearch.Enabled = true;
            Markup();
            Information();
            dataGridViewWorkers.Columns["Id"].Visible = false;

            //conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OffConn"].ConnectionString);
        }
        public void Markup()
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "Id";
            dataGridViewWorkers.Columns.Add(id);
            DataGridViewTextBoxColumn surname = new DataGridViewTextBoxColumn();
            surname.Name = "Фамилия";
            dataGridViewWorkers.Columns.Add(surname);
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            name.Name = "Имя";
            dataGridViewWorkers.Columns.Add(name);
            DataGridViewTextBoxColumn point = new DataGridViewTextBoxColumn();
            point.Name = "Баллы";
            dataGridViewWorkers.Columns.Add(point);
        }
        public void Information()       // вывод всех user
        {
            /*var checkRole = dataEntities.EmployeeTable.FirstOrDefault(i => i.Id == id_user);*/ //-----------

            var user = (from e in dataEntities.EmployeeTable
                        join r in dataEntities.Rating on e.id equals r.IDEmployee
                        select new { Id = e.id, Surname = e.Surname, Name = e.Name, Patron = e.Patronymic, Rate = r.Scores }).OrderBy(t => t.Surname).ThenBy(t => t.Name).ThenBy(t => t.Patron); 

            foreach (var item in user)
            {
                dataGridViewWorkers.Rows.Add(item.Id, item.Surname, item.Name, item.Rate);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Anketa f = new Anketa(id_user);
            f.ShowDialog();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridViewWorkers.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridViewWorkers[0, index].Value.ToString(), out id);
            if (converted == false)
            {
                return;
            }
            Anketa f = new Anketa(id, id_user);
            f.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridViewWorkers.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridViewWorkers[0, index].Value.ToString(), out id);
            if (converted == false)
            {
                return;
            }
            EmployeeTable emp = dataEntities.EmployeeTable.Find(id);
            dataEntities.EmployeeTable.Remove(emp);
            dataEntities.SaveChanges();
            dataGridViewWorkers.DataSource = dataEntities.EmployeeTable.Local.ToList();
            MessageBox.Show("Object deleted");
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm(id_user);
            f.Show();
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedItem.ToString() == "Фамилия")            //поиск по фамилии
            {
                var employee = dataEntities.EmployeeTable.Where(i => i.Surname.Contains(textBoxCategory.Text));

                if (employee != null)
                {
                    int max = 0;

                    try
                    {
                        max = employee.Max(i => i.id);
                    }
                    catch (Exception ex) { }

                    dataGridViewWorkers.Rows.Clear();
                    foreach (var item in employee)
                    {
                        for (int i = 0; i <= max; i++)
                        {
                            if (i == item.id)
                            {
                                int count = dataEntities.Rating.Count(z => z.IDEmployee == i);
                                int sum = dataEntities.Rating.Where(z => z.IDEmployee == i).Sum(w => w.Scores);
                                dataGridViewWorkers.Rows.Add(item.Surname, item.Name, item.Patronymic, sum / count);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Данные не найдены");
                }
            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Статус")      //поиск по статусу
            {
                var employee = dataEntities.EmployeeTable.Where(i => i.Status.Title.Contains(textBoxCategory.Text));

                if (employee != null)
                {
                    int max = 0;

                    try
                    {
                        max = employee.Max(i => i.id);
                    }
                    catch (Exception ex) { }

                    dataGridViewWorkers.Rows.Clear();
                    foreach (var item in employee)
                    {
                        for (int i = 0; i <= max; i++)
                        {
                            if (i == item.id)
                            {
                                int count = dataEntities.Rating.Count(z => z.IDEmployee == i);
                                int sum = dataEntities.Rating.Where(z => z.IDEmployee == i).Sum(w => w.Scores);
                                dataGridViewWorkers.Rows.Add(item.Surname, item.Name, item.Patronymic, sum / count);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Данные не найдены");
                }

            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Должность")           //поиск по должности
            {
                dataGridViewWorkers.Rows.Clear();

                var pos = dataEntities.PositionEmployee.Where(i => i.Position.Title.Contains(textBoxCategory.Text));
                int max = 0;

                if (pos != null)
                {
                    try
                    {
                        max = pos.Max(i => i.IDEmployee);
                    }
                    catch (Exception ex) { }

                    foreach (var item in pos)
                    {
                        for (int i = 0; i <= max; i++)
                        {
                            if (i == item.IDEmployee)
                            {
                                int count = dataEntities.Rating.Count(z => z.IDEmployee == i);
                                int sum = dataEntities.Rating.Where(z => z.IDEmployee == i).Sum(w => w.Scores);
                                dataGridViewWorkers.Rows.Add(item.EmployeeTable.Surname, item.EmployeeTable.Name, item.EmployeeTable.Patronymic, sum / count);
                            }
                        }
                    }
                }
            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Технология/Предметы")           //поиск по должности
            {
                dataGridViewWorkers.Rows.Clear();

                int c = 0;

                if (radioButtonTech.Checked)
                {
                    string v = checkedListBoxTech.SelectedItem.ToString();
                    c = dataEntities.Technology.Where(t => t.Title == v).Select(t => t.id).FirstOrDefault();
                }
                else if (radioButtonSub.Checked)
                {
                    string v = checkedListBoxSub.SelectedItem.ToString();
                    int vx = dataEntities.Subject.Where(t => t.SubjectTitle == v).Select(t => t.IDTechnology).FirstOrDefault();
                    c = dataEntities.Technology.Where(t => t.id == vx).Select(t => t.id).FirstOrDefault();
                }
                else
                    return;
                int max = 0;
                var g = dataEntities.WhatCan.Where(t => t.Technology.id == c).Select(t => t.IDEmployee);
                foreach (var it in g)
                {


                    var pos = dataEntities.EmployeeTable.Where(t => t.id == it);
                    if (pos != null)
                    {
                        try
                        {
                            max = pos.Max(i => i.id);
                        }
                        catch (Exception ex) { }

                        foreach (var item in pos)
                        {
                            for (int i = 0; i <= max; i++)
                            {
                                if (i == item.id)
                                {
                                    int count = dataEntities.Rating.Count(z => z.IDEmployee == i);
                                    int sum = dataEntities.Rating.Where(z => z.IDEmployee == i).Sum(w => w.Scores);
                                    dataGridViewWorkers.Rows.Add(item.Surname, item.Name, item.Patronymic, sum / count);
                                }
                            }
                        }
                    }
                }
            }
            dataGridViewWorkers.Sort(dataGridViewWorkers.Columns["Баллы"], ListSortDirection.Descending);       //сортировка
        }
        public void Inf()                                     //вывод всех сотрудников
        {
            int max = dataEntities.Rating.Max(i => i.IDEmployee);
            var emp = dataEntities.EmployeeTable;

            foreach (var item in emp)
            {
                for (int i = 0; i <= max; i++)
                {
                    if (i == item.id)
                    {
                        int count = dataEntities.Rating.Count(z => z.IDEmployee == i);                                              //расчет среднеарифметической оценки
                        int sum = dataEntities.Rating.Where(z => z.IDEmployee == i).Sum(e => e.Scores);
                        dataGridViewWorkers.Rows.Add(item.Surname, item.Name, item.Patronymic, sum / count);
                    }
                }
            }

            dataGridViewWorkers.Sort(dataGridViewWorkers.Columns["Баллы"], ListSortDirection.Descending);
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            dataGridViewWorkers.Rows.Clear();
            textBoxCategory.Text = null;
            Inf();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxTech.Items.Clear();
            checkedListBoxSub.Items.Clear();
            if (comboBoxCategory.SelectedItem.ToString() == "Фамилия")
            {
                textBoxCategory.Enabled = true;
                checkedListBoxTech.Visible = false;
                checkedListBoxSub.Visible = false;
                radioButtonTech.Visible = false;
                radioButtonSub.Visible = false;
            }
            if (comboBoxCategory.SelectedItem.ToString() == "Должность")
            {
                textBoxCategory.Enabled = true;
                checkedListBoxTech.Visible = false;
                checkedListBoxSub.Visible = false;
                radioButtonTech.Visible = false;
                radioButtonSub.Visible = false;
            }
            if (comboBoxCategory.SelectedItem.ToString() == "Статус")
            {
                textBoxCategory.Enabled = true;
                checkedListBoxTech.Visible = false;
                checkedListBoxSub.Visible = false;
                radioButtonTech.Visible = false;
                radioButtonSub.Visible = false;
            }
            if (comboBoxCategory.SelectedItem.ToString() == "Технология/Предметы")
            {
                textBoxCategory.Text = "";
                buttonSearch.Enabled = true;
                textBoxCategory.Enabled = false;
                checkedListBoxTech.Visible = true;
                checkedListBoxSub.Visible = true;
                radioButtonTech.Visible = true;
                radioButtonSub.Visible = true;

                checkedListBoxTech.Enabled = false;
                checkedListBoxSub.Enabled = false;

                var tech = dataEntities.Technology;
                var subjects = dataEntities.Subject;

                foreach (var i in tech)
                    checkedListBoxTech.Items.Add(i.Title);

                foreach (var i in subjects)
                    checkedListBoxSub.Items.Add(i.SubjectTitle);
            }
        }

        private void radioButtonTech_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBoxTech.Enabled = true;
            checkedListBoxSub.Enabled = false;
        }

        private void radioButtonSub_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBoxTech.Enabled = false;
            checkedListBoxSub.Enabled = true;
        }

        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewWorkers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)   /*переход на выбранного сотрудника*/
        {
            int num = Convert.ToInt32(dataGridViewWorkers.CurrentRow.Cells[0].Value);
            Anketa f = new Anketa(num, id_user);
            f.Show();
        }
    }
}
