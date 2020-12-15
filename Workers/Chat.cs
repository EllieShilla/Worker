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
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace Workers
{
    public partial class Chat : MaterialForm
    {
        //Users u = dataEntities.Users.Find(Id);
        //u.isonline = offline;
        //dataEntities.SaveChanges();

        int id_user;
        Form1 f = null;
        TextBox[] textBoxes;
        Thread thread = null;
        UdpClient client;
        DataEntities dataEntities;
        string host = null;
        int? remote_port = null;
        int? local_port = 1024;
        IPEndPoint endPoint;

        int count_txt;
        int pointX = 182;
        int pointY = 195;
        int sizeW = 606;
        int sizeY = 343;


        private readonly MaterialSkinManager materialSkinManager;
        delegate void UpdateTextDelegate(string msg);
        public Chat()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme("#003e64", "#001932", "#003e64", "#0091c8", TextShade.WHITE);
            dataEntities = new DataEntities();
        }
        public Chat(int id)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme("#003e64", "#001932", "#003e64", "#0091c8", TextShade.WHITE);
            dataEntities = new DataEntities();
            id_user = id;
            var login = (from t in dataEntities.Users where t.id == id select t).FirstOrDefault();

            label4.Text = XOR(login.Login);
            add_users();
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

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new UdpClient();

            string msg = $"{textBox1.Text}";

            byte[] buff = Encoding.Default.GetBytes(msg);

            try
            {
                client.Send(buff, buff.Length, endPoint);
                string str = Encoding.Default.GetString(buff);
                textBoxes[count_txt].BeginInvoke(new UpdateTextDelegate(AddText), str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                client.Close();
            }

            textBox1.Clear();
        }

        private void AddText(string str)
        {
            var sb = new StringBuilder(textBoxes[count_txt].Text);
            sb.AppendLine(str);
            textBoxes[count_txt].Text = sb.ToString();
        }

        private void ReceiveMessages()
        {
            UdpClient client = null;

            try
            {
                client = new UdpClient((int)local_port);
                var address = IPAddress.Parse("224.5.5.5");

                client.JoinMulticastGroup(address, 10);

                while (true)
                {
                    IPEndPoint remoteEP = null;
                    byte[] buff = client.Receive(ref remoteEP);
                    string str = Encoding.Default.GetString(buff);
                    textBoxes[count_txt].BeginInvoke(new UpdateTextDelegate(AddText), str);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (client != null)
                {
                    client.Close();
                }
            }
            finally
            {
                client.Close();
            }

        }
        void add_users()
        {
            var tmp1 = (from t in dataEntities.Users select new { Name = t.Name, Surname = t.Surname, port = t.port, host = t.IP, login = t.Login });

            foreach (var item1 in tmp1)
            {
                if (item1.login != label4.Text)
                {
                    listBox1.Items.Add(item1.Name + " " + item1.Surname);
                }
            }
        }

        void add_local_port()
        {
            var tmp = (from t in dataEntities.Users select new { Name = t.Name, Surname = t.Surname, port = t.port, host = t.IP, login = t.Login });

            var login = (from t in dataEntities.Users where t.id == id_user select t).FirstOrDefault();

            foreach (var item in tmp)
            {
                if (item.login == XOR(login.Login))
                {
                    local_port = item.port;
                }
            }
        }

        void add_remote_port()
        {
            var tmp = (from t in dataEntities.Users select new { Name = t.Name, Surname = t.Surname, port = t.port, host = t.IP, login = t.Login });

            foreach (var item in tmp)
            {
                if ((item.Name + " " + item.Surname == listBox1.SelectedItem.ToString()))
                {
                    remote_port = item.port;
                    host = item.host;
                }
            }

        }

        private void Chat_Load(object sender, EventArgs e)
        {
            textBoxes = new TextBox[listBox1.Items.Count];
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string is_online = null;
            var tmp1 = (from t in dataEntities.Users select new { is_online = t.IsOnline, Name = t.Name, Surname = t.Surname });
            foreach (var item in tmp1)
            {
                if ((item.Name + " " + item.Surname == listBox1.SelectedItem.ToString()))
                {
                    is_online = item.is_online;
                }
            }

            if (is_online != "offline")
            {
                try
                {
                    label2.Visible = false;
                    count_txt = listBox1.SelectedIndex;
                    add_remote_port();

                    IPAddress remoteIP = IPAddress.Parse(host);
                    int remotePort = (int)remote_port;
                    endPoint = new IPEndPoint(remoteIP, remotePort);


                    button1.Enabled = true;
                    if (textBoxes[count_txt] != null)
                    {
                        for (int i = 0; i < textBoxes.Length; i++)
                        {
                            if (textBoxes[count_txt] == textBoxes[i])
                            {
                                textBoxes[i].Visible = true;
                            }
                        }
                        textBox3.Text = listBox1.SelectedItem.ToString();
                    }
                    else
                    {
                        textBoxes[count_txt] = new TextBox();
                        textBoxes[count_txt].Multiline = true;
                        textBoxes[count_txt].Size = new Size(sizeW, sizeY);
                        textBoxes[count_txt].Location = new Point(pointX, pointY);

                        this.Controls.Add(textBoxes[count_txt]);

                        for (int i = 0; i < textBoxes.Length; i++)
                        {
                            if (textBoxes[i] != null)
                            {
                                if (textBoxes[count_txt] != textBoxes[i])
                                {
                                    textBoxes[i].Visible = false;
                                }
                            }
                        }
                        textBox3.Text = listBox1.SelectedItem.ToString();
                    }


                    add_local_port();

                    if (thread != null)
                        return;

                    thread = new Thread(ReceiveMessages);
                    thread.IsBackground = true;

                    thread.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("User is offline", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm(id_user);
            f.Show();
            Close();
        }
    }
}
