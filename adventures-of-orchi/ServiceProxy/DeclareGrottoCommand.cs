using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class DeclareGrottoCommand : BuildCommand
    {
        private int type;
        private int x;
        private int y;
        private int regionId;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int RegionId
        {
            get { return regionId; }
            set { regionId = value; }
        }

        public DeclareGrottoCommand(int regionId, int x, int y)
        {
            this.type = 13;
            this.regionId = regionId;
            this.x = x;
            this.y = y;
        }
    }
}
