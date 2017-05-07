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
         bool hasTwoPlayer;
         Dictionary<string, Tank> playerTankTable;
         public Tank player1Tank; 
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
             player1Tank = new Tank(5, 0, Direction.W, 4, true, 270, 720, 60, 60, false,this,1);
             playerTankTable = new Dictionary<string, Tank>();
             playerTankTable.Add("player1", player1Tank);
            enemyTankList = new List<Tank>();
            enemyBulletList = new List<Bullet>();
            playerBulletList = new List<Bullet>();          
            enemyTankList.Add(new Tank(1, 0, Direction.D, 1, false, 270, 270, 60, 60, false, this, 1));
        }
        public void setMap(List<Wall> wallList)
        {
            this.wallList = wallList;
        }

        /**
         *检查子弹是否击中子弹，坦克，墙，出界，并移除子弹，坦克，墙
         */
        public void hit()
        {
            //玩家子弹和敌方子弹是否碰撞
           for(int i=playerBulletList.Count-1;i>=0;i--)
           {
               bool isHit = false; //玩家子弹是否同时和多个敌方子弹碰撞，若是，则同时消除多个敌方子弹
               for(int j=enemyBulletList.Count-1;j>=0;j--)
               {
                   if(playerBulletList[i].getRectangle().IntersectsWith(enemyBulletList[j].getRectangle()))
                   {
                       isHit = true;                     
                       enemyBulletList.RemoveAt(j);
                   }
                   if (isHit) playerBulletList.RemoveAt(i);
               }
           } 
           //玩家子弹是否打中敌方坦克
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
            //玩家子弹是否击中墙
          for(int i=playerBulletList.Count-1;i>=0;i--)
          {
              bool rmBullet = false;
              for(int j=wallList.Count-1;j>=0;j--)
              {
                  if (wallList[j] == null) continue;
                  if(playerBulletList[i].getRectangle().IntersectsWith(wallList[j].getRectangle())&&(playerBulletList[i].Getattack()>=wallList[j].getHardness())&&(wallList[j].isCanPass()==false))
                  {
                      rmBullet = true;
                      wallList.RemoveAt(j);
                  }
                  if (wallList[j] == null) continue;
                  if (playerBulletList[i].getRectangle().IntersectsWith(wallList[j].getRectangle()) && (playerBulletList[i].Getattack() < wallList[j].getHardness()) && (wallList[j].isCanPass() == false))
                  {
                      rmBullet = true;
                  }
              }
              if (rmBullet) playerBulletList.RemoveAt(i);
          }
            //敌方子弹是否击中墙
          for (int i = enemyBulletList.Count - 1; i >= 0; i--)
          {
              bool rmBullet = false;
              for (int j = wallList.Count - 1; j >= 0; j--)
              {
                  if (wallList[j] == null) continue;
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
            //玩家子弹是否出界
          for(int i=playerBulletList.Count-1;i>=0;i--)
          {
              Bullet tmp = playerBulletList[i];
              if (tmp.getX() < 0 || tmp.getX() > 780 || tmp.getY() < 0 || tmp.getY() > 780) playerBulletList.RemoveAt(i);
          }
            //敌方子弹是否出界
          for(int i=enemyBulletList.Count-1;i>=0;i--)
          {
              Bullet tmp = enemyBulletList[i];
              if (tmp.getX() < 0 || tmp.getX() > 780 || tmp.getY() < 0 || tmp.getY() > 780) enemyBulletList.RemoveAt(i);
          }
        }
        /**
         *检查玩家坦克和敌方坦克能否移动到单位速度对应的位置,并返回此距离
         */
        private int getHowMuchCanMove(Tank tank)
        {
            for(int i=0;i<=tank.getSpeed();i++)
            {
                if(tank.getDir()==Direction.W&&tank.getY() == i) return i;              
                else if(tank.getDir()==Direction.A&&tank.getX() == i) return i;             
                else if(tank.getDir()==Direction.S&&tank.getY() + i ==720) return i;        
                else if(tank.getDir()==Direction.D&&tank.getX() + i == 720) return i;            
                for(int j=0;j<enemyTankList.Count;j++)
                {
                    Tank temp=enemyTankList[j];
                    if (tank == temp) continue;
                    if (!checkMove(tank, temp)) return i - 1 >= 0 ? i - 1 : 0;
                }
                List<Tank> tempPlayerlist = playerTankTable.Values.ToList();
                for (int j = 0; j < tempPlayerlist.Count; j++)
                {
                    Tank temp = tempPlayerlist[j];
                    if (tank == temp) continue;
                    if (!checkMove(tank, temp)) return i - 1 >= 0 ? i - 1 : 0;
                }
                for(int j=0;j<wallList.Count;j++)
                {
                    if (wallList[j] == null) continue;
                    if (wallList[j].getWallType() == wallType.grass) continue;
                    if (!checkMove(tank, wallList[j])) return i - 1 >= 0 ? i - 1 : 0;
                }
            }
            return tank.getSpeed();
        }
        private bool checkMove(Tank tank,GameObject temp)
        {
            if (tank.getDir() == Direction.W && temp.getRectangle().IntersectsWith(new Rectangle(tank.getX(), tank.getY() - 1, 60, 60))) return false;
            else if (tank.getDir() == Direction.A && temp.getRectangle().IntersectsWith(new Rectangle(tank.getX() - 1, tank.getY(), 60, 60))) return false;
            else if (tank.getDir() == Direction.S && temp.getRectangle().IntersectsWith(new Rectangle(tank.getX() , tank.getY()+1, 60, 60))) return false;
            else if (tank.getDir() == Direction.D && temp.getRectangle().IntersectsWith(new Rectangle(tank.getX()+1, tank.getY(), 60, 60))) return false;
            return true;
        }
        public void fire(Tank tank)
        {
            //地图上某一时刻每一个坦克只能存在一个子弹
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
            Bullet bullet = new Bullet(x, y, 15, 15, false, tank.getIsPlayer(),6, tank.getAttack(),tank.getDir(),tank);
            if (tank.getIsPlayer()) playerBulletList.Add(bullet);
            else enemyBulletList.Add(bullet);
        }
        public void draw(Graphics g)
        {
            List<Tank> playerTanks=playerTankTable.Values.ToList();
            for (int i = 0; i < playerTankTable.Values.Count; i++) playerTanks[i].draw(g);
            for (int i = 0; i < enemyTankList.Count; i++) enemyTankList[i].draw(g);
            for (int i = 0; i < playerBulletList.Count; i++) playerBulletList[i].draw(g);
            for (int i = 0; i < enemyBulletList.Count; i++) enemyBulletList[i].draw(g);
            for (int i = 0; i < wallList.Count; i++)
            {
                if (wallList[i] == null) continue;
                wallList[i].draw(g);
            }
        }
        public void move()
        {
            for(int i=0;i<playerBulletList.Count;i++)
            {
                playerBulletList[i].move();
            }
            List<Tank> playerTanks = playerTankTable.Values.ToList();
            for (int i = 0; i < playerTankTable.Values.Count; i++) playerTanks[i].move(getHowMuchCanMove(playerTanks[i]));
        }
    }
}
