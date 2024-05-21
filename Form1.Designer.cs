namespace mediaPlayer
{
    partial class MediaForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaForm));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btn_mess = new System.Windows.Forms.Button();
            this.btn_fast = new System.Windows.Forms.Button();
            this.btn_norm = new System.Windows.Forms.Button();
            this.btn_slow = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.trackList = new System.Windows.Forms.ListBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_msg = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbl_roll_ten = new System.Windows.Forms.Label();
            this.lbl_roll = new System.Windows.Forms.Label();
            this.btn_lang = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Black;
            this.groupBox.Controls.Add(this.btn_mess);
            this.groupBox.Controls.Add(this.btn_fast);
            this.groupBox.Controls.Add(this.btn_norm);
            this.groupBox.Controls.Add(this.btn_slow);
            this.groupBox.Controls.Add(this.btn_next);
            this.groupBox.Controls.Add(this.lbl_volume);
            this.groupBox.Controls.Add(this.trackBar);
            this.groupBox.Controls.Add(this.trackList);
            this.groupBox.Controls.Add(this.btn_open);
            this.groupBox.Controls.Add(this.btn_stop);
            this.groupBox.Controls.Add(this.btn_pause);
            this.groupBox.Controls.Add(this.btn_play);
            this.groupBox.Controls.Add(this.btn_prev);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox.Location = new System.Drawing.Point(0, 398);
            this.groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Size = new System.Drawing.Size(1200, 262);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // btn_mess
            // 
            this.btn_mess.BackColor = System.Drawing.Color.Black;
            this.btn_mess.BackgroundImage = global::mediaPlayer.Properties.Resources.elipse;
            this.btn_mess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_mess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))));
            this.btn_mess.Location = new System.Drawing.Point(20, 33);
            this.btn_mess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mess.Name = "btn_mess";
            this.btn_mess.Size = new System.Drawing.Size(80, 43);
            this.btn_mess.TabIndex = 20;
            this.btn_mess.Text = "mess off";
            this.btn_mess.UseVisualStyleBackColor = false;
            this.btn_mess.Click += new System.EventHandler(this.btn_mess_Click);
            // 
            // btn_fast
            // 
            this.btn_fast.BackColor = System.Drawing.Color.Black;
            this.btn_fast.BackgroundImage = global::mediaPlayer.Properties.Resources.elipse;
            this.btn_fast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_fast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))));
            this.btn_fast.Location = new System.Drawing.Point(20, 206);
            this.btn_fast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_fast.Name = "btn_fast";
            this.btn_fast.Size = new System.Drawing.Size(80, 43);
            this.btn_fast.TabIndex = 19;
            this.btn_fast.Text = "X1.5";
            this.btn_fast.UseVisualStyleBackColor = false;
            this.btn_fast.Click += new System.EventHandler(this.btn_fast_Click);
            // 
            // btn_norm
            // 
            this.btn_norm.BackColor = System.Drawing.Color.Black;
            this.btn_norm.BackgroundImage = global::mediaPlayer.Properties.Resources.elipse;
            this.btn_norm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_norm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_norm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_norm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))));
            this.btn_norm.Location = new System.Drawing.Point(20, 150);
            this.btn_norm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_norm.Name = "btn_norm";
            this.btn_norm.Size = new System.Drawing.Size(80, 43);
            this.btn_norm.TabIndex = 18;
            this.btn_norm.Text = "X1";
            this.btn_norm.UseVisualStyleBackColor = false;
            this.btn_norm.Click += new System.EventHandler(this.btn_norm_Click);
            // 
            // btn_slow
            // 
            this.btn_slow.BackColor = System.Drawing.Color.Black;
            this.btn_slow.BackgroundImage = global::mediaPlayer.Properties.Resources.elipse;
            this.btn_slow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_slow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_slow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_slow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))));
            this.btn_slow.Location = new System.Drawing.Point(20, 94);
            this.btn_slow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_slow.Name = "btn_slow";
            this.btn_slow.Size = new System.Drawing.Size(80, 43);
            this.btn_slow.TabIndex = 17;
            this.btn_slow.Text = "X0.5";
            this.btn_slow.UseVisualStyleBackColor = false;
            this.btn_slow.Click += new System.EventHandler(this.btn_slow_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Black;
            this.btn_next.BackgroundImage = global::mediaPlayer.Properties.Resources.Next;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_next.ForeColor = System.Drawing.Color.Transparent;
            this.btn_next.Location = new System.Drawing.Point(516, 31);
            this.btn_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(133, 49);
            this.btn_next.TabIndex = 8;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))));
            this.lbl_volume.Location = new System.Drawing.Point(1113, 222);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(43, 25);
            this.lbl_volume.TabIndex = 7;
            this.lbl_volume.Text = "0%";
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(1100, 33);
            this.trackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.Size = new System.Drawing.Size(56, 186);
            this.trackBar.TabIndex = 6;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackList
            // 
            this.trackList.BackColor = System.Drawing.Color.Black;
            this.trackList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trackList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))));
            this.trackList.FormattingEnabled = true;
            this.trackList.ItemHeight = 20;
            this.trackList.Location = new System.Drawing.Point(124, 102);
            this.trackList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(932, 120);
            this.trackList.TabIndex = 5;
            this.trackList.SelectedIndexChanged += new System.EventHandler(this.trackList_SelectedIndexChanged);
            this.trackList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackList_MouseDown);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Black;
            this.btn_open.BackgroundImage = global::mediaPlayer.Properties.Resources.Open;
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_open.ForeColor = System.Drawing.Color.Transparent;
            this.btn_open.Location = new System.Drawing.Point(836, 31);
            this.btn_open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(133, 49);
            this.btn_open.TabIndex = 4;
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Black;
            this.btn_stop.BackgroundImage = global::mediaPlayer.Properties.Resources.Reset;
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_stop.ForeColor = System.Drawing.Color.Transparent;
            this.btn_stop.Location = new System.Drawing.Point(676, 31);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(133, 49);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Black;
            this.btn_pause.BackgroundImage = global::mediaPlayer.Properties.Resources.Pause;
            this.btn_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pause.ForeColor = System.Drawing.Color.Transparent;
            this.btn_pause.Location = new System.Drawing.Point(356, 31);
            this.btn_pause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(133, 49);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Black;
            this.btn_play.BackgroundImage = global::mediaPlayer.Properties.Resources.Play;
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_play.ForeColor = System.Drawing.Color.Transparent;
            this.btn_play.Location = new System.Drawing.Point(356, 31);
            this.btn_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(133, 49);
            this.btn_play.TabIndex = 1;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            this.btn_play.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_play_MouseDown);
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.Color.Black;
            this.btn_prev.BackgroundImage = global::mediaPlayer.Properties.Resources.Previous;
            this.btn_prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_prev.ForeColor = System.Drawing.Color.Transparent;
            this.btn_prev.Location = new System.Drawing.Point(196, 31);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(133, 49);
            this.btn_prev.TabIndex = 0;
            this.btn_prev.UseVisualStyleBackColor = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar.Location = new System.Drawing.Point(75, 380);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1039, 12);
            this.progressBar.TabIndex = 8;
            this.progressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseDown);
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.BackColor = System.Drawing.Color.Black;
            this.lbl_track_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))));
            this.lbl_track_start.Location = new System.Drawing.Point(9, 375);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(55, 20);
            this.lbl_track_start.TabIndex = 9;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.BackColor = System.Drawing.Color.Transparent;
            this.lbl_track_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_track_end.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))));
            this.lbl_track_end.Location = new System.Drawing.Point(1123, 375);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(55, 20);
            this.lbl_track_end.TabIndex = 10;
            this.lbl_track_end.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))));
            this.lbl_msg.Location = new System.Drawing.Point(540, 14);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 25);
            this.lbl_msg.TabIndex = 11;
            // 
            // player
            // 
            this.player.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(4, 38);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(896, 347);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.MouseDownEvent += new AxWMPLib._WMPOCXEvents_MouseDownEventHandler(this.player_MouseDownEvent);
            // 
            // lbl_roll_ten
            // 
            this.lbl_roll_ten.AutoSize = true;
            this.lbl_roll_ten.BackColor = System.Drawing.Color.Transparent;
            this.lbl_roll_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_roll_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))));
            this.lbl_roll_ten.Location = new System.Drawing.Point(509, 191);
            this.lbl_roll_ten.Name = "lbl_roll_ten";
            this.lbl_roll_ten.Size = new System.Drawing.Size(137, 25);
            this.lbl_roll_ten.TabIndex = 17;
            this.lbl_roll_ten.Text = "- 10 seconds";
            this.lbl_roll_ten.Visible = false;
            // 
            // lbl_roll
            // 
            this.lbl_roll.AutoSize = true;
            this.lbl_roll.BackColor = System.Drawing.Color.Transparent;
            this.lbl_roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_roll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))));
            this.lbl_roll.Location = new System.Drawing.Point(540, 14);
            this.lbl_roll.Name = "lbl_roll";
            this.lbl_roll.Size = new System.Drawing.Size(83, 25);
            this.lbl_roll.TabIndex = 14;
            this.lbl_roll.Text = "Playing";
            this.lbl_roll.Visible = false;
            // 
            // btn_lang
            // 
            this.btn_lang.BackColor = System.Drawing.Color.Black;
            this.btn_lang.BackgroundImage = global::mediaPlayer.Properties.Resources.elipse;
            this.btn_lang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_lang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))));
            this.btn_lang.Location = new System.Drawing.Point(8, 7);
            this.btn_lang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lang.Name = "btn_lang";
            this.btn_lang.Size = new System.Drawing.Size(68, 34);
            this.btn_lang.TabIndex = 20;
            this.btn_lang.Text = "Eng";
            this.btn_lang.UseVisualStyleBackColor = false;
            this.btn_lang.Click += new System.EventHandler(this.btn_lang_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.BackgroundImage = global::mediaPlayer.Properties.Resources.elipse;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))));
            this.btn_exit.Location = new System.Drawing.Point(1149, 7);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 34);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1200, 53);
            this.pictureBox.TabIndex = 21;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.btn_lang);
            this.Controls.Add(this.lbl_roll_ten);
            this.Controls.Add(this.lbl_roll);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MediaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.ListBox trackList;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_roll_ten;
        private System.Windows.Forms.Button btn_fast;
        private System.Windows.Forms.Button btn_norm;
        private System.Windows.Forms.Button btn_slow;
        private System.Windows.Forms.Button btn_lang;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label lbl_roll;
        private System.Windows.Forms.Button btn_mess;
        private System.Windows.Forms.PictureBox pictureBox;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}

