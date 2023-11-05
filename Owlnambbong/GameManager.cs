﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
// 순서대로 1. ◆, 2. ♠, 3. ♥, 4. ♣
namespace Owlnambbong
{
    internal class GameManager
    {
        //
        public int[,] DECK = new int[4, 13] {{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, //◆, ♠, ♥, ♣
                                             { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,11, 12, 13 }, // ♠
                                             { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,11, 12, 13 }, // ♥
                                             { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,11, 12, 13 } }; // ♣


        public void GameStart() { }

        public void DrawCard(Player player) { 
            Random rand1 = new Random();
            Random rand2 = new Random();
            for (int i = 0; i < 2; i++)
            {
                int First = rand1.Next(0, 3);
                int Second = rand2.Next(0, 12);
                player.Card.Add(new Tuple<int, int>(First, Second));
                Console.WriteLine("카드를 뽑았습니다. !!!");
            }
        }

        public void ShowCard() { }

        public void Judgment() { }

    }
}

