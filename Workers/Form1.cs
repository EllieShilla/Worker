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
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme("#003e64", "#001932", "#003e64", "#0091c8", TextShade.WHITE);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            //login.Text = XOR(login.Text);
            Enter();
        }

        public string XOR(string text)
        {
            StringBuilder szInputStringBuild = new StringBuilder(text);
            StringBuilder szOutStringBuild = new StringBuilder(text.Length);

            char Textch;
            for (int iCount = 0; iCount < text.Length; iCount++)
            {
                Textch = szInputStringBuild[iCount];
                Textch = (char)(Textch ^ 7534);
                szOutStringBuild.Append(Textch);
            }

            return szOutStringBuild.ToString();
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enter();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enter();
            }
        }

        private void Enter()
        {
            //login.Text = XOR(login.Text);
            DataEntities db = new DataEntities();
            int id = 0;
            var buff = db.Users;
            bool check = false;


            foreach (var q in buff)
            {
                if (XOR(q.Login) == login.Text && XOR(q.Password) == password.Text)
                {
                    id = q.id;
                    check = true;
                    break;
                }
            }

            if (check != false)
            {
                MainForm mainForm = new MainForm(id);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введен неверный логин или пароль");
            }
        }
    }
}
