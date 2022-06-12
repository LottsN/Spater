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
    public partial class Form2 : MaterialForm, IRegisterView
    {
        public static Form2 instance;

        public Form2()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.Green600, Accent.DeepPurple400, TextShade.WHITE);
            instance = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            edEmail.Text = Form1.instance.dataLogin.Text;
            edPassword.Text = Form1.instance.dataPassword.Text;
        }

        private void OpenLoginForm()
        {
            this.Hide();
            Form1 f = new Form1();
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            f.Show();
        }

        private void OpenAppForm()
        {
            this.Hide();
            Form3 f = new Form3(
                /*edEmail.Text, edPassword.Text*/
                );
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            f.Show();
        }


        private void materialButton2_Click(object sender, EventArgs e)
        {
            /*
            OpenForm1();
            th = new Thread(OpenForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
            */
            OpenLoginForm();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*
            int x = Application.OpenForms.Count;
            Console.WriteLine(x.ToString());
            for (int i = x - 1; i < x - 1; i++)
            {
                Application.OpenForms[i].Dispose();
            }
            int y = Application.OpenForms.Count;
            Console.WriteLine(y.ToString());
            */
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (edPassword.Text != edPasswordConfirm.Text)
            {
                edName.Text = "Passwords don't match"; 
                break;
            }
            if (authService.Register(edEmail.Text, edName.Text, edPassword.Text)) OpenAppForm();
            else edName.Text = "Wrong data";
        }
    }
}
