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
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace Workers
{
    public partial class Anketa : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        DataEntities dataEntities;
        PositionEmployee positionEmployee;
        EmployeeTable employeeTable;
        Image image;
        byte[] bytes;
        int id_user = 0;
        int idEmp;
        int id = 0;
        string emailPattern = @"^[\w!#$%&'+-/=?\^_`{|}~]+(.[\w!#$%&'+-/=?\^_`{|}~]+)*"//регулярное выражение
+ "@"
+ @"((([-\w]+.)+[a-zA-Z]{2,4})|(([0-9]{1,3}.){3}[0-9]{1,3}))$";
        public Anketa(int id_user)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme("#003e64", "#001932", "#003e64", "#0091c8", TextShade.WHITE);

            buttonSaveAnketa.BackColor = Color.FromArgb(0, 62, 100);
            //buttonSend.BackColor = Color.FromArgb(0, 62, 100);
            button2.BackColor = Color.FromArgb(0, 62, 100);
            button3.BackColor = Color.FromArgb(0, 62, 100);

            label22.ForeColor = Color.FromArgb(0, 62, 100);
            label20.ForeColor = Color.FromArgb(0, 62, 100);
            label21.ForeColor = Color.FromArgb(0, 62, 100);
            label1.ForeColor = Color.FromArgb(0, 62, 100);
            label2.ForeColor = Color.FromArgb(0, 62, 100);
            label3.ForeColor = Color.FromArgb(0, 62, 100);
            label4.ForeColor = Color.FromArgb(0, 62, 100);
            label5.ForeColor = Color.FromArgb(0, 62, 100);
            label6.ForeColor = Color.FromArgb(0, 62, 100);
            label7.ForeColor = Color.FromArgb(0, 62, 100);
            label8.ForeColor = Color.FromArgb(0, 62, 100);
            label14.ForeColor = Color.FromArgb(0, 62, 100);
            this.id_user = id_user;

            toolTip1.SetToolTip(buttonHome, "Домой");
            toolTip1.SetToolTip(buttonImport, "Импорт резюме");
            toolTip1.SetToolTip(buttonView, "Просмотр резюме");
            dataEntities = new DataEntities();
            var jops = from k in dataEntities.Position select k;
            foreach (var item in jops)
            {
                comboBoxPost.Items.Add(item.Title);
            }
            var jop = from l in dataEntities.PositionEmployee
                      join k in dataEntities.Position on l.IDPosition equals k.id
                      join f in dataEntities.EmployeeTable on l.IDEmployee equals f.id
                      select new { Title = k.Title, Name = f.Name, Surname = f.Surname };
            dataGridViewPost.DataSource = jop.ToList();

            CommentInf();
        }

        public Anketa(int id, int id_user)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme("#003e64", "#001932", "#003e64", "#0091c8", TextShade.WHITE);
            buttonSaveAnketa.BackColor = Color.FromArgb(0, 62, 100);
            //buttonSend.BackColor = Color.FromArgb(0, 62, 100);
            button2.BackColor = Color.FromArgb(0, 62, 100);
            button3.BackColor = Color.FromArgb(0, 62, 100);

            label22.ForeColor = Color.FromArgb(0, 62, 100);
            label20.ForeColor = Color.FromArgb(0, 62, 100);
            label21.ForeColor = Color.FromArgb(0, 62, 100);
            label1.ForeColor = Color.FromArgb(0, 62, 100);
            label2.ForeColor = Color.FromArgb(0, 62, 100);
            label3.ForeColor = Color.FromArgb(0, 62, 100);
            label4.ForeColor = Color.FromArgb(0, 62, 100);
            label5.ForeColor = Color.FromArgb(0, 62, 100);
            label6.ForeColor = Color.FromArgb(0, 62, 100);
            label7.ForeColor = Color.FromArgb(0, 62, 100);
            label8.ForeColor = Color.FromArgb(0, 62, 100);
            label14.ForeColor = Color.FromArgb(0, 62, 100);

            toolTip1.SetToolTip(buttonHome, "Домой");
            toolTip1.SetToolTip(buttonImport, "Импорт резюме");
            toolTip1.SetToolTip(buttonView, "Просмотр резюме");
            this.id = id;
            this.id_user = id_user;
            Updt(this.id);
            CommentInf();
        }

        void Updt(int id)
        {
            dataEntities = new DataEntities();
            var cs = from c in dataEntities.EmployeeTable
                     where c.id == id
                     select c
                     ;
            foreach (var item in cs)
            {
                textBoxSurname.Text = item.Surname;
                textBoxName.Text = item.Name;
                textBoxPatronymic.Text = item.Patronymic;
                dateTimePickerBirthday.Value = item.DateOfBirth/*.Value*/;
                textBoxAdress.Text = item.Address;
                textBoxEmail.Text = item.Email;
                textBoxPhone.Text = item.Phone;
                var temp = from s in dataEntities.Status
                           select s;
                foreach (var item1 in temp)
                {
                    if (item1.id == item.IDStatus)
                    {
                        label9.Text = item1.Title;
                        break;
                    }
                }
                // pictureBox.Image =  imageToByteArray(item.Photo)  /////????????
                //comboBox1.SelectedIndex = item.IDStatus - 1;
            }

        }

        private void buttonSaveAnketa_Click(object sender, EventArgs e)
        {
            try
            {

                EmployeeTable emp = null;
                if (emp == dataEntities.EmployeeTable.Find(id))
                {
                    emp.Name = textBoxName.Text;
                    emp.Surname = textBoxSurname.Text;
                    emp.Patronymic = textBoxPatronymic.Text;
                    emp.DateOfBirth = dateTimePickerBirthday.Value;
                    emp.Address = textBoxAdress.Text;
                    emp.Email = textBoxEmail.Text;
                    emp.Phone = textBoxPhone.Text;
                    emp.IDStatus = 1; //1 if 1 = kandidat 
                    emp.Photo = bytes;
                    dataEntities.SaveChanges();
                    Updt(id);

                }
                else
                {
                    emp = new EmployeeTable();
                    emp.Name = textBoxName.Text;
                    emp.Surname = textBoxSurname.Text;
                    emp.Patronymic = textBoxPatronymic.Text;
                    emp.DateOfBirth = dateTimePickerBirthday.Value;
                    emp.Address = textBoxAdress.Text;
                    emp.Phone = textBoxPhone.Text;
                    emp.Email = textBoxEmail.Text;
                    var temp = from k in dataEntities.Status
                               join s in dataEntities.EmployeeTable on k.id equals s.IDStatus
                               where s.Name.ToLower() == textBoxName.Text.ToLower() && s.Surname.ToLower() == textBoxName.Text.ToLower()
                               select k;
                    foreach (var item in temp)
                    {
                        if (item.Title.ToLower() == label9.Text.ToLower())
                        {
                            emp.IDStatus = item.id;
                            break;
                        }
                    }
                    emp.Photo = bytes;

                    dataEntities.EmployeeTable.Add(emp);
                    dataEntities.SaveChanges();
                    Updt(id);

                }

                MessageBox.Show("SAVE OK!");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image Files(*.JPG;*.GIF;*.PNG)|*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            try
            {
                image = new Bitmap(openFileDialog1.FileName);
                pictureBox.Image = image;
                bytes = CreateCopy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Gif);
            return ms.ToArray();
        }

        private byte[] CreateCopy()
        {
            Image img = Image.FromFile(openFileDialog1.FileName);
            int MW = 300, MH = 300;
            double rX = (double)MW / img.Width;
            double rY = (double)MH / img.Height;
            double r = Math.Min(rX, rY);
            int newW = (int)(img.Width * r);
            int newH = (int)(img.Height * r);
            Image im = new Bitmap(newW, newH);
            Graphics g = Graphics.FromImage(im);
            g.DrawImage(img, 0, 0, newW, newH);
            MemoryStream ms = new MemoryStream();
            im.Save(ms, ImageFormat.Jpeg);
            ms.Flush();
            ms.Seek(0, SeekOrigin.Begin);
            BinaryReader br = new BinaryReader(ms);
            byte[] buf = br.ReadBytes((int)ms.Length);
            return buf;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text != " ")
            {
                Letter f = new Letter(textBoxEmail.Text);
                f.ShowDialog();
            }

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm(id_user);
            f.Show();
            Close();
        }

        private void buttonSend_Click_1(object sender, EventArgs e)
        {

            Regex regex = new Regex(emailPattern);
            if (textBoxEmail.Text != " " && regex.IsMatch(textBoxEmail.Text))
            {
                Letter f = new Letter(textBoxEmail.Text);
                f.ShowDialog();
            }
            else
                MessageBox.Show("Email некоректный");
        }

        private void buttonAddPost_Click(object sender, EventArgs e)
        {
            positionEmployee = new PositionEmployee();
            positionEmployee.DateOfAdopting = dateTimePickerAccept.Value;
            employeeTable = new EmployeeTable();
            var koll = from k in dataEntities.EmployeeTable select new { Name = k.Name, Surname = k.Surname, ID = k.id };
            foreach (var item in koll)
            {
                if (item.Name.ToString() == textBoxName.Text && item.Surname.ToString() == textBoxSurname.Text)
                {
                    idEmp = item.ID;
                }
            }
            positionEmployee.IDEmployee = idEmp;
            var kill = from l in dataEntities.Position select new { Title = l.Title, ID = l.id };
            foreach (var item in kill)
            {
                if (item.Title == comboBoxPost.SelectedItem.ToString())
                {
                    idEmp = item.ID;
                }
            }
            positionEmployee.IDPosition = idEmp;
            dataEntities.PositionEmployee.Add(positionEmployee);
            dataEntities.SaveChanges();
            this.Update();
        }


        private void buttonSaveComment_Click(object sender, EventArgs e)    /*сохранение комментариев*/
        {
            if (textBoxComment.Text != String.Empty)
            {
                Reviews reviews = new Reviews
                {
                    IDEmployee = id,
                    IDUser = id_user,
                    Date = dateTimePickerComment.Value,
                    Comments = textBoxComment.Text
                };

                Rating rating = new Rating
                {
                    IDEmployee = id,
                    IDUser = id_user,
                    Scores = Convert.ToInt32(numericUpDownRate.Value)
                };

                dataEntities.Reviews.Add(reviews);
                dataEntities.Rating.Add(rating);
                var status = dataEntities.EmployeeTable.FirstOrDefault(i => i.id == id);
                var st = dataEntities.Status.FirstOrDefault(i => i.Title == comboBoxEtap.SelectedItem.ToString());
                status.IDStatus = st.id;
                dataEntities.SaveChanges();
                MessageBox.Show("Данные добавлены");
            }
            else
            {
                MessageBox.Show("Поле с коментарием пустое");
            }

            AllComm();
        }

        public void CommentInf()      /*вывод информации на поле с комментариями*/
        {
            var status = dataEntities.EmployeeTable.FirstOrDefault(i => i.id == id);

            var stat = dataEntities.Status;
            foreach (var i in stat)
            {
                comboBoxEtap.Items.Add(i.Title);
            }
            comboBoxEtap.SelectedItem = status.Status.Title;
            numericUpDownRate.Maximum = 5;
            numericUpDownRate.Minimum = 1;
            numericUpDownRate.Value = 1;
            Markup();
        }

        public void Markup()     /*разметка гридвью*/
        {

            DataGridViewTextBoxColumn date = new DataGridViewTextBoxColumn();
            date.Name = "Дата";
            dataGridViewComments.Columns.Add(date);
            DataGridViewTextBoxColumn surname = new DataGridViewTextBoxColumn();
            surname.Name = "Фамилия";
            dataGridViewComments.Columns.Add(surname);
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            name.Name = "Имя";
            dataGridViewComments.Columns.Add(name);
            DataGridViewTextBoxColumn pat = new DataGridViewTextBoxColumn();
            pat.Name = "Комментарий";
            dataGridViewComments.Columns.Add(pat);

            dataGridViewComments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AllComm();

        }

        public void AllComm()    /*вывод комментариев в гридвью*/
        {
            try
            {
                dataGridViewComments.Rows.Clear();
                var rev = dataEntities.Reviews.Where(i => i.IDEmployee == id);

                foreach (var i in rev)
                {
                    dataGridViewComments.Rows.Add(i.Date.ToLongDateString(), i.Users.Name, i.Users.Surname, i.Comments);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)    /*очистка тексбокса*/
        {
            textBoxComment.Text = null;
        }

        private void dataGridViewComments_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)      /*вывод комментария в текстбокс*/
        {
            try
            {
                textBoxComment.Text = dataGridViewComments.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show("Выбрано пустое поле"); }
        }
    }
}
