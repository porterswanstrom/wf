using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chess_Monitor
{
    public partial class chessMonitor : Form
    {
        const int ROWS = 8, COLS = 8;
        string[,] board = new string[ROWS, COLS];
        string piece = "";

        public chessMonitor()
        {
            InitializeComponent();
        }

        private void Setup(string file = "setup.txt")
        {
            StreamReader input = File.OpenText(file);

            for (int i = 0; i < ROWS; i++)
                for (int j = 0; j < COLS; j++)
                    board[i, j] = input.ReadLine();

            input.Close();

            a1.Text = board[0, 0];
            a2.Text = board[0, 1];
            a3.Text = board[0, 2];
            a4.Text = board[0, 3];
            a5.Text = board[0, 4];
            a6.Text = board[0, 5];
            a7.Text = board[0, 6];
            a8.Text = board[0, 7];
            b1.Text = board[1, 0];
            b2.Text = board[1, 1];
            b3.Text = board[1, 2];
            b4.Text = board[1, 3];
            b5.Text = board[1, 4];
            b6.Text = board[1, 5];
            b7.Text = board[1, 6];
            b8.Text = board[1, 7];
            c1.Text = board[2, 0];
            c2.Text = board[2, 1];
            c3.Text = board[2, 2];
            c4.Text = board[2, 3];
            c5.Text = board[2, 4];
            c6.Text = board[2, 5];
            c7.Text = board[2, 6];
            c8.Text = board[2, 7];
            d1.Text = board[3, 0];
            d2.Text = board[3, 1];
            d3.Text = board[3, 2];
            d4.Text = board[3, 3];
            d5.Text = board[3, 4];
            d6.Text = board[3, 5];
            d7.Text = board[3, 6];
            d8.Text = board[3, 7];
            e1.Text = board[4, 0];
            e2.Text = board[4, 1];
            e3.Text = board[4, 2];
            e4.Text = board[4, 3];
            e5.Text = board[4, 4];
            e6.Text = board[4, 5];
            e7.Text = board[4, 6];
            e8.Text = board[4, 7];
            f1.Text = board[5, 0];
            f2.Text = board[5, 1];
            f3.Text = board[5, 2];
            f4.Text = board[5, 3];
            f5.Text = board[5, 4];
            f6.Text = board[5, 5];
            f7.Text = board[5, 6];
            f8.Text = board[5, 7];
            g1.Text = board[6, 0];
            g2.Text = board[6, 1];
            g3.Text = board[6, 2];
            g4.Text = board[6, 3];
            g5.Text = board[6, 4];
            g6.Text = board[6, 5];
            g7.Text = board[6, 6];
            g8.Text = board[6, 7];
            h1.Text = board[7, 0];
            h2.Text = board[7, 1];
            h3.Text = board[7, 2];
            h4.Text = board[7, 3];
            h5.Text = board[7, 4];
            h6.Text = board[7, 5];
            h7.Text = board[7, 6];
            h8.Text = board[7, 7];
        }

        private void chessMonitor_Load(object sender, EventArgs e)
        {
            Setup();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Setup();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            board[0, 0] = a1.Text;
            board[0, 1] = a2.Text;
            board[0, 2] = a3.Text;
            board[0, 3] = a4.Text;
            board[0, 4] = a5.Text;
            board[0, 5] = a6.Text;
            board[0, 6] = a7.Text;
            board[0, 7] = a8.Text;
            board[1, 0] = b1.Text;
            board[1, 1] = b2.Text;
            board[1, 2] = b3.Text;
            board[1, 3] = b4.Text;
            board[1, 4] = b5.Text;
            board[1, 5] = b6.Text;
            board[1, 6] = b7.Text;
            board[1, 7] = b8.Text;
            board[2, 0] = c1.Text;
            board[2, 1] = c2.Text;
            board[2, 2] = c3.Text;
            board[2, 3] = c4.Text;
            board[2, 4] = c5.Text;
            board[2, 5] = c6.Text;
            board[2, 6] = c7.Text;
            board[2, 7] = c8.Text;
            board[3, 0] = d1.Text;
            board[3, 1] = d2.Text;
            board[3, 2] = d3.Text;
            board[3, 3] = d4.Text;
            board[3, 4] = d5.Text;
            board[3, 5] = d6.Text;
            board[3, 6] = d7.Text;
            board[3, 7] = d8.Text;
            board[4, 0] = e1.Text;
            board[4, 1] = e2.Text;
            board[4, 2] = e3.Text;
            board[4, 3] = e4.Text;
            board[4, 4] = e5.Text;
            board[4, 5] = e6.Text;
            board[4, 6] = e7.Text;
            board[4, 7] = e8.Text;
            board[5, 0] = f1.Text;
            board[5, 1] = f2.Text;
            board[5, 2] = f3.Text;
            board[5, 3] = f4.Text;
            board[5, 4] = f5.Text;
            board[5, 5] = f6.Text;
            board[5, 6] = f7.Text;
            board[5, 7] = f8.Text;
            board[6, 0] = g1.Text;
            board[6, 1] = g2.Text;
            board[6, 2] = g3.Text;
            board[6, 3] = g4.Text;
            board[6, 4] = g5.Text;
            board[6, 5] = g6.Text;
            board[6, 6] = g7.Text;
            board[6, 7] = g8.Text;
            board[7, 0] = h1.Text;
            board[7, 1] = h2.Text;
            board[7, 2] = h3.Text;
            board[7, 3] = h4.Text;
            board[7, 4] = h5.Text;
            board[7, 5] = h6.Text;
            board[7, 6] = h7.Text;
            board[7, 7] = h8.Text;

            string file = "";

            if (game1RadioBtn.Checked)
                file = "game1.txt";
            else if (game2RadioBtn.Checked)
                file = "game2.txt";
            else if (game3RadioBtn.Checked)
                file = "game3.txt";

            StreamWriter output = File.CreateText(file);

            for (int i = 0; i < ROWS; i++)
                for (int j = 0; j < COLS; j++)
                    output.WriteLine(board[i, j]);

            output.Close();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string file = "";

            if (game1RadioBtn.Checked)
                file = "game1.txt";
            else if (game2RadioBtn.Checked)
                file = "game2.txt";
            else if (game3RadioBtn.Checked)
                file = "game3.txt";

            if (!File.Exists(file))
                return;

            Setup(file);
        }

        private void a1_Click(object sender, EventArgs e)
        {
            if (a1.Text == "")
                a1.Text = piece;
            else {
                piece = a1.Text;
                a1.Text = "";
            }
        }

        private void a2_Click(object sender, EventArgs e)
        {
            if (a2.Text == "")
                a2.Text = piece;
            else {
                piece = a2.Text;
                a2.Text = "";
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            if (a3.Text == "")
                a3.Text = piece;
            else {
                piece = a3.Text;
                a3.Text = "";
            }
        }

        private void a4_Click(object sender, EventArgs e)
        {
            if (a4.Text == "")
                a4.Text = piece;
            else {
                piece = a4.Text;
                a4.Text = "";
            }
        }

        private void a5_Click(object sender, EventArgs e)
        {
            if (a5.Text == "")
                a5.Text = piece;
            else {
                piece = a5.Text;
                a5.Text = "";
            }
        }

        private void a6_Click(object sender, EventArgs e)
        {
            if (a6.Text == "")
                a6.Text = piece;
            else {
                piece = a6.Text;
                a6.Text = "";
            }
        }

        private void a7_Click(object sender, EventArgs e)
        {
            if (a7.Text == "")
                a7.Text = piece;
            else {
                piece = a7.Text;
                a7.Text = "";
            }
        }

        private void a8_Click(object sender, EventArgs e)
        {
            if (a8.Text == "")
                a8.Text = piece;
            else {
                piece = a8.Text;
                a8.Text = "";
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (b1.Text == "")
                b1.Text = piece;
            else {
                piece = b1.Text;
                b1.Text = "";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (b2.Text == "")
                b2.Text = piece;
            else {
                piece = b2.Text;
                b2.Text = "";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (b3.Text == "")
                b3.Text = piece;
            else {
                piece = b3.Text;
                b3.Text = "";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (b4.Text == "")
                b4.Text = piece;
            else {
                piece = b4.Text;
                b4.Text = "";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (b5.Text == "")
                b5.Text = piece;
            else {
                piece = b5.Text;
                b5.Text = "";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (b6.Text == "")
                b6.Text = piece;
            else {
                piece = b6.Text;
                b6.Text = "";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (b7.Text == "")
                b7.Text = piece;
            else {
                piece = b7.Text;
                b7.Text = "";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (b8.Text == "")
                b8.Text = piece;
            else {
                piece = b8.Text;
                b8.Text = "";
            }
        }

        private void c1_Click(object sender, EventArgs e)
        {
            if (c1.Text == "")
                c1.Text = piece;
            else {
                piece = c1.Text;
                c1.Text = "";
            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            if (c2.Text == "")
                c2.Text = piece;
            else {
                piece = c2.Text;
                c2.Text = "";
            }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            if (c3.Text == "")
                c3.Text = piece;
            else {
                piece = c3.Text;
                c3.Text = "";
            }
        }

        private void c4_Click(object sender, EventArgs e)
        {
            if (c4.Text == "")
                c4.Text = piece;
            else {
                piece = c4.Text;
                c4.Text = "";
            }
        }

        private void c5_Click(object sender, EventArgs e)
        {
            if (c5.Text == "")
                c5.Text = piece;
            else {
                piece = c5.Text;
                c5.Text = "";
            }
        }

        private void c6_Click(object sender, EventArgs e)
        {
            if (c6.Text == "")
                c6.Text = piece;
            else {
                piece = c6.Text;
                c6.Text = "";
            }
        }

        private void c7_Click(object sender, EventArgs e)
        {
            if (c7.Text == "")
                c7.Text = piece;
            else {
                piece = c7.Text;
                c7.Text = "";
            }
        }

        private void c8_Click(object sender, EventArgs e)
        {
            if (c8.Text == "")
                c8.Text = piece;
            else {
                piece = c8.Text;
                c8.Text = "";
            }
        }

        private void d1_Click(object sender, EventArgs e)
        {
            if (d1.Text == "")
                d1.Text = piece;
            else {
                piece = d1.Text;
                d1.Text = "";
            }   
        }

        private void d2_Click(object sender, EventArgs e)
        {
            if (d2.Text == "")
                d2.Text = piece;
            else {
                piece = d2.Text;
                d2.Text = "";
            }
        }

        private void d3_Click(object sender, EventArgs e)
        {
            if (d3.Text == "")
                d3.Text = piece;
            else {
                piece = d3.Text;
                d3.Text = "";
            }
        }

        private void d4_Click(object sender, EventArgs e)
        {
            if (d4.Text == "")
                d4.Text = piece;
            else {
                piece = d4.Text;
                d4.Text = "";
            }
        }

        private void d5_Click(object sender, EventArgs e)
        {
            if (d5.Text == "")
                d5.Text = piece;
            else {
                piece = d5.Text;
                d5.Text = "";
            }
        }

        private void d6_Click(object sender, EventArgs e)
        {
            if (d6.Text == "")
                d6.Text = piece;
            else {
                piece = d6.Text;
                d6.Text = "";
            }
        }

        private void d7_Click(object sender, EventArgs e)
        {
            if (d7.Text == "")
                d7.Text = piece;
            else {
                piece = d7.Text;
                d7.Text = "";
            }
        }

        private void d8_Click(object sender, EventArgs e)
        {
            if (d8.Text == "")
                d8.Text = piece;
            else {
                piece = d8.Text;
                d8.Text = "";
            }
        }

        private void e1_Click(object sender, EventArgs e)
        {
            if (e1.Text == "")
                e1.Text = piece;
            else {
                piece = e1.Text;
                e1.Text = "";
            }
        }

        private void e2_Click(object sender, EventArgs e)
        {
            if (e2.Text == "")
                e2.Text = piece;
            else {
                piece = e2.Text;
                e2.Text = "";
            }
        }

        private void e3_Click(object sender, EventArgs e)
        {
            if (e3.Text == "")
                e3.Text = piece;
            else {
                piece = e3.Text;
                e3.Text = "";
            }
        }

        private void e4_Click(object sender, EventArgs e)
        {
            if (e4.Text == "")
                e4.Text = piece;
            else {
                piece = e4.Text;
                e4.Text = "";
            }
        }

        private void e5_Click(object sender, EventArgs e)
        {
            if (e5.Text == "")
                e5.Text = piece;
            else {
                piece = e5.Text;
                e5.Text = "";
            }
        }

        private void e6_Click(object sender, EventArgs e)
        {
            if (e6.Text == "")
                e6.Text = piece;
            else {
                piece = e6.Text;
                e6.Text = "";
            }
        }

        private void e7_Click(object sender, EventArgs e)
        {
            if (e7.Text == "")
                e7.Text = piece;
            else {
                piece = e7.Text;
                e7.Text = "";
            }
        }

        private void e8_Click(object sender, EventArgs e)
        {
            if (e8.Text == "")
                e8.Text = piece;
            else {
                piece = e8.Text;
                e8.Text = "";
            }
        }

        private void f1_Click(object sender, EventArgs e)
        {
            if (f1.Text == "")
                f1.Text = piece;
            else {
                piece = f1.Text;
                f1.Text = "";
            }
        }

        private void f2_Click(object sender, EventArgs e)
        {
            if (f2.Text == "")
                f2.Text = piece;
            else {
                piece = f2.Text;
                f2.Text = "";
            }
        }

        private void f3_Click(object sender, EventArgs e)
        {
            if (f3.Text == "")
                f3.Text = piece;
            else {
                piece = f3.Text;
                f3.Text = "";
            }
        }

        private void f4_Click(object sender, EventArgs e)
        {
            if (f4.Text == "")
                f4.Text = piece;
            else {
                piece = f4.Text;
                f4.Text = "";
            }
        }

        private void f5_Click(object sender, EventArgs e)
        {
            if (f5.Text == "")
                f5.Text = piece;
            else {
                piece = f5.Text;
                f5.Text = "";
            }
        }

        private void f6_Click(object sender, EventArgs e)
        {
            if (f6.Text == "")
                f6.Text = piece;
            else {
                piece = f6.Text;
                f6.Text = "";
            }
        }

        private void f7_Click(object sender, EventArgs e)
        {
            if (f7.Text == "")
                f7.Text = piece;
            else {
                piece = f7.Text;
                f7.Text = "";
            }
        }

        private void f8_Click(object sender, EventArgs e)
        {
            if (f8.Text == "")
                f8.Text = piece;
            else {
                piece = f8.Text;
                f8.Text = "";
            }
        }

        private void g1_Click(object sender, EventArgs e)
        {
            if (g1.Text == "")
                g1.Text = piece;
            else {
                piece = g1.Text;
                g1.Text = "";
            }
        }

        private void g2_Click(object sender, EventArgs e)
        {
            if (g2.Text == "")
                g2.Text = piece;
            else {
                piece = g2.Text;
                g2.Text = "";
            }
        }

        private void g3_Click(object sender, EventArgs e)
        {
            if (g3.Text == "")
                g3.Text = piece;
            else {
                piece = g3.Text;
                g3.Text = "";
            }
        }

        private void g4_Click(object sender, EventArgs e)
        {
            if (g4.Text == "")
                g4.Text = piece;
            else {
                piece = g4.Text;
                g4.Text = "";
            }
        }

        private void g5_Click(object sender, EventArgs e)
        {
            if (g5.Text == "")
                g5.Text = piece;
            else {
                piece = g5.Text;
                g5.Text = "";
            }
        }

        private void g6_Click(object sender, EventArgs e)
        {
            if (g6.Text == "")
                g6.Text = piece;
            else {
                piece = g6.Text;
                g6.Text = "";
            }
        }

        private void g7_Click(object sender, EventArgs e)
        {
            if (g7.Text == "")
                g7.Text = piece;
            else {
                piece = g7.Text;
                g7.Text = "";
            }
        }

        private void g8_Click(object sender, EventArgs e)
        {
            if (g8.Text == "")
                g8.Text = piece;
            else {
                piece = g8.Text;
                g8.Text = "";
            }
        }

        private void h1_Click(object sender, EventArgs e)
        {
            if (h1.Text == "")
                h1.Text = piece;
            else {
                piece = h1.Text;
                h1.Text = "";
            }
        }

        private void h2_Click(object sender, EventArgs e)
        {
            if (h2.Text == "")
                h2.Text = piece;
            else {
                piece = h2.Text;
                h2.Text = "";
            }
        }

        private void h3_Click(object sender, EventArgs e)
        {
            if (h3.Text == "")
                h3.Text = piece;
            else {
                piece = h3.Text;
                h3.Text = "";
            }
        }

        private void h4_Click(object sender, EventArgs e)
        {
            if (h4.Text == "")
                h4.Text = piece;
            else {
                piece = h4.Text;
                h4.Text = "";
            }
        }

        private void h5_Click(object sender, EventArgs e)
        {
            if (h5.Text == "")
                h5.Text = piece;
            else {
                piece = h5.Text;
                h5.Text = "";
            }
        }

        private void h6_Click(object sender, EventArgs e)
        {
            if (h6.Text == "")
                h6.Text = piece;
            else {
                piece = h6.Text;
                h6.Text = "";
            }
        }

        private void h7_Click(object sender, EventArgs e)
        {
            if (h7.Text == "")
                h7.Text = piece;
            else {
                piece = h7.Text;
                h7.Text = "";
            }
        }

        private void h8_Click(object sender, EventArgs e)
        {
            if (h8.Text == "")
                h8.Text = piece;
            else {
                piece = h8.Text;
                h8.Text = "";
            }
        }
    }
}
