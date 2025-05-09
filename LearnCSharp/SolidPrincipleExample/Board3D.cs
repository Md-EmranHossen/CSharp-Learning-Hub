using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleExample
{
    public class Board3D : Board
    {
        public int[,,] grid3D;

        public void SetItem(int x, int y, int z, int value)
        {
            grid3D[x, y, z] = value;
        }

        public void Remove(int x, int y, int z)
        {
            grid3D[x, y, z] = 0;
        }
    }
}
