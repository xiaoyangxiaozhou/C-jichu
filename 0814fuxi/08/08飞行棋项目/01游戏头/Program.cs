﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01游戏头
{
    class Program
    {
        //用静态字段模拟全局变量
        static int[] Maps=new int[100];
        //声明一个静态数组来存储玩家A跟玩家B的坐标
        static int[] PlayerPos=new int[2];
        //存储两个玩家的姓名
        static string[] PlayerNames = new string[2];

        //两个玩家的标记
        static bool[] Flags = new bool[2];//bool默认是false

        static void Main(string[] args)
        {
            GameShow();//游戏标题
            #region
            //输入玩家姓名
            Console.WriteLine("请输入玩家A的姓名");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0] == "")
            {
                Console.WriteLine("玩家A的姓名不能为空，请重新输入");
                PlayerNames[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名");
            PlayerNames[1] = Console.ReadLine();
            while(PlayerNames[1] == ""||PlayerNames[1]==PlayerNames[0])
            {
                if (PlayerNames[1] == "")
                {
                    Console.WriteLine("玩家B的姓各不能为空，请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家A的姓名不能与玩家B的姓名相同，请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }
            }
            #endregion
            //玩家姓名输入OK后，我们首先应该清屏
            Console.Clear();
            GameShow();
            Console.WriteLine("{0}的士兵用A表示",PlayerNames[0]);
            Console.WriteLine("{0}的士兵用B表示",PlayerNames[1]);
            InitailMap();//画地图前，应初始化地图
            DrawMap();//画地图
            while(PlayerPos[0]<99&&PlayerPos[1]<99)
            {
                if (Flags[0] == false)
                {
                    PlayGame(0);

                }
                else
                {
                    Flags[0] = false;
                }
                if (PlayerPos[0] >= 99)
                {
                    Console.WriteLine("玩家{0}无耻赢了玩家{1}",PlayerNames[0],PlayerNames[1]);
                    break;
                }
                if (Flags[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    Flags[1] = false;
                }
                if(PlayerPos[1]>=99)
                {
                Console.WriteLine("玩家{0}无耻赢了玩家{1}",PlayerNames[1],PlayerNames[0]);
                break;
                }

            }
            Console.WriteLine("胜利");
            Console.ReadKey();

        }
        /// <summary>
        /// 画游戏头
        /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**********************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**********************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**********************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***.Net基础班飞行棋***");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**********************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**********************");
        }

        /// <summary>
        /// 初始化地图，显示用户□幸运轮盘◎；地雷☆，暂停▲，时空隧道⊙
        /// </summary>
        public static void InitailMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘
            for (int i = 0; i < luckyturn.Length; i++)
            {
                Maps[luckyturn[i]] = 1;
            }
            int[] landMine = {5,13,17,33,38,50,64,80,94};//地雷
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }
            int[] pause = {9,27,60,93};//暂停
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            int[] timeTunnel = {20,25,45,63,72,88,90};//时空隧道
            for (int i = 0; i <timeTunnel.Length ; i++)
            {
                Maps[timeTunnel[i]]=4;
            }
        
        }

        /// <summary>
        /// 画地图
        /// </summary>
        public static void DrawMap()
        {
            Console.WriteLine("图例：幸运轮盘◎；地雷☆，暂停▲，时空隧道⊙");
            #region
            //第一横行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();//画完第一横行后换行
            #endregion
            #region
            //第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j= 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(DrawStringMap(i));
                Console.WriteLine();//画完横行后换行
            }
            #endregion
            #region
            //第二横行
            for (int i = 64; i>=35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            //画完第二横行
            Console.WriteLine();
            #endregion
            #region
            //第二竖行
            for (int i = 65; i <=69; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            }
            //第三横行
            #endregion
            #region
            for (int i = 70; i < 100; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
            #endregion
        }//DrawMap方法的结尾

        /// <summary>
        /// 从画地图的方法中抽象出来的一个方法
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static string DrawStringMap(int i)
        {
            string str = "";
            //如果玩家A跟玩家B的坐标相同，并且都在这个地图上，画一个尖括号
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == i)
            {
                str="<>";
            }
            else if (PlayerPos[0] == i)
            {
                str="Ａ";//全角
            }
            else if (PlayerPos[1] == i)
            {
                str="Ｂ";//全角
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        str="□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str="◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str="☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str="▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str="⊙";
                        break;
                }
            }
            return str;
        }

        /// <summary>
        /// 玩游戏
        /// </summary>
        public static void PlayGame(int playerNumber)
        {
            Random r = new Random();
            int rNumber = r.Next(1,7);
            Console.WriteLine("{0}按任意键执骰子", PlayerNames[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}掷出了{1}", PlayerNames[playerNumber],rNumber);
            PlayerPos[playerNumber] += rNumber;
            ChangePos();
            Console.ReadKey(true);
            Console.WriteLine("{0}按任意开始行动", PlayerNames[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", PlayerNames[playerNumber]);
            Console.ReadKey(true);
            //玩家A踩到玩家B，玩家B退6格
            if (PlayerPos[playerNumber] == PlayerPos[1 - playerNumber])
            {
                Console.WriteLine("玩家{0}踩到玩家{1},玩家{2}退6格", PlayerNames[playerNumber], PlayerNames[1 - playerNumber], PlayerNames[1 - playerNumber]);
                PlayerPos[1 - playerNumber] -= 6;
                ChangePos();
                Console.ReadKey(true);
            }
            else //踩到了关卡
            {
                //玩家的坐标
                switch (Maps[PlayerPos[playerNumber]])
                {
                    case 0: Console.WriteLine("玩家{0}踩到了方块,安全。", PlayerNames[playerNumber]);
                        Console.ReadKey(true);
                        break;
                    case 1: Console.WriteLine("玩家{0}踩到了幸运轮盘，请选择1-交换位置  2－轰炸对方，使对方退6格", PlayerNames[playerNumber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}选择跟玩家{1}交换位置", PlayerNames[playerNumber], PlayerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                int temp = PlayerPos[playerNumber];
                                PlayerPos[playerNumber] = PlayerPos[1 - playerNumber];
                                PlayerPos[1 - playerNumber] = temp;
                                Console.WriteLine("交换完成！！按任意键继续游戏");
                                Console.ReadKey(true);
                                break;
                            }
                            if (input == "2")
                            {
                                Console.WriteLine("玩家{0}选择轰炸玩家{1}，玩家{2}退六格", PlayerNames[playerNumber], PlayerNames[1 - playerNumber], PlayerNames[1 - playerNumber]);
                                PlayerPos[1 - playerNumber] -= 6;
                                ChangePos();
                                Console.WriteLine("玩家{0}退了6格", PlayerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能输入1或者2，1-交换位置  2－轰炸对方");
                                input = Console.ReadLine();
                            }

                        }
                        break;
                    case 2: Console.WriteLine("玩家{0}踩到了地雷，退六格", PlayerNames[playerNumber]);
                        PlayerPos[playerNumber] -= 6;
                        ChangePos();
                        Console.ReadKey(true);
                        break;
                    case 3: Console.WriteLine("玩家{0}踩到了暂停，暂停一回合", PlayerNames[playerNumber]);
                        Flags[playerNumber] = true;
                        break;
                    case 4: Console.WriteLine("玩家{0}踩到了时空隧道，前进10格", PlayerNames[playerNumber]);
                        PlayerPos[playerNumber] += 10;
                        ChangePos();
                        Console.ReadKey(true);
                        break;

                }
            }
            ChangePos();
            Console.Clear();
            DrawMap();
        }

        /// <summary>
        /// 当玩家坐标发生改变的时候调用
        /// </summary>
        public static void ChangePos()
        {
            if (PlayerPos[0] < 0)
            {
                PlayerPos[0] = 0;
            }
            if (PlayerPos[0] >= 99)
            {
                PlayerPos[0] = 99;
            }
            if (PlayerPos[1] < 0)
            {
                PlayerPos[1] = 0;
            }
            if (PlayerPos[1] >= 99)
            {
                PlayerPos[1] = 99;
            }
        }
    }
}
