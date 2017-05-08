using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FCTank.Objects;

namespace FCTank
{
    [Serializable]
    public class Maps
    {
        private  List<List<Wall>> walls=new List<List<Wall>>();
        public  List<Wall> getWallList(int index)
        {
            List<Wall> cloneList = new List<Wall>(walls[index].Count);
            for(int i=0;i<walls[index].Count;i++)
            {
                if (walls[index][i] == null) cloneList.Add(null);
                else  cloneList.Add(walls[index][i].Clone() as Wall);
            }
            return cloneList;
        }
        public  void addWallList(List<Wall> wallList)
        {
            walls.Add(wallList);
        }
        public int Count
        {
            get
            {
                return walls.Count;
            }
        }
    }
}
