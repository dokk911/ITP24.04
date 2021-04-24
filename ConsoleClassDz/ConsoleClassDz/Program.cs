using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassDz
{
    class Player
    {
        public int X;
        public int Y;
        public char Symbol;
        public ConsoleColor Color;

        public Player(int x, int y, char symbol, ConsoleColor color)
        {
            X = x;
            Y = y;
            Symbol = symbol;
            Color = color;
        }
    }

    class Rendering
    {
        public Player[] Player;

        public Rendering(Player[] player)
        {
            Player = player;
        }

        public void RenderingPlayer(Player[] player)
        {
            for (int i = 0; i < player.Length; i++)
            {
                Console.SetCursorPosition(player[i].X, player[i].Y);
                Console.ForegroundColor = player[i].Color;
                Console.Write(player[i].Symbol);
            }
        }
    }

    class Program
    {
        public static void Move()
        {
            int player1PositionX = 5;
            int player1PositionY = 4;

            int player2PositionX = 9;
            int player2PositionY = 7;

            while (true)
            {
                Console.Clear();

                Player[] player = { new Player(player1PositionX, player1PositionY, '@', ConsoleColor.Red),
                new Player(player2PositionX, player2PositionY, '#', ConsoleColor.Yellow) };

                Rendering rendering = new Rendering(player);

                rendering.RenderingPlayer(player);

                ConsoleKeyInfo userInput = Console.ReadKey();

                switch (userInput.Key)
                {
                    case ConsoleKey.A:
                        player1PositionX--;
                        break;
                    case ConsoleKey.W:
                        player1PositionY--;
                        break;
                    case ConsoleKey.D:
                        player1PositionX++;
                        break;
                    case ConsoleKey.S:
                        player1PositionY++;
                        break;
                    case ConsoleKey.LeftArrow:
                        player2PositionX--;
                        break;
                    case ConsoleKey.UpArrow:
                        player2PositionY--;
                        break;
                    case ConsoleKey.RightArrow:
                        player2PositionX++;
                        break;
                    case ConsoleKey.DownArrow:
                        player2PositionY++;
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Move();
        }
    }
}
