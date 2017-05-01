using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using FCTank.Properties;

namespace FCTank.Objects
{
    public class Tank : GameObject
    {
        public const int speed5 = 9;
        private int speed;
        private Direction dir;
        private int life;
        private bool isPlayer;
        public static Dictionary<int, Dictionary<Direction, Bitmap>> tankMaps;
        private int type;
        private int attack;
        private Manager manager;
        static Tank()
        {
            tankMaps = new Dictionary<int, Dictionary<Direction, Bitmap>>(6);
            Dictionary<Direction, Bitmap> tank1 = new Dictionary<Direction, Bitmap>(4);
            tank1.Add(Direction.W, Resources.enemy1W);
            tank1.Add(Direction.A, Resources.enemy1A);
            tank1.Add(Direction.S, Resources.enemy1S);
            tank1.Add(Direction.D, Resources.enemy1D);
            Dictionary<Direction, Bitmap> tank2 = new Dictionary<Direction, Bitmap>(4);
            tank2.Add(Direction.W, Resources.enemy2W);
            tank2.Add(Direction.A, Resources.enemy2A);
            tank2.Add(Direction.S, Resources.enemy2S);
            tank2.Add(Direction.D, Resources.enemy2D);
            Dictionary<Direction, Bitmap> tank3 = new Dictionary<Direction, Bitmap>(4);
            tank3.Add(Direction.W, Resources.enemy3W);
            tank3.Add(Direction.A, Resources.enemy3A);
            tank3.Add(Direction.S, Resources.enemy3S);
            tank3.Add(Direction.D, Resources.enemy3D);
            Dictionary<Direction, Bitmap> tank4 = new Dictionary<Direction, Bitmap>(4);
            tank4.Add(Direction.W, Resources.enemy4W);
            tank4.Add(Direction.A, Resources.enemy4A);
            tank4.Add(Direction.S, Resources.enemy4S);
            tank4.Add(Direction.D, Resources.enemy4D);
            Dictionary<Direction, Bitmap> player1 = new Dictionary<Direction, Bitmap>(4);
            player1.Add(Direction.W, Resources.p1tankW);
            player1.Add(Direction.A, Resources.p1tankA);
            player1.Add(Direction.S, Resources.p1tankS);
            player1.Add(Direction.D, Resources.p1tankD);
            Dictionary<Direction, Bitmap> player2 = new Dictionary<Direction, Bitmap>(4);
            player2.Add(Direction.W, Resources.p2tankW);
            player2.Add(Direction.A, Resources.p2tankA);
            player2.Add(Direction.S, Resources.p2tankS);
            player2.Add(Direction.D, Resources.p2tankD);
            tankMaps.Add(1, tank1);
            tankMaps.Add(2, tank2);
            tankMaps.Add(3, tank3);
            tankMaps.Add(4, tank4);
            tankMaps.Add(5, player1);
            tankMaps.Add(6, player2);
        }
        #region getter/setter
        public int getAttack()
        {
            return attack;
        }
        public void setAttack(int attack)
        {
            this.attack = attack;
        }
        public int getType()
        {
            return type;
        }
        public void setType(int type)
        {
            this.type = type;
        }
        public int getSpeed()
        {
            return speed;
        }
        public void setSpeed(int speed)
        {
            this.speed = speed;
        }
        public Direction getDir()
        {
            return dir;
        }
        public void setDir(Direction dir)
        {

            if ((this.dir == Direction.W || this.dir == Direction.S) && (dir == Direction.A || dir == Direction.D))
            {
                y = y % 30 <= 15 ? y - y % 30 : y + 30 - y % 30;
            }
            else if ((this.dir == Direction.A || this.dir == Direction.D) && (dir == Direction.W || dir == Direction.S))
            {
                x = x % 30 <= 15 ? x - x % 30 : x + 30 - x % 30;
            }

            this.dir = dir;
        }
        public int getLife()
        {
            return life;
        }
        public void setLife(int life)
        {
            this.life = life;
        }
        public bool getIsPlayer()
        {
            return isPlayer;
        }
        #endregion
        public Tank(int type, int speed, Direction dir, int life, bool isPlayer, int x, int y, int width, int height, bool canPass,Manager manager,int attack)
            : base(x, y, width, height, canPass)
        {
            this.attack = attack;
            this.type = type;
            this.speed = speed;
            this.dir = dir;
            this.life = life;
            this.isPlayer = isPlayer;        
            this.manager = manager;
        }
        public override void draw(Graphics g)
        {
            g.DrawImage(getTankBmp(type, dir), x, y, width, height);
        }
        public static Bitmap getTankBmp(int type, Direction dir)
        {
            return tankMaps[type][dir];
        }
        public void move()
        {
            if (dir == Direction.W)
            {
                y -= speed;
            }
            else if (dir == Direction.A)
            {
                x -= speed;
            }
            else if (dir == Direction.S)
            {
                y += speed;
            }
            else if (dir == Direction.D)
            {
                x += speed;
            }
        }
        public void fire()
        {
            manager.fire(this);
        }
    }
}
