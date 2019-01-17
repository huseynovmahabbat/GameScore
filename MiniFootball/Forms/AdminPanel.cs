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
        List<Player> freePlayers = null;
        List<PlayerModel> playerModels = new List<PlayerModel>();
        List<int> selectedPlayersId = new List<int>();
        public AdminPanel()
        {
            InitializeComponent();
        }

        private async void AdminPanel_Load(object sender, EventArgs e)
        {
            try
            {
                db = new GameDbContext();
               freePlayers = await db.Players.GetFreePlayersAsync();
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
                db = new GameDbContext();
                foreach (Player player in freePlayers)
                {
                    playerModels.Add(new PlayerModel
                    {
                        Id = player.Id,
                        FullName = player.Name + " " + player.Surname,
                        Position = player.Postion,
                        Age = this.CalculateAge(player.BirthDate)
                    });
                }

                foreach (PlayerModel model in playerModels)
                {
                   
                        model.Skills = db.Players.GetPlayerSkills(model.Id);
                };

                 CreatePlayerControl(playerModels,0,3);
                 Session.SetValue("PlayerCount", 3);
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
        //Load Photo From Computer
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
                    Team team = new Team
                    {
                        EstablishmentDate = dtp_estabdate.Value,
                        Name = txbx_name.Text,
                        Logo = (byte[])new ImageConverter().ConvertTo(pictureBox1.Image, typeof(byte[]))
                    };
                    db.Teams.Add(team);
                    await db.SaveChangesAsync();
                    if (selectedPlayersId.Count >= 11)
                    {
                        foreach (int item in selectedPlayersId)
                        {
                            Player selectedPlayer = await db.Players.GetUserByIdAsync(item);
                            selectedPlayer.Id = team.Id;
                        }
                        await db.SaveChangesAsync();
                    }
                    else
                        MessageBox.Show("You must select 11 players");
                  
                    
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                   
                }

            }
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            int count = (int)Session.GetValue("PlayerCount");
            if (count-3 <= 0)
            {
                MessageBox.Show("You are on the first page.");
            }
            
            else
            {
                foreach (Control control in tbg_teamadd.Controls.OfType<GroupBox>())
                {
                    foreach (CheckBox item in control.Controls.OfType<CheckBox>())
                    {
                        if (item.Checked)
                        {
                            selectedPlayersId.Add((int)item.Tag);
                        }
                    }
                    if ( control.Text== "Players")
                        tbg_teamadd.Controls.Remove(control);
                }

                int skipCount = count - 6;
                CreatePlayerControl(playerModels, skipCount, 3);
                Session.SetValue("PlayerCount", skipCount + 3);
                
            }

        }
        private void nextBtn_Click(object sender,EventArgs e)
        {
            
            
            int skipCount = (int)Session.GetValue("PlayerCount");
            if (skipCount == playerModels.Count)
            {
                MessageBox.Show("Don't have players");
            }
            else
            {
                foreach (Control control in tbg_teamadd.Controls.OfType<GroupBox>())
                {
                    foreach (PlayerControl item in control.Controls.OfType<PlayerControl>())
                    {

                        if (item.chb_selectplayer.Checked)
                        {
                            selectedPlayersId.Add((int)item.Tag);
                        }
                    }
                    if (control.Text == "Players")
                        tbg_teamadd.Controls.Remove(control);
                }
                CreatePlayerControl(playerModels, skipCount, 3);
                Session.SetValue("PlayerCount", skipCount + 3);
            }
            
        

        }

        private void CreatePlayerControl(List<PlayerModel> models,int SkipCount,int Count)
        {
            int controlY = 35;
            int BtnY = 133;
            GroupBox grp_players = new GroupBox
            {
                Location = new Point(300, 18),
                Size = new Size(550, 450),
                Text = "Players"
            };
            if(SkipCount<=0)
            {
                foreach (PlayerModel player in models.Take(Count))
                {

                    PlayerControl playerControl = new PlayerControl();
                    playerControl.Location = new Point(0, controlY);
                    playerControl.txbx_age.Text = player.Age.ToString();
                    playerControl.txbx_email.Text = player.Position;
                    playerControl.txbx_fullname.Text = player.FullName;
                    playerControl.chb_selectplayer.Tag = player.Id;
                    grp_players.Controls.Add(playerControl);
                    controlY += 100;
                    BtnY += 70;


                }
            }
            else
            {
                foreach (PlayerModel player in models.Skip(SkipCount).Take(Count))
                {

                    PlayerControl playerControl = new PlayerControl();
                    playerControl.Location = new Point(0, controlY);
                    playerControl.txbx_age.Text = player.Age.ToString();
                    playerControl.txbx_email.Text = player.Position;
                    playerControl.txbx_fullname.Text = player.FullName;
                    grp_players.Controls.Add(playerControl);
                    controlY += 100;
                    BtnY += 70;


                }
            }
           
            Button nextBtn = new Button
            {
                Text = "Next",
                Location = new Point(420, BtnY),
                Size = new Size(125, 51)

            };

            Button prevBtn = new Button
            {
                Text = "Prev",
                Location = new Point(295, BtnY),
                Size = new Size(125, 51)

            };
            nextBtn.Click += nextBtn_Click;
            prevBtn.Click += prevBtn_Click;

            grp_players.Controls.AddRange(new Control[] {  nextBtn, prevBtn });
            tbg_teamadd.Controls.Add(grp_players);
        }

       
    }
}
