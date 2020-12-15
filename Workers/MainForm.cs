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
    public partial class MainForm : MaterialForm
    {

        private readonly MaterialSkinManager materialSkinManager;

        int id = 0;
        public MainForm(int user_id)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme("#003e64", "#001932", "#003e64", "#0091c8", TextShade.WHITE);

            toolTip1.SetToolTip(buttonInfo, "О разработчиках");

            id = user_id;
        }

        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            EmployeeForm usersForm = new EmployeeForm(id);
            usersForm.Show();
            this.Close();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm(id);
            usersForm.Show();
            this.Close();
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            SubjectsForm sf = new SubjectsForm(id);
            sf.Show();
            this.Close();
   
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Developers dev = new Developers();
            dev.Show();
            this.Close();

        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            Chat ch = new Chat(id);
            ch.Show();
            this.Close();

        }
    }
}
