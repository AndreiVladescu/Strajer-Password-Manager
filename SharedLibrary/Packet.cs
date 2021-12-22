using System.Collections.Generic;

namespace SharedLibrary
{
    public class Packet
    {
        private string data;
        private PacketHeader packetHeader;
        private char delimiter;
        public Packet(char newDelimiter = (char)0x1c)
        {
            // (char)0x1c - unit delimiter
            delimiter = newDelimiter;
        }
        ///<summary>
        ///This constructor needs a directly encoded data field or just 1 unencoded string
        ///</summary>
        public Packet(PacketHeader newHeader, string newData, char newDelimiter = (char)0x1c)
        {
            delimiter = newDelimiter;
            packetHeader = newHeader;
            data = newData;
        }
        ///<summary>
        ///This constructor requires a list of strings that will be encoded afterwards
        ///</summary>
        public Packet(PacketHeader newHeader, List<string> newData, char newDelimiter = (char)0x1c)
        {
            delimiter = newDelimiter;
            packetHeader = newHeader;
            data = Parser.EncodeMessage(newData, delimiter);
        }
        ///<summary>
        ///This constructor requires a ListClass that will be encoded afterwards
        ///</summary>
        public Packet(PacketHeader newHeader, ListClass newData, char newDelimiter = (char)0x1c)
        {
            delimiter = newDelimiter;
            packetHeader = newHeader;
            data = Parser.EncodeMessage(newData.GetList(), delimiter);
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
