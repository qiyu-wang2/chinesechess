﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XQ2
{
    class GameBoard
    {
        public static int[,] gameboard = new int[10,9] {
        { -31,-41,-51,-61, -7,-62,-52,-42,-32},
        {   0,  0,  0,  0,  0,  0,  0,  0,  0},
        {   0,-21,  0,  0,  0,  0,  0,-22,  0},
        {  -11, 0,-12,  0,-13,  0,-14,  0,-15},
        {   0,  0,  0,  0,  0,  0,  0,  0,  0},

        {   0,  0,  0,  0,  0,  0,  0,  0,  0},
        {  11,  0, 12,  0, 13,  0, 14,  0, 15},
        {   0, 21,  0,  0,  0,  0,  0, 22,  0},
        {   0,  0,  0,  0,  0,  0,  0,  0,  0},
        {  31, 41, 51, 61,  7, 62, 52, 42, 32}};

        public void SwitchPlayer()
        {

        }

        public void SelectPiece()
        {

        }
        public void MovePiece(int[] PlayerMove)
        {

        }

        public void CalculateValidMoves()
        {

        }


    }
}
