using System;
using System.Collections.Generic;

namespace Enums
{
    public static class Program
    {
        public static void Main()
        {
            foreach (Planet planet in GetPlanets())
            {
                Console.WriteLine();
                Console.WriteLine(planet.Name);

                Console.WriteLine(" * Category: " + planet.Category);
                Console.WriteLine("   * IsDefined: " + Enum.IsDefined(planet.Category));

                Console.WriteLine(" * Features: " + planet.Features);

                Console.WriteLine("   * IsDefined: " + Enum.IsDefined(planet.Features));

                Console.WriteLine("   * HasHumans (bitwise): " + ((planet.Features & PlanetFeatures.HasHumans) == PlanetFeatures.HasHumans));
                Console.WriteLine("   * HasMoons (bitwise): " + ((planet.Features & PlanetFeatures.HasMoons) == PlanetFeatures.HasMoons));
                Console.WriteLine("   * HasRings (bitwise): " + ((planet.Features & PlanetFeatures.HasRings) == PlanetFeatures.HasRings));

                Console.WriteLine("   * HasHumans (HasFlag): " + planet.Features.HasFlag(PlanetFeatures.HasHumans));
                Console.WriteLine("   * HasMoons (HasFlag): " + planet.Features.HasFlag(PlanetFeatures.HasMoons));
                Console.WriteLine("   * HasRings (HasFlag): " + planet.Features.HasFlag(PlanetFeatures.HasRings));
            }
        }

        public static IEnumerable<Planet> GetPlanets()
        {
            yield return new Planet()
            {
                Name = "Mercury",
                Category = PlanetCategory.TerrestrialPlanet,
                Features = PlanetFeatures.None
            };

            yield return new Planet()
            {
                Name = "Venus",
                Category = PlanetCategory.TerrestrialPlanet,
                Features = PlanetFeatures.None
            };

            yield return new Planet()
            {
                Name = "Earth",
                Category = PlanetCategory.TerrestrialPlanet,
                Features = PlanetFeatures.HasHumans | PlanetFeatures.HasMoons
            };

            yield return new Planet()
            {
                Name = "Mars",
                Category = PlanetCategory.TerrestrialPlanet,
                Features = PlanetFeatures.HasMoons
            };

            yield return new Planet()
            {
                Name = "Jupiter",
                Category = PlanetCategory.GasGiant,
                Features = PlanetFeatures.HasMoons | PlanetFeatures.HasRings
            };

            yield return new Planet()
            {
                Name = "Saturn",
                Category = PlanetCategory.GasGiant,
                Features = PlanetFeatures.HasMoons | PlanetFeatures.HasRings
            };

            yield return new Planet()
            {
                Name = "Uranus",
                Category = PlanetCategory.IceGiant,
                Features = PlanetFeatures.HasMoons | PlanetFeatures.HasRings
            };

            yield return new Planet()
            {
                Name = "Neptune",
                Category = PlanetCategory.IceGiant,
                Features = PlanetFeatures.HasMoons | PlanetFeatures.HasRings
            };
        }
    }
}
