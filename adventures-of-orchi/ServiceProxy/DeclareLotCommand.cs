using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class DeclareLotCommand : BuildCommand
    {
        private int type;
        private int x;
        private int y;
        private int id;

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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DeclareLotCommand(int id, int x, int y)
        {
            this.type = 11;
            this.id = id;
            this.x = x;
            this.y = y;
        }
    }
}
