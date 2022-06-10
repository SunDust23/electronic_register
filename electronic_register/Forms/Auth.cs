using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace electronic_register
{
    public partial class Auth : Form
    {
        public Main Main;
        public Auth()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.ToString();
            string password = textBox2.Text.ToString();

            var dict = new Dictionary<string, string>();

            dict.Add("petuh", "1234");
            dict.Add("petya", "pass");
            dict.Add("admin", "qwerty");

            if (dict.ContainsKey(login))
            {
                if (dict[login] == password)
                {
                    MessageBox.Show("Добро пожаловать, " + login);

                    Main = new Main
                    {
                        Tag = this
                    };
                    Main.Show();

                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином не существует");
            }


        }
    }
}
