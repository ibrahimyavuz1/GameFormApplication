using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Lab1
{
    public partial class form_SignUp : Form
    {
        private User usedUser=new User() { };
        private form_MainGame form_MainGame = new form_MainGame();
        List<User> users = new List<User>();   
        public form_SignUp(form_MainGame form_MainGame)
        {
            InitializeComponent();
            this.form_MainGame=form_MainGame;
        }

        private void button_CreateUser_Click(object sender, EventArgs e)
        {
            users= form_MainGame.GetAllUsers();
            bool flag= false;
            int id = 99; //default, but it has to be changed.
            int i = 0;
            foreach(User us in users)
            {
                if (i != us.Id)
                {
                    id = i;
                    flag = true;
                }
                i++;
            }
            if (flag == false)
            {
                id = users.Count() + 1;
            }
            User user = new User() {Id= id,Username=textBox_Username.Text, Password=textBox_Password.Text, NameSurname=textBox_NameSurname.Text, PhoneNumber=textBox_PhoneNumber.Text, Address=textBox_Adress.Text, City=textBox_City.Text, Country=textBox_Country.Text, Email=textBox_Email.Text};
            form_MainGame.AddNewUser(user);

        }

    }
}
