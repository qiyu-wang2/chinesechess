using System;
using System.Collections.Generic;
using System.Text;

namespace XQ2
{
    class GameDisplay
    {


        //画棋盘
        public void DisplayBoard()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            int line = 0;
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    
                    if (GameBoard.gameboard[i, j] == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("十");
                    }                        
                    else
                    {
                        Console.Write(Program.pie[Program.ChangeTopie(GameBoard.gameboard[i, j])].ToString());
                    }
                    /*if (GameBoard.gameboard[i, j] == -7)
                        Console.Write("将");

                    if (GameBoard.gameboard[i, j] == 7)
                        Console.Write("帅");

                    if (GameBoard.gameboard[i, j] == -31 || GameBoard.gameboard[i, j] == -32)
                        Console.Write("车");
                    if (GameBoard.gameboard[i, j] == -41 || GameBoard.gameboard[i, j] == -42)
                        Console.Write("马");
                    if (GameBoard.gameboard[i, j] == -51 || GameBoard.gameboard[i, j] == -52)
                        Console.Write("象");
                    if (GameBoard.gameboard[i, j] == -61 || GameBoard.gameboard[i, j] == -62)
                        Console.Write("士");
                    if (GameBoard.gameboard[i, j] == 31 || GameBoard.gameboard[i, j] == 32)
                        Console.Write("車");
                    if (GameBoard.gameboard[i, j] == 41 || GameBoard.gameboard[i, j] == 42)
                        Console.Write("馬");
                    if (GameBoard.gameboard[i, j] == 51 || GameBoard.gameboard[i, j] == 52)
                        Console.Write("相");
                    if (GameBoard.gameboard[i, j] == 61 || GameBoard.gameboard[i, j] == 62)
                        Console.Write("仕");
                    if (GameBoard.gameboard[i, j] == -11 || GameBoard.gameboard[i, j] == -12 || GameBoard.gameboard[i, j] == -13 
                        || GameBoard.gameboard[i, j] == -14 || GameBoard.gameboard[i, j] == -15)
                        Console.Write("卒");
                    if (GameBoard.gameboard[i, j] == 11 || GameBoard.gameboard[i, j] == 12 || GameBoard.gameboard[i, j] == 13 || 
                        GameBoard.gameboard[i, j] == 14 || GameBoard.gameboard[i, j] == 15)
                        Console.Write("兵");
                    if (GameBoard.gameboard[i, j] == -21 || GameBoard.gameboard[i, j] == -22)
                        Console.Write("砲");
                    if (GameBoard.gameboard[i, j] == 21 || GameBoard.gameboard[i, j] == 22)
                        Console.Write("炮");*/

                    if (j < 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("一");
                    }
                       
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(" ");
                Console.Write(line);
                line++;
                if (i < 9)
                {
                    if (i != 4)
                    {

                        Console.Write("\n");
                        for(int j = 0; j < 9; j++)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("┃   ");
                        }
                    }
                    if (i == 4)
                    {
                        Console.Write("\n");
                        for (int j = 0; j < 9; j++)
                        {

                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("    ");
                        }
                    }

                    Console.Write("\n");
                }

            }
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("0   1   2   3   4   5   6   7   8");

        }
        
        //判断上下左右有没有被选中点
        public static Boolean JudgeChoosedPoint(int i, int j, Point[] ps) 
        {
            for(int num = 0; num < ps.Length; num++)
            {
                
                /*if (i-1 == ps[num].getX()&& j == ps[num].getY())
                {
                    return false;
                }

                if (i+1 == ps[num].getX() && j == ps[num].getY())
                {
                    return false;
                }*/

                if (i == ps[num].getX() && j == ps[num].getY())
                {
                    return false;
                }

                if (i == ps[num].getX() && j+1 == ps[num].getY())
                {
                    return false;
                }
            }
            return true;
        }

        public static Boolean JCP2(int i, int j, Point[] ps)
        {
            for (int num = 0; num < ps.Length; num++)
            {
                //上方
                if (i == ps[num].getX() && j == ps[num].getY())
                {
                    return false;
                }
                //下方
                if (i+1 == ps[num].getX() && j == ps[num].getY())
                {
                    return false;
                }

              
            }
            return true;
        }

        //显示可走位置
        public static void Show(Point[] ps)
        {
            Console.BackgroundColor =ConsoleColor.DarkYellow;
            int line = 0;
                for (int i = 0; i < 10; i++)
                {

                    for (int j = 0; j < 9; j++)
                    {

                    if (GameBoard.gameboard[i, j] == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("十");
                    }
                    else
                    {
                        Console.Write(Program.pie[Program.ChangeTopie(GameBoard.gameboard[i, j])].ToString());
                    }

                    if (j < 8 && JudgeChoosedPoint(i, j, ps))
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("一");
                    }//改动
                    else if (j < 8 && !JudgeChoosedPoint(i, j, ps))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("一");
                    }

                }


                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(line);
                    line++;
                    if (i < 9)
                    {                    
                    if (i != 4)
                        {

                        Console.Write("\n");//改动
                        for (int j = 0; j < 9; j++)
                        {
                            
                            if (JCP2(i, j, ps))
                            {
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("┃   ");
                            }
                            else if (!JCP2(i, j, ps))
                            {
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("┃   ");
                            }
                        }
                    }
                        if (i == 4)
                        {
                        Console.Write("\n");
                        for (int j = 0; j < 9; j++)
                        {

                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("    ");
                        }
                    }

                        Console.Write("\n");
                    }

                }
                Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("0   1   2   3   4   5   6   7   8");

            
        }
        
       

    }
}

        
