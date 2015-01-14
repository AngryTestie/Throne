﻿using System;
using System.Drawing;
using Throne.Framework.Network.Transmission;

namespace Throne.World.Network.Messages
{
    public sealed class WeatherInformation : WorldPacket
    {
        public enum WeatherType : uint
        {
            None = 0,
            Fine,
            Rainy,
            Snowy,
            Sands,
            Leaf,
            Bamboo,
            Flower,
            Flying,
            Dandelion,
            Worm,
            Cloudy,
            All
        }

        public WeatherInformation(WeatherType type, Int32 direction, Int32 intensity, Color color)
            : base(PacketTypes.WeatherInformation, 76)
        {
            WriteUInt((UInt32)type); // 1, snow 3
            WriteInt(intensity); // , 250
            WriteInt(direction); // 14, 30
            WriteInt(color.ToArgb()); // , 1
        }
    }
}
