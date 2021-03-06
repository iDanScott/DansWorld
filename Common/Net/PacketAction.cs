﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DansWorld.Common.Net
{
    /// <summary>
    /// actions that can be done by the network packet
    /// </summary>
    public enum PacketAction : byte
    {
        REQUEST = 1, 
        ACCEPT = 2, 
        REJECT = 3, 
        MOVE = 4, 
        STOP = 5, 
        WELCOME = 6,
        LOGOUT = 7,
        PING = 8,
        PONG = 9,
        TALK = 10,
        ATTACK = 11,
        CREATE = 12, 
        DELETE = 13,
        CREATED = 14,
        ALREADY_EXISTS = 15,
        TAKE_DAMAGE = 16
    }
}
