using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battaglia_Navale
{
    public partial class play : Form
    {
        public play()
        {
            InitializeComponent();
        }
        bool pl = true;
        bool b2 = false;
        bool b3 = false;
        bool b4 = false;
        bool b5 = false;
        bool es = false, es2 = false, br = false;
        int rwprec = 0, clprec = 0;
        int cnt1 = 2, cnt2 = 2, cnt3 = 1, cnt4 = 1;
        int btnapp = 0;

        // posizoni
        bool vert = false;
        bool ort = true;
        //
        private void play_Load(object sender, EventArgs e)
        {
            data_player.RowCount = 10;
            data_player.ColumnCount = 10;

            data_cpu.RowCount = 10;
            data_cpu.ColumnCount = 10;

            for(int r = 0; r<10; r++)
            {
                for (int c = 0; c < 10; c++) {

                    data_player.Rows[r].Height = 25;
                    data_player.Columns[c].Width = 25;

                    data_cpu.Rows[r].Height = 25;
                    data_cpu.Columns[c].Width = 25;


                }

            }
        }

        private void data_player_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (b2)
            {
                if (ort)
                {
                    if (es == true && data_player.Rows[rwprec].Cells[clprec - 1].Style.BackColor != Color.DarkGreen)
                    {
                        if (!br)
                        {
                            clearwthdrkgr();
                            es = false;
                        }
                        else if (cnt1 > 0)
                        {
                            cnt1--;
                            clearwthdrkgr();
                            es = false;
                            br = false;
                        }
                    }

                    if (es2 == true && data_player.Rows[rwprec].Cells[clprec + 1].Style.BackColor != Color.DarkGreen)
                    {
                        if (!br)
                        {
                            clearwthdrkgr();
                            es2 = false;
                            br = false;
                        }
                        else if (cnt1 > 0)
                        {
                            cnt1--;
                            data_player.Rows[rwprec].Cells[clprec].Style.BackColor = Color.DarkGreen;
                            data_player.Rows[rwprec].Cells[clprec + 1].Style.BackColor = Color.DarkGreen;
                            es = false;
                            br = false;
                        }
                    }
                    if (e.ColumnIndex < 9 && cnt1 > 0)
                    {
                        if (data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Style.BackColor != Color.DarkGreen)
                        {
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Style.BackColor = Color.Red;
                            es2 = true;
                        }
                    }


                    clprec = e.ColumnIndex;
                    rwprec = e.RowIndex;
                }

                if (!ort)
                {

                    if (es == true)
                    {
                        if (!br)
                        {
                            clearwthdrkgr();
                            es = false;
                        }
                        else if (cnt2 > 0)
                        {
                            cnt1--;
                            clearwthdrkgr();
                            es = false;
                            br = false;
                        }
                    }

                    if (rwprec < 9)
                    {
                        if (es2 == true && data_player.Rows[rwprec + 1].Cells[clprec].Style.BackColor != Color.DarkGreen)
                        {
                            if (!br)
                            {
                                clearwthdrkgr();
                                es2 = false;
                                br = false;
                            }
                            else if (cnt1 > 0)
                            {
                                cnt1--;
                                data_player.Rows[rwprec].Cells[clprec].Style.BackColor = Color.DarkGreen;
                                data_player.Rows[rwprec + 1].Cells[clprec].Style.BackColor = Color.DarkGreen;
                                es = false;
                                br = false;
                            }
                        }
                    }
                    if (e.RowIndex < 9 && cnt1 > 0)
                    {
                        if (data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen)
                        {
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            es2 = true;
                        }
                    }


                    clprec = e.ColumnIndex;
                    rwprec = e.RowIndex;

                }
            }

            if (b3)
            {


                if (ort)
                {

                    if (es == true)
                    {
                        if (!br)
                        {
                            clearwthdrkgr();
                            es = false;
                        }
                        else if (cnt2 > 0)
                        {
                            cnt2--;
                            clearwthdrkgr();
                            es = false;
                            br = false;
                        }
                    }

                    if (clprec < 8)
                    {
                        if (es2 == true && data_player.Rows[rwprec].Cells[clprec + 1].Style.BackColor != Color.DarkGreen)
                        {
                            if (!br)
                            {
                                clearwthdrkgr();
                                es2 = false;
                                br = false;
                            }
                            else if (cnt2 > 0)
                            {
                                cnt2--;
                                data_player.Rows[rwprec].Cells[clprec].Style.BackColor = Color.DarkGreen;
                                data_player.Rows[rwprec].Cells[clprec + 1].Style.BackColor = Color.DarkGreen;
                                data_player.Rows[rwprec].Cells[clprec + 2].Style.BackColor = Color.DarkGreen;
                                es = false;
                                br = false;
                            }
                        }
                    }
                    if (e.ColumnIndex < 8 && cnt2 > 0)
                    {
                        if (data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Style.BackColor != Color.DarkGreen)
                        {
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Style.BackColor = Color.Red;
                            es2 = true;
                        }
                    }


                    clprec = e.ColumnIndex;
                    rwprec = e.RowIndex;

                }

                if (!ort)
                {

                    if (es == true)
                    {
                        if (!br)
                        {
                            clearwthdrkgr();
                            es = false;
                        }
                        else if (cnt2 > 0)
                        {
                            cnt2--;
                            clearwthdrkgr();
                            es = false;
                            br = false;
                        }
                    }

                    if (rwprec < 8)
                    {
                        if (es2 == true && data_player.Rows[rwprec + 1].Cells[clprec].Style.BackColor != Color.DarkGreen)
                        {
                            if (!br)
                            {
                                clearwthdrkgr();
                                es2 = false;
                                br = false;
                            }
                            else if (cnt2 > 0)
                            {
                                cnt2--;
                                data_player.Rows[rwprec].Cells[clprec].Style.BackColor = Color.DarkGreen;
                                data_player.Rows[rwprec + 1].Cells[clprec].Style.BackColor = Color.DarkGreen;
                                data_player.Rows[rwprec + 2].Cells[clprec].Style.BackColor = Color.DarkGreen;
                                es = false;
                                br = false;
                            }
                        }
                    }
                    if (e.RowIndex < 8 && cnt2 > 0)
                    {
                        if (data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen)
                        {
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            es2 = true;
                        }
                    }


                    clprec = e.ColumnIndex;
                    rwprec = e.RowIndex;


                }

            }

            if (b4)
            {

                if (ort)
                {
                    if (es == true)
                    {
                        if (!br)
                        {
                            clearwthdrkgr();
                            es = false;
                        }
                        else if (cnt2 > 0)
                        {
                            cnt3--;
                            clearwthdrkgr();
                            es = false;
                            br = false;
                        }
                    }
                    if (clprec < 7)
                    {
                        if (es2 == true && data_player.Rows[rwprec].Cells[clprec + 1].Style.BackColor != Color.DarkGreen)
                        {
                            if (!br)
                            {
                                clearwthdrkgr();
                                es2 = false;
                                br = false;
                            }
                            else if (cnt3 > 0)
                            {
                                cnt3--;
                                data_player.Rows[rwprec].Cells[clprec].Style.BackColor = Color.DarkGreen;
                                data_player.Rows[rwprec].Cells[clprec + 1].Style.BackColor = Color.DarkGreen;
                                data_player.Rows[rwprec].Cells[clprec + 2].Style.BackColor = Color.DarkGreen;
                                data_player.Rows[rwprec].Cells[clprec + 3].Style.BackColor = Color.DarkGreen;
                                es = false;
                                br = false;
                            }
                        }
                    }
                    if (e.ColumnIndex < 7 && cnt3 > 0)
                    {
                        if (data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Style.BackColor != Color.DarkGreen
                            )
                        {
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Style.BackColor = Color.Red;
                            es2 = true;
                        }
                    }


                    clprec = e.ColumnIndex;
                    rwprec = e.RowIndex;


                }

                if (!ort)
                {
                    if (es == true)
                    {
                        if (!br)
                        {
                            clearwthdrkgr();
                            es = false;
                        }
                        else if (cnt2 > 0)
                        {
                            cnt3--;
                            clearwthdrkgr();
                            es = false;
                            br = false;
                        }
                    }
                    if (rwprec < 7)
                    {
                        if (es2 == true && data_player.Rows[rwprec + 1].Cells[clprec].Style.BackColor != Color.DarkGreen)
                        {
                            if (!br)
                            {
                                clearwthdrkgr();
                                es2 = false;
                                br = false;
                            }
                            else if (cnt3 > 0)
                            {
                                cnt3--;
                                data_player.Rows[rwprec].Cells[clprec].Style.BackColor = Color.DarkGreen;
                                data_player.Rows[rwprec + 1].Cells[clprec].Style.BackColor = Color.DarkGreen;
                                data_player.Rows[rwprec + 2].Cells[clprec].Style.BackColor = Color.DarkGreen;
                                data_player.Rows[rwprec + 3].Cells[clprec].Style.BackColor = Color.DarkGreen;
                                es = false;
                                br = false;
                            }
                        }
                    }
                    if (e.RowIndex < 7 && cnt3 > 0)
                    {
                        if (data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex + 3].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen
                            )
                        {
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex + 3].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            es2 = true;
                        }
                    }


                    clprec = e.ColumnIndex;
                    rwprec = e.RowIndex;
                }
            }

            if (b5)
            {

                if (ort)
                {
                    if (es == true)
                    {
                        if (!br)
                        {
                            clearwthdrkgr();
                            es = false;
                        }
                        else if (cnt2 > 0)
                        {
                            cnt4--;
                            clearwthdrkgr();
                            es = false;
                            br = false;
                        }
                    }

                    if (es2 == true && data_player.Rows[rwprec].Cells[clprec + 1].Style.BackColor != Color.DarkGreen)
                    {
                        if (!br)
                        {
                            clearwthdrkgr();
                            es2 = false;
                            br = false;
                        }
                        else if (cnt4 > 0)
                        {
                            cnt4--;
                            data_player.Rows[rwprec].Cells[clprec].Style.BackColor = Color.DarkGreen;
                            data_player.Rows[rwprec].Cells[clprec + 1].Style.BackColor = Color.DarkGreen;
                            data_player.Rows[rwprec].Cells[clprec + 2].Style.BackColor = Color.DarkGreen;
                            data_player.Rows[rwprec].Cells[clprec + 3].Style.BackColor = Color.DarkGreen;
                            data_player.Rows[rwprec].Cells[clprec + 4].Style.BackColor = Color.DarkGreen;

                            es = false;
                            br = false;
                        }
                    }
                    if (e.ColumnIndex < 6 && cnt4 > 0)
                    {
                        if (data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 4].Style.BackColor != Color.DarkGreen
                            )
                        {
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex + 4].Style.BackColor = Color.Red;
                            es2 = true;
                        }
                    }


                    clprec = e.ColumnIndex;
                    rwprec = e.RowIndex;

                }

                if (!ort)
                {
                    if (es == true)
                    {
                        if (!br)
                        {
                            clearwthdrkgr();
                            es = false;
                        }
                        else if (cnt2 > 0)
                        {
                            cnt4--;
                            clearwthdrkgr();
                            es = false;
                            br = false;
                        }
                    }

                    if (rwprec < 6)
                    {
                        if (es2 == true && data_player.Rows[rwprec + 1].Cells[clprec].Style.BackColor != Color.DarkGreen)
                        {
                            if (!br)
                            {
                                clearwthdrkgr();
                                es2 = false;
                                br = false;
                            }
                            else if (cnt4 > 0)
                            {
                                cnt4--;
                                data_player.Rows[rwprec].Cells[clprec].Style.BackColor = Color.DarkGreen;
                                data_player.Rows[rwprec + 1].Cells[clprec].Style.BackColor = Color.DarkGreen;
                                data_player.Rows[rwprec + 2].Cells[clprec].Style.BackColor = Color.DarkGreen;
                                data_player.Rows[rwprec + 3].Cells[clprec].Style.BackColor = Color.DarkGreen;
                                data_player.Rows[rwprec + 4].Cells[clprec].Style.BackColor = Color.DarkGreen;

                                es = false;
                                br = false;
                            }
                        }
                    }
                    if (e.RowIndex < 6 && cnt4 > 0)
                    {
                        if (data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex + 3].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen &&
                            data_player.Rows[e.RowIndex + 4].Cells[e.ColumnIndex].Style.BackColor != Color.DarkGreen
                            )
                        {
                            data_player.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex + 3].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            data_player.Rows[e.RowIndex + 4].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                            es2 = true;
                        }
                    }


                    clprec = e.ColumnIndex;
                    rwprec = e.RowIndex;


                }

            }



            chkrdy();
      }

        private void chkrdy() {
            int cnt6 = 0;
            for (int r = 0; r < 10; r++) {

                for (int c = 0; c < 10; c++) {

                    if (data_player.Rows[r].Cells[c].Style.BackColor == Color.DarkGreen)
                        cnt6++;



                }
            
            }

            if (cnt6 == 19 && pl) {

                btn_play.Visible = true;
                btn_pos.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
                pic5.Visible = false;
                data_cpu.Visible = true;
                this.Height = 640;
                this.Width = 643;
                pl = false;

            }
        
        }
        private void btn_pos_Click(object sender, EventArgs e)
        {
            if (btnapp == 0) {
                btn_pos.Text = "Verticale";
                ort = false;
            }
            if (btnapp == 1)
            {
                btn_pos.Text = "Orizzontale";
                ort = true;
                btnapp = -1;
            }
            clearwthdrkgr();
            btnapp++;
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            flsvar();
            b3 = true;
            if (cnt2 == 0)
            pic3.Visible = false;
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            flsvar();
            b5 = true;
            if (cnt4 == 0)
                pic5.Visible = false;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            popolacpu();
            btn_play.Visible = false;
           
            for (int r = 0; r < 10; r++) {

                for (int c = 0; c < 10; c++) {

                    if (data_player.Rows[r].Cells[c].Style.BackColor != Color.DarkGreen) {

                        data_player.Rows[r].Cells[c].Style.BackColor = Color.Blue;
                        

                    }

                    

                        data_cpu.Rows[r].Cells[c].Style.BackColor = Color.Blue;


                }
            
            }

            
          

        }

        private void pic4_Click(object sender, EventArgs e)
        {
            flsvar();
            b4 = true;
            if (cnt3 == 0)
                pic4.Visible = false;
        }

        private void data_player_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            br = true;

        }

        private void popolacpu() {
            int row = 0, col = 0, row2 = 0, col2 = 0, row3 = 0, col3 = 0;
            int oriz = 0;
            Random rnd = new Random();

            for (int cnt = 0; cnt < 6; cnt++)
            {
                if (cnt < 2)
                {
                    do
                    {

                        row = rnd.Next(0, 10);
                        col = rnd.Next(0, 10);

                        row2 = row;
                        col2 = col;

                        if (rnd.Next(-1, 1) == 0) //0: verticale 1: orizzontale
                            row2 = row + 1;
                        else
                            col2 = col + 1;

                    }
                    while ((data_cpu.Rows[row].Cells[col].Value == "B") || (row2 >= 10 || col2 >= 10) || (data_cpu.Rows[row2].Cells[col2].Value == "B"));

                    data_cpu.Rows[row].Cells[col].Value = "B";
                    data_cpu.Rows[row2].Cells[col2].Value = "B";
                }

                else if (cnt < 5 && cnt > 2)
                {

                    do
                    {

                        row = rnd.Next(0, 10);
                        col = rnd.Next(0, 10);

                        row2 = row;
                        col2 = col;

                        row3 = row2;
                        col3 = col2;

                        if (rnd.Next(-1, 1) == 0) //0: verticale 1: orizzontale
                        {
                            row2 = row + 1;
                            row3 = row2 + 1;
                        }
                        else
                        {
                            col2 = col + 1;
                            col3 = col2 + 1;
                        }

                    }
                    while ((data_cpu.Rows[row].Cells[col].Value == "B") || (row2 >= 10 || col2 >= 10 || row3 >= 10 || col3 >= 10) || 
                    (data_cpu.Rows[row2].Cells[col2].Value == "B" || data_cpu.Rows[row3].Cells[col3].Value == "B"));

                    data_cpu.Rows[row].Cells[col].Value = "B";
                    data_cpu.Rows[row2].Cells[col2].Value = "B";
                    data_cpu.Rows[row3].Cells[col3].Value = "B";
                    

                }
            }



        }
        private void sb() {

            for (int r = 0; r < 10; r++) {

                for (int c = 0; c < 10; c++) {

                    data_player.Rows[r].Cells[c].Style.BackColor = Color.White;

                }
            
            }
        }
        private void flsvar() {
            b2 = false;
            b3 = false;
            b4 = false;
            b5 = false;
        }
        private void pic2_Click(object sender, EventArgs e)
        {
            flsvar();
            b2 = true;

            if(cnt1 == 0)
            pic2.Visible = false;
        }

        private void clearwthdrkgr() {

            for (int r = 0; r < 10; r++) {

                for (int c = 0; c < 10; c++) {

                    if (data_player.Rows[r].Cells[c].Style.BackColor == Color.Red) {

                        data_player.Rows[r].Cells[c].Style.BackColor = Color.White;

                    }
                
                }
            }
        
        }
    }
}
