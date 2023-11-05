using Owlnambbong;

internal class Program
{

    static void Main(string[] args)
    {
        //
        GameManager manager = new();
        Player player = new();
        while(true)
        {
            //게임시작
            manager.GameStart();
            //카드를뽑는다
            manager.DrawCard();
            //플레이어가 무슨 카드를 뽑았는지 보여준다
            player.DrawCard();
            //베팅을 건다 두장의 카드 값이 같거나 1밖에 차이가 안나더라도 최소 베팅금액은 걸어야한다.
            ////플레이어가 다이를 원한다면 딜러가 고른 카드를 보여줍니다. 
            manager.Gamming(player);
            //manager Judgment를 통해 승부를 가리고
            //승리한다면 2배 얻고 패배한다면 차감된다
            manager.Judgment(player);
            //플레이어의 돈이 3만원이 넘으면 승리, 천원 아래면 게임오버 된다.
            player.GameEnding();
        }
        


    }
}
