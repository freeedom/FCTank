using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FCTank.Objects;
using System.Drawing;

namespace FCTank
{
    public class Manager
    {
        public Tank player1Tank;
        public Tank player2Tank;
         bool hasTwoPlayer;
         List<Tank> enemyTankList;
         List<Bullet> enemyBulletList;
         List<Bullet> playerBulletList;
         List<Wall> wallList;
        public Manager()
        {
            init();
        }
        private void init()
        {
            player1Tank = new Tank(5, 0, Direction.W, 4, true, 360, 720, 60, 60, false,this,1);
            enemyTankList = new List<Tank>();
            enemyBulletList = new List<Bullet>();
            playerBulletList = new List<Bullet>();
            wallList = new List<Wall>();
            initMap();
        }
        private void initMap()
        {
            wallList.Add(new Wall(30,30,30,30,false,1,wallType.wall));
            wallList.Add(new Wall(60, 30, 30, 30, false, 1, wallType.wall));
            wallList.Add(new Wall(30, 60, 30, 30, false, 1, wallType.wall));
            wallList.Add(new Wall(60, 60, 30, 30, false, 1, wallType.wall));

            wallList.Add(new Wall(120, 30, 30, 30, false, 3, wallType.steel));
            wallList.Add(new Wall(150, 30, 30, 30, false, 3, wallType.steel));
            wallList.Add(new Wall(120, 60, 30, 30, false, 3, wallType.steel));
            wallList.Add(new Wall(150, 60, 30, 30, false, 3, wallType.steel));

            wallList.Add(new Wall(300, 30, 30, 30, true, 1, wallType.grass));
            wallList.Add(new Wall(330, 30, 30, 30, true, 1, wallType.grass));
            wallList.Add(new Wall(300, 60, 30, 30, true, 1, wallType.grass));
            wallList.Add(new Wall(330, 60, 30, 30, true, 1, wallType.grass));

            wallList.Add(new Wall(420, 30, 30, 30, true, 1, wallType.water));
            wallList.Add(new Wall(450, 30, 30, 30, true, 1, wallType.water));
            wallList.Add(new Wall(420, 60, 30, 30, true, 1, wallType.water));
            wallList.Add(new Wall(450, 60, 30, 30, true, 1, wallType.water));
        }
        /**
         *检查子弹是否击中子弹，坦克，墙，出界，并移除子弹，坦克，墙
         */
        public void hit()
        {
           for(int i=playerBulletList.Count-1;i>=0;i--)
           {
               for(int j=enemyBulletList.Count-1;j>=0;j--)
               {
                   if(playerBulletList[i].getRectangle().IntersectsWith(enemyBulletList[j].getRectangle()))
                   {
                       playerBulletList.RemoveAt(i);
                       enemyBulletList.RemoveAt(j);
                   }
               }
           } 
          for(int i=playerBulletList.Count-1;i>=0;i--)
          {
              for(int j=enemyTankList.Count-1;j>=0;j--)
              {
                  if(playerBulletList[i].getRectangle().IntersectsWith(enemyTankList[j].getRectangle()))
                  {
                      playerBulletList.RemoveAt(i);
                      enemyTankList.RemoveAt(j);
                  }
              }
          }
          for(int i=enemyBulletList.Count-1;i>=0;i--)
          {
              //敌方子弹击中玩家
          }
          for(int i=playerBulletList.Count-1;i>=0;i--)
          {
              bool rmBullet = false;
              for(int j=wallList.Count-1;j>=0;j--)
              {
                  if(playerBulletList[i].getRectangle().IntersectsWith(wallList[j].getRectangle())&&(playerBulletList[i].Getattack()>=wallList[j].getHardness())&&(wallList[j].isCanPass()==false))
                  {
                      rmBullet = true;
                      wallList.RemoveAt(j);
                  }
                  if (playerBulletList[i].getRectangle().IntersectsWith(wallList[j].getRectangle()) && (playerBulletList[i].Getattack() < wallList[j].getHardness()) && (wallList[j].isCanPass() == false))
                  {
                      rmBullet = true;
                  }
              }
              if (rmBullet) playerBulletList.RemoveAt(i);
          }

          for (int i = enemyBulletList.Count - 1; i >= 0; i--)
          {
              bool rmBullet = false;
              for (int j = wallList.Count - 1; j >= 0; j--)
              {
                  if (enemyBulletList[i].getRectangle().IntersectsWith(wallList[j].getRectangle()) && (enemyBulletList[i].Getattack() >= wallList[j].getHardness()) && (wallList[j].isCanPass() == false))
                  {
                      rmBullet = true;
                      wallList.RemoveAt(j);
                  }
                  if (enemyBulletList[i].getRectangle().IntersectsWith(wallList[j].getRectangle()) && (enemyBulletList[i].Getattack() < wallList[j].getHardness()) && (wallList[j].isCanPass() == false))
                  {
                      rmBullet = true;
                  }
              }
              if (rmBullet) enemyBulletList.RemoveAt(i);
          }
          for(int i=playerBulletList.Count-1;i>=0;i--)
          {
              Bullet tmp = playerBulletList[i];
              if (tmp.getX() < 0 || tmp.getX() > 780 || tmp.getY() < 0 || tmp.getY() > 780) playerBulletList.RemoveAt(i);
          }
          for(int i=enemyBulletList.Count-1;i>=0;i--)
          {
              Bullet tmp = enemyBulletList[i];
              if (tmp.getX() < 0 || tmp.getX() > 780 || tmp.getY() < 0 || tmp.getY() > 780) enemyBulletList.RemoveAt(i);
          }
        }
        public void fire(Tank tank)
        {
            for(int i=0;i<playerBulletList.Count;i++)
            {
                if (playerBulletList[i].getTank().Equals(tank)) return;
            }
            for(int i=0;i<enemyBulletList.Count;i++)
            {
                if (enemyBulletList[i].getTank().Equals(tank)) return;
            }
            int x=0, y=0;
            if (tank.getDir() == Direction.W) { x = tank.getX() + 22; y = tank.getY() - 15; }
            else if (tank.getDir() == Direction.A) { x = tank.getX() - 15; y = tank.getY() + 22; }
            else if (tank.getDir() == Direction.S) { x = tank.getX() + 22; y = tank.getY() + 60; }
            else if (tank.getDir() == Direction.D) { x = tank.getX() + 60; y = tank.getY() + 22; }
            Bullet bullet = new Bullet(x, y, 15, 15, false, tank.getIsPlayer(), 18, tank.getAttack(),tank.getDir(),tank);
            if (tank.getIsPlayer()) playerBulletList.Add(bullet);
            else enemyBulletList.Add(bullet);
        }
        public void draw(Graphics g)
        {
            player1Tank.draw(g);
            for (int i = 0; i < enemyTankList.Count; i++) enemyTankList[i].draw(g);
            for (int i = 0; i < playerBulletList.Count; i++) playerBulletList[i].draw(g);
            for (int i = 0; i < enemyBulletList.Count; i++) enemyBulletList[i].draw(g);
            for (int i = 0; i < wallList.Count; i++) wallList[i].draw(g);
        }
        public void move()
        {
            for(int i=0;i<playerBulletList.Count;i++)
            {
                playerBulletList[i].move();
            }
            player1Tank.move();
        }
    }
}
