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
        private char delimiter;
        public Packet()
        {
            // (char)0x1c - unit delimiter
            delimiter = (char)0x1c;
        }
        public void SetHeader(PacketHeader newHeader, char newDelimiter = (char)0x1c)
        {
            packetHeader = newHeader;
            delimiter = newDelimiter;
        }
        public void SetData(string newData)
        {
            // Non-encoding
            data = newData;
        }
        public void SetData(List<string> newData)
        {
            // Encoding
            data = Parser.EncodeMessage(newData, delimiter); 
        }
        public PacketHeader GetHeader()
        {
            return packetHeader;
        }
        public override string ToString()
        {
            return ((int)packetHeader).ToString() + delimiter + data;
        }
        static public Packet ReconstructPacket(string newData, char newDelimiter = (char)0x1c)
        {
            Packet reconstructedPacket = new Packet();
            Pair<PacketHeader, string> packetData = Parser.SplitPacket(newData, newDelimiter);
            reconstructedPacket.SetHeader(packetData.Item1);
            reconstructedPacket.SetData(packetData.Item2);
            return reconstructedPacket;
        }
        public List<string> GetDecodedMessage()
        {
            List<string> decodedMessageList = Parser.DecodeMessage(data);
            return decodedMessageList;
        }
        public string GetUnifiedDecodedMessage()
        {
            string decodedMessage;
            decodedMessage = data.Replace(delimiter, ' ');
            return decodedMessage;
        }
    }
}
