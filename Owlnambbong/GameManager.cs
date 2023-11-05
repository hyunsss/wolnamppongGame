using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

        public List<Tuple<int, int>> Card;
        public GameManager()
        {
            Card = new List<Tuple<int, int>>();
        }
        public void Gamming(Player player)
        {
            Console.Write("플레이어가 원하는 진행을 선택해주세요. ->  ");
            Console.WriteLine("베팅을 원하시면 '베팅'아니면 '다이'를 선택해 주시기 바랍니다. ");
            string Player_choice = Console.ReadLine();
            switch (Player_choice)
            {
                case "베팅":
                    player.PlayerBetting();
                    break;
                case "다이":
                    Console.WriteLine("두 장의 카드는 -->>>>>");
                    ShowCard();
                    Console.WriteLine("게임을 다시 시작하시겠습니까????? ex) Y, y, yes, 네");
                    Player_choice = Console.ReadLine();
                    switch (Player_choice)
                    {
                        case "Y":
                        case "y":
                        case "yes":
                        case "네":
                            GameStart();
                            break;
                        default:
                            GameStart();
                            break;
                    }
                    break;
            }
        }

        public void GameStart() {
            Console.WriteLine("게임을 시작합니다!! ");
            Console.WriteLine("먼저 딜러가 카드 두개를 선택 할 것입니다. ");
            Console.ReadKey();
        }

        public void DrawCard() { 
            Random rand1 = new Random();
            Random rand2 = new Random();
            for (int i = 0; i < 2; i++)
            {
                int First = rand1.Next(0, 3);
                int Second = rand2.Next(0, 12);
                Card.Add(new Tuple<int , int>(First, Second));
            }
            Console.WriteLine("딜러가 카드를 뽑았습니다. !!!");
            Console.ReadKey();
        }

        public void ShowCard() {
            Console.Write("두 장의 카드는 ????? =====> ");
            foreach ( var value in Card)
            {
                int i = 0;
                // 위 식을 이용하여 item1의 값을 카드의 문자로 바꿔 출력하고
                if (Card[index: i].Item1 == 0)
                {
                    Console.Write("◆-");
                    Console.Write("{0} ", Card[i].Item2);
                } else if(Card[index: i].Item1 == 1)
                {
                    Console.Write("♠");
                    Console.Write("{0} ", Card[i].Item2);
                } else if(Card[index: i].Item1 == 2)
                {
                    Console.Write("♥");
                    Console.Write("{0} ", Card[i].Item2);
                } else if(Card[index: i].Item1 == 3)
                {
                    Console.Write("♣");
                    Console.Write("{0} ", Card[i].Item2);
                }
                Console.Write(" . ");
                // item2는 숫자 그대로 출력하여 플레이어가 뽑은 카드를 보여줄 수 있도록 한다.
                i++;
            }
            Console.ReadKey();
            Console.WriteLine("입니다!!!!");
        }

        public void Judgment(Player player) {
            //플레어어가 추가로 카드를 뽑았을 때 그 수가 두 카드 값 사이로 들어온다면 승리하고 아니면 패배한다.
            //리스트 정렬하기
            Card.Sort((x, y) => y.Item2.CompareTo(x.Item2));

            //카드 판정
            if(player.PlayerCard.Item2 > Card[0].Item2 && player.PlayerCard.Item2 < Card[1].Item2)
            {
                //플레이어 승리
                Console.WriteLine(Card[0].Item2);
                Console.WriteLine("축하합니다 베팅에서 승리하셨습니다!!");
                player.PlayerWin();
            } else
            {
                player.PlayerLose();
                ShowCard();
                Console.WriteLine("ㅠㅠ 베팅 실패하셨습니다");
                Console.ReadKey();                
            }

        }

    }
}

