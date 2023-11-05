using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//
namespace Owlnambbong
{
    public class Player
    {
        GameManager GameManager = new();
        private int Money;
        public Tuple<int, int> PlayerCard;
        public int bettingMoney;
        
        public Player()
        {
            Money = 10000;
            bettingMoney = 1000;
        }

        public void PlayerBetting()
        {
            Console.WriteLine("베팅할 금액을 입력해주세요 : ");
            Console.WriteLine("베팅 금액은 최소 1000원 이상이여야 합니다!!");
            bettingMoney = int.Parse(Console.ReadLine());

            if (bettingMoney < 1000)
            {
                Console.WriteLine("베팅 금액이 너무 작습니다 1000원 이상 베팅해주세요..");
                PlayerBetting();
            }
            else
            {
                return;
            }
            Console.ReadKey();

        }

        public void GameEnding()
        {
            if(Money > 30000)
            {
                Console.WriteLine("축하합니다! 플레이어가 최대 금액을 모았습니다!");
                Console.WriteLine("현재 돈 : {0}", Money);
            } else if(Money <= 0) {
                Console.WriteLine("당신은 모든걸 꼴아박았습니다 현재 돈이 0원 이하입니다");
                Console.WriteLine("현재 돈 : {0}", Money);
            }
        }

        public void PlayerWin()
        {
            Money += bettingMoney * 2;
        }

        public void PlayerLose()
        {
            Money -= bettingMoney;
        }

        public void DrawCard()
        {
            Random rand1 = new();
            Random rand2 = new();

            int First = rand1.Next(0, 3);
            int Second = rand2.Next(0, 12);
            PlayerCard = new Tuple<int, int>(First, Second);
            Console.WriteLine("플레이어가 카드를 뽑습니다!");
            Console.WriteLine();
            Console.WriteLine("뽑은 카드는 ::     ");
            if (PlayerCard.Item1 == 0)
            {
                Console.Write("◆-");
                Console.Write("{0} ", PlayerCard.Item2);
            }
            else if (PlayerCard.Item1 == 1)
            {
                Console.Write("♠-");
                Console.Write("{0} ", PlayerCard.Item2);
            }
            else if (PlayerCard.Item1 == 2)
            {
                Console.Write("♥-");
                Console.Write("{0} ", PlayerCard.Item2);
            }
            else if (PlayerCard.Item1 == 3)
            {
                Console.Write("♣-");
                Console.Write("{0} ", PlayerCard.Item2);
            }
        }

        
    }
}
