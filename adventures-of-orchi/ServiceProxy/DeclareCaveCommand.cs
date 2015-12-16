/*
Copyright 2016 Richard Bernardino

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
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
