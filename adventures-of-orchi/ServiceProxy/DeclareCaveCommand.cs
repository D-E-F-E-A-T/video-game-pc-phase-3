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
        private int column;
        private int row;
        private int regionId;
        private int red;
        private int green;
        private int blue;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Column
        {
            get { return column; }
            set { column = value; }
        }

        public int Row
        {
            get { return row; }
            set { row = value; }
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

        public DeclareCaveCommand(int regionId, int nColumn, int nRow, int red, int green, int blue)
        {
            this.type = 8;
            this.regionId = regionId;
            this.column = nColumn;
            this.row = nRow;
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
    }
}
