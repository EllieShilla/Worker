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
using System.Net.Mail;
using System.Net;

namespace Workers
{
    public partial class Letter : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        OpenFileDialog ofd;
        string filepath;
        string Mail;
        int id_user;
        public Letter(string mail)
        {
            InitializeComponent();
            Mail = mail;

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme("#003e64", "#001932", "#003e64", "#0091c8", TextShade.WHITE);
        }

        public Letter(string mail,int id)
        {
            InitializeComponent();
            Mail = mail;
            id_user = id;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme("#003e64", "#001932", "#003e64", "#0091c8", TextShade.WHITE);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage("itstep2810@gmail.com", Mail, textBoxTheme.Text, textBoxMessage.Text);
            SmtpClient client = new SmtpClient("smtp.office365.com");
            client.Port = 587;
            //client.Port = 25;

            client.Credentials = new NetworkCredential("itstep2810@gmail.com", "ITstep2020");
            client.EnableSsl = true;
            foreach (var item in listBoxAttach.Items)
            {
                mail.Attachments.Add(new Attachment(item.ToString()));
            }
            client.SendAsync(mail, "That's all");
            MessageBox.Show("Send complite");
            this.Close();
        }

        private void buttonAttach_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                listBoxAttach.Items.Add(filepath);
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm(id_user);
            f.Show();
            Close();
        }

        private void listBoxAttach_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxAttach.SelectedIndex >= 0)
            {
                listBoxAttach.Items.RemoveAt(listBoxAttach.SelectedIndex);
            }
            else
                MessageBox.Show("Выберите файл!!!");
        }
    }
}
