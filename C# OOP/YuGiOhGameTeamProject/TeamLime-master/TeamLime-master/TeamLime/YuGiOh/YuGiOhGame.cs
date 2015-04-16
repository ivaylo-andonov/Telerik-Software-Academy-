using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOh
{
    using YuGiOh.Interfaces;
    using YuGiOh.Players;

    public class YuGiOhGame: IYuGiOhGame
    {

        public void Start()
        {
            Console.WriteLine("FIRST HERO < 2000 Health >");
            
        }

        public int FirstPlayerTotalPoints
        {
            get { throw new NotImplementedException(); }
        }

        public int SecondPlayerTotalPoints
        {
            get { throw new NotImplementedException(); }
        }

        
 
    }
}
