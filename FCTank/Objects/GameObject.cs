using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FCTank.Objects
{
    public enum Direction
    {
        W, A, S, D
    }
    public abstract class GameObject
    {
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        protected bool canPass;
        public GameObject(int x, int y, int width, int height, bool canPass)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.canPass = canPass;
        }

        #region getter/setter
        public bool isCanPass()
        {
            return canPass;
        }
        public int getX()
        {
            return x;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public int getY()
        {
            return y;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public int getWidth()
        {
            return width;
        }
        public int getHeight()
        {
            return height;
        }
        public Rectangle getRectangle()
        {
            return new Rectangle(x, y, width, height);
        }
        #endregion

        public abstract void draw(Graphics g);
    }
}
