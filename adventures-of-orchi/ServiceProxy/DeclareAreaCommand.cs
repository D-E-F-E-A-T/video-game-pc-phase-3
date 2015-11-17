using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class DeclareAreaCommand : WorldBuilderCommand
    {
        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public DeclareAreaCommand(int x, int y)
        {
            this.type = 11;
        }
    }
}
