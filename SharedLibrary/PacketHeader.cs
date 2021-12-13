using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public enum PacketHeader
    {
        NoAction = 999,
        LoginRequest = 100,
        LogoutRequest = 101,
        LoginResponsePositive = 102,
        LoginResponseNegative = 103,
        LogoutResponse = 104,
        SendClientCredentials = 105,
        SendClientDetails = 106
    }
}
