using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace rrt
{
    public partial class Form1 : MaterialForm
    {
        public static Form1 instance;
        public MaterialTextBox dataLogin;
        public MaterialTextBox dataPassword;

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.Green600, Accent.DeepPurple400, TextShade.WHITE);
            instance = this;
            dataLogin = edLogin;
            dataPassword = edPassword;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            throw new NotImplementedException();
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //panelChildForm.Controls.Add(childForm);
            //panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OpenAppForm()
        {
            this.Hide();
            Form3 f = new Form3(
                /*dataLogin.Text, dataPassword.Text*/
                );
            //Application.Run(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
            f.Focus();
        }

        private void OpenRegisterForm()
        {
            this.Hide();
            Form2 f = new Form2(); // This is bad
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
            f.Focus();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            OpenAppForm();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            OpenRegisterForm();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
