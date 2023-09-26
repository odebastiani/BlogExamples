
namespace Enums
{
    public record Planet
    {
        public required string Name { get; init; }

        public required PlanetCategory Category { get; init; }

        public required PlanetFeatures Features { get; init; }
    }
}
