using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class DeclareDungeonCommand : BuildCommand
    {
        private int type;
        private int x;
        private int y;
        private int id;
        private int entryX;
        private int entryY;
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

        public int Id
        {
            get { return id; }
            set { id = value; }
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

        public int EntryX
        {
            get { return entryX; }
            set { entryX = value; }
        }

        public int EntryY
        {
            get { return entryY; }
            set { entryY = value; }
        }

        

        public DeclareDungeonCommand(int id, int x, int y, int entryX, int entryY, int red, int green, int blue)
        {
            this.type = 9;
            this.id = id;
            this.x = x;
            this.y = y;
            this.entryX = entryX;
            this.entryY = entryY;
            this.red = red;
            this.blue = blue;
            this.green = green;
            
        }
    }
}
