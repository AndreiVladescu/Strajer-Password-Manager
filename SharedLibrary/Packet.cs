using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class Packet
    {
        private string data;
        private PacketHeader packetHeader;

        public void SetHeader(PacketHeader newHeader)
        {
            packetHeader = newHeader;
        }
        public void SetData(string newData)
        {
            data = newData;
        }
    }
}
