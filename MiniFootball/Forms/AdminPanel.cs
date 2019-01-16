using MiniFootball.DAL;
using MiniFootball.Extensions;
using MiniFootball.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public AdminPanel()
        {
            InitializeComponent();
        }

        private async void AdminPanel_Load(object sender, EventArgs e)
        {
            try
            {
                db = new GameDbContext();
                List<User> freePlayers = await db.Users.GetFreePlayersAsync();
                dataGridView1.DataSource = freePlayers;
                
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

        private void btn_loadphoto_Click(object sender, EventArgs e)
        {
            DialogResult result = openPhotoDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openPhotoDialog.FileName);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                db = new GameDbContext();
               
                db.Teams.Add(new Team
                {
                    EstablishmentDate = dtp_estabdate.Value,
                    Name = txbx_name.Text,
                    Logo = (byte[])new ImageConverter().ConvertTo(pictureBox1.Image, typeof(byte[]))
                });

            }
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
