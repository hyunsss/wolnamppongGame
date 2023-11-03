using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 순서대로 1. ◆, 2. ♠, 3. ♥, 4. ♣
namespace Owlnambbong
{
    internal class GameManager
    {
        public int[,] DECK = new int[4, 13] {{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, //◆, ♠, ♥, ♣
                                             { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,11, 12, 13 }, // ♠
                                             { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,11, 12, 13 }, // ♥
                                             { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,11, 12, 13 } }; // ♣



        public void GameStart() { }

        public void DrawCard() { }

        public void Judgment() { }


    }
}

