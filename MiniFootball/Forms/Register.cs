using MiniFootball.DAL;
using MiniFootball.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniFootball.Extensions;
using System.Data.SqlClient;
using MiniFootball.Models;

namespace MiniFootball.Forms
{
    public partial class Register : Form
    {
        GameDbContext db = null;
        public Register()
        {
            InitializeComponent();
        }

        private async void btn_register_Click(object sender, EventArgs e)
        {
            RegisterModel model = new RegisterModel
            {
                Name = txbx_name.Text,
                Surname = txbx_surname.Text,
                BirthDate = dtp_datebirth.Value,
                Password = txbx_pwd.Text,
                ConfirmPassword = txbx_cpwd.Text,
                Email = txbx_email.Text,
                RoleId = 2
               
            };
            Tuple<bool, List<ValidationResult>> results = this.CustomValidator(model);
            if (results.Item1)
            {
                try
                {
                    User user = model;
                    db = new GameDbContext();
                    User findedUser = await db.Users.GetUserByEmailAsync(user.Email);
                    if (findedUser != null) MessageBox.Show("There is profile with this email");
                    else
                    {
                        db.Users.Add(user);
                        await db.SaveChangesAsync();
                    }
                    

                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Database Error :" + " " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show( ex.Message);
                }
                finally
                {
                    if (db != null)
                        db.Dispose();

                }
            }
            else
            {
                lbl_errors.Text = "";
                foreach (ValidationResult item in results.Item2)
                {
                    lbl_errors.Text = item.ErrorMessage + "\n";
                }
            }
        }
    }
}
