// See https://aka.ms/new-console-template for more information
List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
 
// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        // Console.WriteLine(item.ToString());
    }
}

// List<Eruption> catCat = eruptions.Where(c => c.Year < 1910).ToList();
// catCat.ForEach(Console.WriteLine);




Eruption? Chile = eruptions.Where(e => e.Location == "Chile").OrderBy(e => e.Year).First();
Console.WriteLine(Chile);




Eruption? Hawaii = eruptions.FirstOrDefault(e => e.Location.Contains("Hawaiian Is"));
if(Hawaii == null)
{
    Console.WriteLine("No Hawaiian Is Eruption found.");
} else
{
    Console.WriteLine(Hawaii);
}



Eruption? Green = eruptions.FirstOrDefault(e => e.Location.Contains("Greenland"));
if(Green == null)
{
    Console.WriteLine("No Greenland eruption found");
} else
{
    Console.WriteLine(Green);
}



List<Eruption> Height = eruptions.Where(e => e.ElevationInMeters > 2000).ToList();
Height.ForEach(Console.WriteLine);




List<Eruption> Start = eruptions.Where(e => e.Volcano.Contains("L")).ToList();
Start.ForEach(Console.WriteLine);
Console.WriteLine(Start.Count());



List<Eruption> Strat = eruptions.Where(e => e.Type == "Stratovolcano").Take(3).ToList();
Strat.ForEach(Console.WriteLine);




bool Any = eruptions.Any(e => e.Year == 2000);
Console.WriteLine(Any);




int Sum = eruptions.Sum(e => e.ElevationInMeters);
Console.WriteLine(Sum);




Eruption? First = eruptions.FirstOrDefault(e => e.Location.Contains("New Zealand") && e.Year > 1900);
Console.WriteLine(First);




int Big = eruptions.Max(e => e.ElevationInMeters);
Console.WriteLine(Big);




List<String> Alphabetical = eruptions.OrderBy(e => e.Volcano).Select(e => e.Volcano).ToList();
Alphabetical.ForEach(Console.WriteLine);




List<String> AllEruption = eruptions.Where(e => e.Year <= 1000).OrderBy(e => e.Volcano).Select(e => e.Volcano).ToList();
AllEruption.ForEach(Console.WriteLine);




List<Eruption> AllEruptionList = eruptions.Where(e => e.Year <= 1000).OrderBy(e => e.Volcano).ToList();
AllEruptionList.ForEach(Console.WriteLine);




String? Biggest = eruptions.Where(e => e.ElevationInMeters == Big).Select(e => e.Volcano.ToString()).FirstOrDefault();
Console.WriteLine(Biggest);