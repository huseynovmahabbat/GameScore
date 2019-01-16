using MiniFootball.Controls;
using MiniFootball.DAL;
using MiniFootball.Extensions;
using MiniFootball.Infrastructures;
using MiniFootball.Models;
using MiniFootball.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniFootball.Forms
{
    public partial class AdminPanel : Form
    {
        GameDbContext db = null;
        List<User> freePlayers = null;
        List<PlayerModel> playerModels = new List<PlayerModel>();
        public AdminPanel()
        {
            InitializeComponent();
        }

        private async void AdminPanel_Load(object sender, EventArgs e)
        {
            try
            {
                db = new GameDbContext();
               
freePlayers = await db.Users.GetFreePlayersAsync();
               
               
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
            try
            {
                foreach (User player in freePlayers)
                {
                    playerModels.Add(new PlayerModel
                    {
                        Email = player.Email,
                        Id = player.Id,
                        FullName = player.Name + " " + player.Surname,
                        Age = this.CalculateAge(player.BirthDate)
                    });
                }

                    CreatePlayerControl(playerModels);
                    Session.SetValue("PlayerCount", 10);
                
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btn_loadphoto_Click(object sender, EventArgs e)
        {
            DialogResult result = openPhotoDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openPhotoDialog.FileName);
            }
        }

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {

                db = new GameDbContext();
                DbContextTransaction transaction = db.Database.BeginTransaction();
                try
                {
                    db.Teams.Add(new Team
                    {
                        EstablishmentDate = dtp_estabdate.Value,
                        Name = txbx_name.Text,
                        Logo = (byte[])new ImageConverter().ConvertTo(pictureBox1.Image, typeof(byte[]))
                    });
                    await db.SaveChangesAsync();
                    
                }
                catch (Exception)
                {

                    throw;
                }
               

            }
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

       private  void prevBtn_Click(object sender,EventArgs e)
        {
            if (Controls.Contains((Control)Activator.CreateInstance(typeof(PlayerControl))))
            {
               
            }
        }
        private void CreatePlayerControl(List<PlayerModel> models)
        {
            int controlY = 67;
            int BtnY = 184;

            foreach (PlayerModel player in models.Take(10))
            {

                PlayerControl playerControl = new PlayerControl();
                playerControl.Location = new Point(449, controlY);
                playerControl.txbx_age.Text = player.Age.ToString();
                playerControl.txbx_email.Text = player.Email;
                playerControl.txbx_fullname.Text = player.FullName;
                Button nextBtn = new Button
                {
                    Text = "Next",
                    Location = new Point(1035, BtnY),
                    Size = new Size(125, 51)

                };
                Button prevBtn = new Button
                {
                    Text = "Prev",
                    Location = new Point(883, BtnY),
                    Size = new Size(125, 51)

                };
                tbg_teamadd.Controls.AddRange(new Control[] { playerControl, nextBtn, prevBtn });
                controlY += 220;
                BtnY += 220;


            }
        }
    }
}
