using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FCTank.Objects;

namespace FCTank
{
    public class Factory
    {
        public static Wall createWall(wallType type,int x,int y)
        {
            if(wallType.wall==type)
            {
                return new Wall(x*30,y*30, 30, 30, false, 1, wallType.wall);
            }
            else if(wallType.steel==type)
            {
                return new Wall(x * 30, y * 30, 30, 30, false, 3, wallType.steel);
            }
            else if(wallType.grass==type)
            {
                return new Wall(x * 30, y * 30, 30, 30, true, 1, wallType.grass);
            }
            else if(wallType.water==type)
            {
                return new Wall(x * 30, y * 30, 30, 30, true, 1, wallType.water);
            }
            else if(wallType.home==type)
            {
                return new Wall(x * 30, y * 30, 60, 60, false, 1, wallType.home);
            }
            return null;
        }
    }
}
