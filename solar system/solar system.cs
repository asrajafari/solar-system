
Console.WriteLine("Enter your Planet");
//int yourPlanet = int.Parse(Console.ReadLine());

long Earth = 149000000l;
long Jupiter = 778000000l;
long Saturn = 1428000000l;
long Uranuse = 2873000000l;
long Venus = 108000000l;
long Mercury = 58000000l;
long Neptune = 5920000000l;

{
    Console.WriteLine("Enter your Planet");
    Console.WriteLine("Earth:149000000");
    Console.WriteLine("Jupiter:778000000");
    Console.WriteLine("Saturn:1428000000");
    Console.WriteLine("Uranuse:2873000000");
    Console.WriteLine("Venus:108000000");
    Console.WriteLine("Mercury:58000000");
    Console.WriteLine("Neptune:5920000000");


    Console.WriteLine("Enter your planet (Earth, Jupiter, Saturn, Uranus, Venus, Mercury, Neptune):");

    if (Console.ReadLine() != "Earth" && Console.ReadLine() != "Jupiter" && Console.ReadLine() != "Saturn" && Console.ReadLine() != "Uranus" &&
        Console.ReadLine() != "Venus" && Console.ReadLine() != "Mercury" && Console.ReadLine() != "Neptune")
    {
        Console.WriteLine("You made a wrong choice.");
    }
    else
    {
        Console.WriteLine("You selected: " + Console.ReadLine());
    }
    Console.WriteLine("Enter your planet (Earth, Jupiter, Saturn, Uranus, Venus, Mercury, Neptune):");
    string yourPlanet = Console.ReadLine();

    long distanceFromSun = 0;

    {
        switch (yourPlanet)
        {
            case "Earth":
                distanceFromSun = 149000000L;
                break;
            case "Jupiter":
                distanceFromSun = 778000000L;
                break;
            case "Saturn":
                distanceFromSun = 1428000000L;
                break;
            case "Uranus":
                distanceFromSun = 2873000000L;
                break;
            case "Venus":
                distanceFromSun = 108000000L;
                break;
            case "Mercury":
                distanceFromSun = 58000000L;
                break;
            case "Neptune":
                distanceFromSun = 4500000000L;
                break;
            default:
                Console.WriteLine("Invalid planet name.");
                return;
        }

        if (distanceFromSun > 0)
        {
            Console.WriteLine("The distance of " + yourPlanet + " from the sun is " + distanceFromSun + " km.");
        }
               // Console.WriteLine("You made a wrong choice.");
                //return;  
        }

    }

