using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FCTank.Properties;

namespace FCTank.Objects
{
    public class Bullet : GameObject
    {
        public  static  Bitmap PlayerBulletBmp = Resources.tankmissile;
        public static Bitmap EnemyBulletBmp = Resources.enemymissile;
        private bool isPlayerBullet;
        private int speed;
        private int attack;
        private Direction dir;
        private Tank tank;
        public Bullet(int x, int y, int width, int height, bool canPass, bool isPlayerBullet, int speed, int attack,Direction dir,Tank tank)
            : base(x, y, width, height, canPass)
        {
            this.tank = tank;
            this.dir = dir;         
            this.isPlayerBullet = isPlayerBullet;
            this.speed = speed;
            this.attack = attack;
        }

        public Tank getTank()
        {
            return tank;
        }
        public bool getIsPlayerBullet()
        {
            return isPlayerBullet;
        }
        public int getSpeed()
        {
            return speed;
        }
        public int Getattack()
        {
            return attack;
        }
        public override void draw(Graphics g)
        {
            if (getIsPlayerBullet()) g.DrawImage(PlayerBulletBmp, x, y, width, height);
            else g.DrawImage(EnemyBulletBmp, x, y, width, height);
        }
        public void move()
        {
            if (dir == Direction.W) y -= speed;
            else if (dir == Direction.A) x -= speed;
            else if (dir == Direction.S) y += speed;
            else if (dir == Direction.D) x += speed;
        }
    }
}
