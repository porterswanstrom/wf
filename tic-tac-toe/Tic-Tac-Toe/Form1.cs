﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class ticTacToe : Form
    {
        public ticTacToe()
        {
            InitializeComponent();
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            const int ROWS = 3, COLS = 3;
            int[,] grid = new int[ROWS, COLS];
            Random ran = new Random();
            bool xWins = false, oWins = false;

            for (int i = 0; i < ROWS; i++)
                for (int j = 0; j < COLS; j++)
                    grid[i, j] = ran.Next(2);

            tlLbl.Text = grid[0, 0] > 0? "X" : "O";
            tcLbl.Text = grid[0, 1] > 0? "X" : "O";
            trLbl.Text = grid[0, 2] > 0? "X" : "O";
            mlLbl.Text = grid[1, 0] > 0? "X" : "O";
            mcLbl.Text = grid[1, 1] > 0? "X" : "O";
            mrLbl.Text = grid[1, 2] > 0? "X" : "O";
            blLbl.Text = grid[2, 0] > 0? "X" : "O";
            bcLbl.Text = grid[2, 1] > 0? "X" : "O";
            brLbl.Text = grid[2, 2] > 0? "X" : "O";

            if ((tlLbl.Text == "X" && tcLbl.Text == "X" && trLbl.Text == "X") ||
                (mlLbl.Text == "X" && mcLbl.Text == "X" && mrLbl.Text == "X") ||
                (blLbl.Text == "X" && bcLbl.Text == "X" && brLbl.Text == "X") ||
                (tlLbl.Text == "X" && mlLbl.Text == "X" && blLbl.Text == "X") ||
                (tcLbl.Text == "X" && mcLbl.Text == "X" && bcLbl.Text == "X") ||
                (trLbl.Text == "X" && mrLbl.Text == "X" && brLbl.Text == "X") ||
                (tlLbl.Text == "X" && mcLbl.Text == "X" && brLbl.Text == "X") ||
                (blLbl.Text == "X" && mcLbl.Text == "X" && trLbl.Text == "X"))
                xWins = true;

            if ((tlLbl.Text == "O" && tcLbl.Text == "O" && trLbl.Text == "O") ||
                (mlLbl.Text == "O" && mcLbl.Text == "O" && mrLbl.Text == "O") ||
                (blLbl.Text == "O" && bcLbl.Text == "O" && brLbl.Text == "O") ||
                (tlLbl.Text == "O" && mlLbl.Text == "O" && blLbl.Text == "O") ||
                (tcLbl.Text == "O" && mcLbl.Text == "O" && bcLbl.Text == "O") ||
                (trLbl.Text == "O" && mrLbl.Text == "O" && brLbl.Text == "O") ||
                (tlLbl.Text == "O" && mcLbl.Text == "O" && brLbl.Text == "O") ||
                (blLbl.Text == "O" && mcLbl.Text == "O" && trLbl.Text == "O"))
                oWins = true;

            if (xWins && !oWins)
                winnerLbl.Text = "X wins!";
            else if (oWins && !xWins)
                winnerLbl.Text = "O wins!";
            else
                winnerLbl.Text = "It's a tie!";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            tlLbl.Text = "?";
            tcLbl.Text = "?";
            trLbl.Text = "?";
            mlLbl.Text = "?";
            mcLbl.Text = "?";
            mrLbl.Text = "?";
            blLbl.Text = "?";
            bcLbl.Text = "?";
            brLbl.Text = "?";
            winnerLbl.Text = "?";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
