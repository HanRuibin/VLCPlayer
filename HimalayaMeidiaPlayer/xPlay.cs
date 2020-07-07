using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxCNxMediaPlayerDCOMForActiveXLib;
using System.IO;
using CSharp.Winform.UI;

namespace HimalayaMeidiaPlayer
{
    public partial class xPlay : Form
    {
        public xPlay()
        {
            InitializeComponent();
            Load += XPlay_Load;
        }

        private void XPlay_SizeChanged(object sender, EventArgs e)
        {
            sizeChange.controlAutoSize(this);
        }

        private void XPlay_Resize(object sender, EventArgs e)
        {
            //InitializePlayer();
        }

        private void XPlay_Load(object sender, EventArgs e)
        {

            //initilize form size
            InitializeForm();
            //load axcnxmediaplayer
            InitializePlayer();
            sizeChange.controllInitializeSize(this);
            this.SizeChanged += XPlay_SizeChanged;

        }

        private void InitializePlayer()
        {
            player = new AxCNxMediaPlayer();
            var panel_play = this.splitContainer1.Panel1;
            panel_play.Controls.Add(player);
            player.Width = panel_play.Width;
            player.Height = panel_play.Height;
            this.playerAction = new BLL.PlayerActions(player);
        }

        private void InitializeForm()
        {
            var screen = Screen.PrimaryScreen.WorkingArea.Size;
            this.Width = 1440;
            this.Height = 900;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = backColor;
            this.panel_player.Anchor = AnchorStyles.Left;
            this.panel_player.Dock = DockStyle.Fill;
            //playlist
            this.list_playlist.BackColor = backColor;
            this.list_playlist.Dock = DockStyle.Bottom;
            //browse
            this.btn_browse.Click += Btn_browse_Click;
            this.btn_add.Click += Btn_add_Click;
            this.list_playlist.DoubleClick += List_playlist_DoubleClick;
            this.btn_delete.Click += Btn_delete_Click;
            //
            this.splitContainer1.BorderStyle = BorderStyle.None;
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            var selectedVideo = this.list_playlist.SelectedItem;
            this.list_playlist.Items.Remove(selectedVideo);
        }


        private void List_playlist_DoubleClick(object sender, EventArgs e)
        {
            var selectedVideo = this.list_playlist.SelectedItem as string;
            this.Cursor = Cursors.WaitCursor;
            playerAction.Open(selectedVideo);
            this.Cursor = Cursors.Arrow ;
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            var videoPath = this.txt_path.Text;
            if(File.Exists(videoPath))
            {
                this.list_playlist.Items.Add(videoPath);
            }
        }


        private void Btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择素材文件";
            ofd.Filter = "MXF文件|*.MXF|8KM文件|*.8km|所有文件(.)|*.*";
            ofd.Multiselect = false;
            var dialogResult = ofd.ShowDialog();
            if(dialogResult== DialogResult.OK)
            {
                this.txt_path.Text = ofd.FileName;
            }
            var videoPath = this.txt_path.Text;
            if (File.Exists(videoPath))
            {
                this.Cursor = Cursors.WaitCursor;
                playerAction.Open(videoPath);
                this.Cursor = Cursors.Arrow;
            }
        }

        #region resources
        private Color backColor= Color.FromArgb(49, 52, 60);
        #endregion
        AxCNxMediaPlayer player;
        private BLL.PlayerActions playerAction ;
        Utilitys.AutoSizeFormClass sizeChange = new Utilitys.AutoSizeFormClass();
    }
}
