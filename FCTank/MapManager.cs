using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FCTank.Objects;
using System.Drawing;

namespace FCTank
{
    public class MapManager
    {
        private List<Wall> wallList = new List<Wall>(26 * 26);
        public List<Wall> WallList
        {
            get
            {
                return wallList;
            }
        }
        private bool isMouseDown;
        public MapManager()
        {
            for (int i = 0; i < 26 * 26; i++) wallList.Add(null);
            wallList[11 + 23 * 26] = Factory.createWall(wallType.wall, 11, 23);
            wallList[11 + 24 * 26] = Factory.createWall(wallType.wall, 11, 24);
            wallList[11 + 25 * 26] = Factory.createWall(wallType.wall, 11, 25);
            wallList[12 + 23 * 26] = Factory.createWall(wallType.wall, 12, 23);
            wallList[13 + 23 * 26] = Factory.createWall(wallType.wall, 13, 23);
            wallList[14 + 23 * 26] = Factory.createWall(wallType.wall, 14, 23);
            wallList[14 + 24 * 26] = Factory.createWall(wallType.wall, 14, 24);
            wallList[14 + 25 * 26] = Factory.createWall(wallType.wall, 14, 25);
            wallList[12 + 24 * 26] = Factory.createWall(wallType.home, 12, 24);
        }
        public void MouseDown(MouseEventArgs e,wallType type)
        {
            isMouseDown = true;
            addToList(e, type);
        }
        public void MouseMove(MouseEventArgs e, wallType type)
        {
            if(isMouseDown)
            {
                addToList(e, type);
            }
        }
        public void MouseUp(MouseEventArgs e, wallType type)
        {
            isMouseDown = false;
            addToList(e, type);
        }
        public void draw(Graphics g)
        {
            for (int i = 0; i < wallList.Count; i++) 
                if(wallList[i]!=null)
                wallList[i].draw(g);
        }
        private void transCoor(out int x,out int y,int mx,int my)
        {
            x = mx / 30;
            y = my / 30;
        }
        private void addToList(MouseEventArgs e, wallType type)
        {
            int x, y;
            transCoor(out x, out y, e.X, e.Y);
            wallList[x + y * 26] = Factory.createWall(type, x, y);
        }
    }
}
