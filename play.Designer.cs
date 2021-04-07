
namespace Battaglia_Navale
{
    partial class play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(play));
            this.data_player = new System.Windows.Forms.DataGridView();
            this.data_cpu = new System.Windows.Forms.DataGridView();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.btn_pos = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            this.SuspendLayout();
            // 
            // data_player
            // 
            this.data_player.BackgroundColor = System.Drawing.Color.White;
            this.data_player.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_player.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_player.ColumnHeadersVisible = false;
            this.data_player.Location = new System.Drawing.Point(234, 12);
            this.data_player.Name = "data_player";
            this.data_player.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_player.RowHeadersVisible = false;
            this.data_player.Size = new System.Drawing.Size(252, 254);
            this.data_player.TabIndex = 0;
            this.data_player.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_player_CellClick);
            this.data_player.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_player_CellMouseMove);
            // 
            // data_cpu
            // 
            this.data_cpu.BackgroundColor = System.Drawing.Color.White;
            this.data_cpu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_cpu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_cpu.ColumnHeadersVisible = false;
            this.data_cpu.Location = new System.Drawing.Point(234, 324);
            this.data_cpu.Name = "data_cpu";
            this.data_cpu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_cpu.RowHeadersVisible = false;
            this.data_cpu.Size = new System.Drawing.Size(252, 254);
            this.data_cpu.TabIndex = 1;
            this.data_cpu.Visible = false;
            // 
            // pic2
            // 
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(12, 39);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(80, 34);
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.pic2_Click);
            // 
            // pic3
            // 
            this.pic3.Image = ((System.Drawing.Image)(resources.GetObject("pic3.Image")));
            this.pic3.Location = new System.Drawing.Point(12, 126);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(115, 34);
            this.pic3.TabIndex = 4;
            this.pic3.TabStop = false;
            this.pic3.Click += new System.EventHandler(this.pic3_Click);
            // 
            // pic4
            // 
            this.pic4.Image = ((System.Drawing.Image)(resources.GetObject("pic4.Image")));
            this.pic4.Location = new System.Drawing.Point(12, 193);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(147, 34);
            this.pic4.TabIndex = 6;
            this.pic4.TabStop = false;
            this.pic4.Click += new System.EventHandler(this.pic4_Click);
            // 
            // pic5
            // 
            this.pic5.Image = ((System.Drawing.Image)(resources.GetObject("pic5.Image")));
            this.pic5.Location = new System.Drawing.Point(12, 250);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(183, 34);
            this.pic5.TabIndex = 7;
            this.pic5.TabStop = false;
            this.pic5.Click += new System.EventHandler(this.pic5_Click);
            // 
            // btn_pos
            // 
            this.btn_pos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pos.Location = new System.Drawing.Point(12, 324);
            this.btn_pos.Name = "btn_pos";
            this.btn_pos.Size = new System.Drawing.Size(75, 23);
            this.btn_pos.TabIndex = 8;
            this.btn_pos.Text = "Orizzontale";
            this.btn_pos.UseVisualStyleBackColor = true;
            this.btn_pos.Click += new System.EventHandler(this.btn_pos_Click);
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Location = new System.Drawing.Point(12, 324);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 9;
            this.btn_play.Text = "Gioca";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Visible = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(627, 355);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_pos);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.data_cpu);
            this.Controls.Add(this.data_player);
            this.Name = "play";
            this.Text = "Battaglia Navale";
            this.Load += new System.EventHandler(this.play_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_player;
        private System.Windows.Forms.DataGridView data_cpu;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.Button btn_pos;
        private System.Windows.Forms.Button btn_play;
    }
}