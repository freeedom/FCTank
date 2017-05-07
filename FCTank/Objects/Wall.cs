using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FCTank.Properties;

namespace FCTank.Objects
{
    public enum wallType
    {
        wall,steel,water,grass,home,none
    }
    [Serializable]
    public class Wall :GameObject,ICloneable
    {
        public static Bitmap wallBmp = Resources.wall;
        public static Bitmap steelBmp = Resources.steel;
        public static Bitmap waterBmp = Resources.water;
        public static Bitmap grassBmp = Resources.grass;
        public static Bitmap homeBmp = Resources.home;
        private int hardness;
        private wallType type;
        public int getHardness()
        {
            return hardness;
        }
        public void setHardness(int hardness)
        {
            this.hardness = hardness;
        }
        public wallType getWallType()
        {
            return type;
        }
        public void setWallType(wallType type)
        {
            this.type = type;
        }
        public Wall(int x, int y, int width, int height, bool canPass,int hardness,wallType type):base(x,y,width,height,canPass)
        {         
            this.hardness=hardness;
            this.type = type;
        }
        public override void draw(Graphics g)
        {
            if (type == wallType.grass) g.DrawImage(grassBmp, x, y, width, height);
            else if (type == wallType.steel) g.DrawImage(steelBmp, x, y, width, height);
            else if (type == wallType.wall) g.DrawImage(wallBmp, x, y, width, height);
            else if (type == wallType.water) g.DrawImage(waterBmp, x, y, width, height);
            else if (type == wallType.home) g.DrawImage(homeBmp, x, y, width, height);
        }

        public object Clone()
        {
            Wall wall = new Wall(this.x, this.y, this.width, this.height, this.canPass, this.hardness, this.type);
            return wall;
        }
    }
}
