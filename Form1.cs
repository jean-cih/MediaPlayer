using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaPlayer
{
    public partial class MediaForm : Form
    {
        string[] paths, files;
        bool flag = false;
        bool lang = false;
        bool mess = true;
        string play = "";

        public MediaForm()
        {
            InitializeComponent();
        }

        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[trackList.SelectedIndex];
            player.Ctlcontrols.play();
            timer1.Start();
            trackBar.Value = 50;
            player.settings.volume = trackBar.Value;
            lbl_volume.Text = trackBar.Value.ToString() + "%";
            lbl_msg.Visible = false;
            lbl_msg.Visible = true;
            btn_play.Visible = false;
            btn_pause.Visible = true;
        }

        private async void playing()
        {
            if (trackList.Items.Count == 0)
            {
                return;
            }
            while (flag)
            {
                if (!lang)
                {
                    play = "Playing";
                }
                else
                {
                    play = "Играет";
                }
                lbl_msg.Text = play;
                await Task.Delay(500);
                lbl_msg.Text = play + ".";
                await Task.Delay(500);
                lbl_msg.Text = play + "..";
                await Task.Delay(500);
                lbl_msg.Text = play + "...";
                await Task.Delay(500);
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
            lbl_msg.Visible = true;
            lbl_roll.Visible = false;
            btn_play.Visible = false;
            btn_pause.Visible = true;
            flag = true;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (trackList.Items.Count == 0)
            {
                return;
            }
            player.Ctlcontrols.pause();
            lbl_msg.Visible = false;
            lbl_roll.Visible = true;
            if (!lang)
            {
                lbl_roll.Text = "Pause";
            }
            else
            {
                lbl_roll.Text = "Пауза";
            }
            flag = false;
            btn_pause.Visible = false;
            btn_play.Visible = true;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            progressBar.Value = 0;
            flag = true;
            lbl_msg.Visible = true;
            lbl_roll.Visible = false;
            btn_pause.Visible = true;
            btn_play.Visible = false;
            player.Ctlcontrols.play();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(trackList.SelectedIndex < trackList.Items.Count - 1)
            {
                trackList.SelectedIndex += 1;
            }
            btn_pause.Visible = true;
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if(trackList.SelectedIndex > 0)
            {
                trackList.SelectedIndex -= 1;
            }
            btn_pause.Visible = true;
        }

        Random rand = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        { 
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar.Value = (int)player.Ctlcontrols.currentPosition;
            }
            lbl_track_start.Text = player.Ctlcontrols.currentPositionString.ToString();
            lbl_track_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();

            if (lbl_track_start.Text == lbl_track_end.Text && trackList.SelectedIndex < trackList.Items.Count - 1 && mess)
            {
                trackList.SelectedIndex += 1;
            }
            else if (lbl_track_start.Text == lbl_track_end.Text && trackList.SelectedIndex < trackList.Items.Count - 1 && !mess)
            {
                trackList.SelectedIndex = rand.Next(0, trackList.Items.Count - 1);
            }
            else if(lbl_track_start.Text == lbl_track_end.Text && trackList.SelectedIndex == trackList.Items.Count - 1)
            {
                trackList.SelectedIndex = 0;
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar.Value;
            lbl_volume.Text = trackBar.Value.ToString() + "%";
        }

        private void progressBar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / progressBar.Width;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_play_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            playing();
        }

        private void trackList_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            playing();
        }

        private async void delay()
        {
            lbl_roll_ten.Visible = true;
            await Task.Delay(500);
            lbl_roll_ten.Visible = false;
        }

        private void btn_slow_Click(object sender, EventArgs e)
        {
            player.settings.rate = 0.5f;
        }

        private void btn_norm_Click(object sender, EventArgs e)
        {
            player.settings.rate = 1.0f;
        }

        private void btn_fast_Click(object sender, EventArgs e)
        {
            player.settings.rate = 1.5f;
        }

        private void btn_lang_Click(object sender, EventArgs e)
        {
            if (!lang)
            {
                btn_lang.Text = "Rus";
                lang = true;
                btn_next.BackgroundImage = Properties.Resources.Вперед;
                btn_prev.BackgroundImage = Properties.Resources.Назад;
                btn_open.BackgroundImage = Properties.Resources.Файлы;
                btn_stop.BackgroundImage = Properties.Resources.Заново;
                btn_play.BackgroundImage = Properties.Resources.Начать;
                btn_pause.BackgroundImage = Properties.Resources.Пауза;
                btn_mess.Text = "Цикл выкл";
            }
            else
            {
                btn_lang.Text = "Eng";
                lang = false;
                btn_next.BackgroundImage = Properties.Resources.Next;
                btn_prev.BackgroundImage = Properties.Resources.Previous;
                btn_open.BackgroundImage = Properties.Resources.Open;
                btn_stop.BackgroundImage = Properties.Resources.Reset;
                btn_play.BackgroundImage = Properties.Resources.Play;
                btn_pause.BackgroundImage = Properties.Resources.Pause;
                btn_mess.Text = "mess off";
            }
        }

        private void btn_mess_Click(object sender, EventArgs e)
        {
            if(trackList.Items.Count == 0)
            {
                return;
            }
            if (mess)
            {
                if (!lang)
                {
                    btn_mess.Text = "mess on";
                }
                else
                {
                    btn_mess.Text = "цикл вкл";
                }
                mess = false;
            }
            else
            {
                if (!lang)
                {
                    btn_mess.Text = "mess off";
                }
                else
                {
                    btn_mess.Text = "цикл выкл";
                }
                mess = true;
            }
        }

        private void player_MouseDownEvent(object sender, AxWMPLib._WMPOCXEvents_MouseDownEvent e)
        {
            if(trackList.Items.Count == 0)
            {
                return;
            }
            if (e.fX < player.Width / 2) 
            {
                player.Ctlcontrols.currentPosition -= 10;
                if (!lang)
                {
                    lbl_roll_ten.Text = "- 10 seconds";
                }
                else
                {
                    lbl_roll_ten.Text = "- 10 секунд";
                }
                delay();
            }
            else
            {
                player.Ctlcontrols.currentPosition += 10;
                if (!lang)
                {
                    lbl_roll_ten.Text = "+ 10 seconds";
                }
                else
                {
                    lbl_roll_ten.Text = "+ 10 секунд";
                }
                delay();
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            trackList.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for(int x = 0; x < files.Length; x++)
                {
                    trackList.Items.Add(files[x]);
                }
            }
        }
    }
}
