using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class DeclareLandCommand : BuildCommand
    {
        private int type;
        private int x;
        private int y;
        private string name;

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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DeclareLandCommand(String name, int x, int y)
        {
            this.type = 10;
            this.name = name;
            this.x = x;
            this.y = y;
        }
    }
}
