using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class DeclareWorldCommand : BuildCommand
    {
        private int type;
        private String name;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public DeclareWorldCommand(String name)
        {
            this.type = 12;
            this.name = name;
        }
    }
}
