using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedLibrary
{
    public class Parser
    {
        static public List<string> DecodeMessage(string encodedString, char delimiter = (char)0x1c)
        {
            /*1c  FS  ␜  ^\  File Separator
             *1d  GS  ␝  ^]  Group Separator
             *1e  RS  ␞  ^^  Record Separator
             *1f  US  ␟  ^_  Unit Separator
             */
            List<string> decodedMessage = new List<string>(encodedString.Split(delimiter));

            return decodedMessage;
        }
        static public string EncodeMessage(List<string> listOfStrings, char delimiter)
        {
            string returnString = "";
            for (int i = 0; i < listOfStrings.Count(); i++)
            {
                returnString += listOfStrings[i];
                if (i != listOfStrings.Count() - 1)
                    returnString += delimiter;
            }
            return returnString;
        }
        static public Pair<PacketHeader, string> SplitPacket(string packetData, char delimiter = (char)0x1c)
        {
            Pair<PacketHeader, string> splitPacket = new Pair<PacketHeader, string>(PacketHeader.NoAction, "");

            string str = packetData.Split(delimiter)[0];
            splitPacket.Item1 = (PacketHeader)Convert.ToInt32(str);
            splitPacket.Item2 = packetData.Substring(4);
            return splitPacket;
        }

    }
}
