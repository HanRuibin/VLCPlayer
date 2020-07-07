namespace HimalayaMeidiaPlayer
{
    partial class xPlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xPlay));
            this.panel_player = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_playlist = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.list_playlist = new System.Windows.Forms.ListBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel_player.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_player
            // 
            this.panel_player.Controls.Add(this.splitContainer1);
            this.panel_player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_player.Location = new System.Drawing.Point(0, 0);
            this.panel_player.Margin = new System.Windows.Forms.Padding(0);
            this.panel_player.Name = "panel_player";
            this.panel_player.Size = new System.Drawing.Size(1432, 873);
            this.panel_player.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.list_playlist);
            this.panel2.Controls.Add(this.txt_path);
            this.panel2.Controls.Add(this.btn_browse);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.label_playlist);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 873);
            this.panel2.TabIndex = 4;
            // 
            // label_playlist
            // 
            this.label_playlist.AutoSize = true;
            this.label_playlist.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_playlist.ForeColor = System.Drawing.Color.White;
            this.label_playlist.Location = new System.Drawing.Point(3, 79);
            this.label_playlist.Name = "label_playlist";
            this.label_playlist.Size = new System.Drawing.Size(53, 12);
            this.label_playlist.TabIndex = 5;
            this.label_playlist.Text = "素材列表";
            // 
            // btn_add
            // 
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.Location = new System.Drawing.Point(62, 73);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(40, 24);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.Location = new System.Drawing.Point(108, 73);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(40, 24);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "-";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // list_playlist
            // 
            this.list_playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.list_playlist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.list_playlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.list_playlist.FormattingEnabled = true;
            this.list_playlist.ItemHeight = 12;
            this.list_playlist.Location = new System.Drawing.Point(0, 101);
            this.list_playlist.Margin = new System.Windows.Forms.Padding(0);
            this.list_playlist.Name = "list_playlist";
            this.list_playlist.Size = new System.Drawing.Size(418, 772);
            this.list_playlist.TabIndex = 6;
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_browse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_browse.Location = new System.Drawing.Point(19, 12);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(105, 39);
            this.btn_browse.TabIndex = 0;
            this.btn_browse.Text = "打开";
            this.btn_browse.UseVisualStyleBackColor = false;
            // 
            // txt_path
            // 
            this.txt_path.AutoSize = true;
            this.txt_path.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_path.Location = new System.Drawing.Point(136, 35);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(29, 12);
            this.txt_path.TabIndex = 6;
            this.txt_path.Text = "....";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1432, 873);
            this.splitContainer1.SplitterDistance = 1006;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // xPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1432, 873);
            this.Controls.Add(this.panel_player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xPlay";
            this.Text = "xPlay";
            this.panel_player.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_player;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox list_playlist;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label_playlist;
        private System.Windows.Forms.Label txt_path;
        private System.Windows.Forms.Button btn_browse;
    }
}