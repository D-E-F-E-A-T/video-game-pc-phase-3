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
    public sealed class DeclareDungeonCommand : BuildCommand
    {
        private int type;
        private int columns;
        private int rows;
        private int id;
        private int entryX;
        private int entryY;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Columns
        {
            get { return columns; }
            set { columns = value; }
        }

        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
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

        

        public DeclareDungeonCommand(int id, int columns, int rows, int entryX, int entryY)
        {
            this.type = 9;
            this.id = id;
            this.columns = columns;
            this.rows = rows;
            this.entryX = entryX;
            this.entryY = entryY;

        }
    }
}
