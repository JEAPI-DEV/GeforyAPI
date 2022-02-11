using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GeforyAPI.Cloudsystem
{

    public class NodeManager
    {
        
        private List<string> nodes = new List<string> { };

        private void startnodes(string host, int port)
        {
            int i = 0;
            for (i++; i >= nodes.Count;)
            {
                Node.StartClient(host, port, nodes[i]);
            }

        }

        private void addnode(string node)
        {
            nodes.Add(node);
        }

        private void removenode(string node)
        {
            nodes.Remove(node);
        }
    }

    public class MasterManager
    {
        Master mst = new Master();
        

    }
}
