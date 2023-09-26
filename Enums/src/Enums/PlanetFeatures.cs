using System;

namespace Enums
{
    [Flags]
    public enum PlanetFeatures
    {
        None = 0b0000_0000, // 0
        HasHumans = 0b0000_0001, // 1
        HasMoons = 0b0000_0010, // 2
        HasRings = 0b0000_0100, // 4
    }
}
