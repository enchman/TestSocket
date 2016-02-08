using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace MultiSocket
{
    public class Sender
    {
        public string Address { get; set; }
        public int Port { get; set; }

        public byte[] Frames;

        
    }
}
