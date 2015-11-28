using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class DeclareCaveCommand : BuildCommand
    {
        private int type;
        private int x;
        private int y;
        private int regionId;
        private int red;
        private int green;
        private int blue;

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

        public int Red
        {
            get { return red; }
            set { red = value; }
        }

        public int Green
        {
            get { return green; }
            set { green = value; }
        }

        public int Blue
        {
            get { return blue; }
            set { blue = value; }
        }

        public DeclareCaveCommand(int regionId, int x, int y, int red, int green, int blue)
        {
            this.type = 8;
            this.regionId = regionId;
            this.x = x;
            this.y = y;
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
    }
}
