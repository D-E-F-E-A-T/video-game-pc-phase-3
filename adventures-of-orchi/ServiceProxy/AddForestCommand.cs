using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class AddForestCommand : BuildCommand
    {
        private int type;
        private int layerId;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public int LayerId
        {
            get { return layerId; }
            set { layerId = value; }
        }


        public AddForestCommand(int layerId)
        {
            this.type = 1;
            this.layerId = layerId;
        }
    }
}