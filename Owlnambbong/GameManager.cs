using System;
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
                player.Card.Add(Tuple.Create(First, Second));
            }
            Console.WriteLine("카드를 뽑았습니다. !!!");
        }

        public void ShowCard(Player player) { 
            foreach ( var value in player.Card)
            {
                int CardValue = player.Card.Sum(x => x.Item1);  //TUPLE item1(int) 불러오기
                Console.WriteLine(CardValue);
                // 위 식을 이용하여 item1의 값을 카드의 문자로 바꿔 출력하고
                // item2는 숫자 그대로 출력하여 플레이어가 뽑은 카드를 보여줄 수 있도록 한다.
            }
        }

        public void Judgment() {
            //플레어어가 추가로 카드를 뽑았을 때 그 수가 두 카드 값 사이로 들어온다면 승리하고 아니면 패배한다.
        }

    }
}

