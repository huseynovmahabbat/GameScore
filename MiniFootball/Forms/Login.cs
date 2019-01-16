using MiniFootball.DAL;
using MiniFootball.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniFootball.Extensions;
using MiniFootball.Models;

namespace MiniFootball.Forms
{
    public partial class Login : Form
    {
        GameDbContext db = null;
        public Login()
        {
            InitializeComponent();
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            LoginModel model = new LoginModel
            {
                Email = txbx_email.Text,
                Password = txbx_pwd.Text

            };
            try
            {
                db = new GameDbContext();
                User findedUser =  await db.Users.GetUserByEmailAsync(model.Email);
                if (findedUser != null)
                {
                    Close();
                    if (findedUser.RoleId == 0)
                    {
                        
                        new AdminPanel().Show();
                    }
                    else
                    {
                        new PlayerPanel().Show();
                    }
                }
                else
                {
                    MessageBox.Show("Your email or password is incorrect");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (db != null)
                    db.Dispose();
            }
        }
    }
}
