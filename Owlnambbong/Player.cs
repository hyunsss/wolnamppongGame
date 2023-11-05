using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//
namespace Owlnambbong
{
    internal class Player
    {
        private int Money;
        public List<Tuple<int, int>> Card;

        public Player()
        {
            Card = new List<Tuple<int, int>>();
        }
    }
}
