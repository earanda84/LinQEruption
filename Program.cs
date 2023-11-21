List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
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
// 1.-Use LINQ to find the first eruption that is in Chile and print the result.
IEnumerable<Eruption> firstChileanEruption = eruptions.Where(p => p.Location == "Chile").Take(1);

PrintEach(firstChileanEruption, "Primera Erupcion Chilena");

// 2.-Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."

IEnumerable<Eruption> firstHawaiianEruption = eruptions.Where(l => l.Location == "Hawaiian Is");


PrintEach(firstHawaiianEruption, "Erupción Hawaiian Is");

// 3.-Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.

IEnumerable<Eruption> erutpionBeforeNewZealand = eruptions.Where(c => c.Location == "New Zealand" && c.Year > 1900);

PrintEach(erutpionBeforeNewZealand, "Erupción Anterior al año 1900 en New Zealand");

// 4.-Find all eruptions where the volcano's elevation is over 2000m and print them.

IEnumerable<Eruption> eruptionsOverTwoThousand = eruptions.Where(elev => elev.ElevationInMeters > 2000);


PrintEach(eruptionsOverTwoThousand, "Erupciones en altura mayor a 200o mts");

// 5.-Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.

IEnumerable<Eruption> volcanoStartWithL = eruptions.Where(v => v.Volcano.StartsWith('L'));

PrintEach(volcanoStartWithL, "Erupciones en Volcanes que empiezan con L");

// 6.-Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
IEnumerable<Eruption> highestElevation = eruptions.OrderByDescending(c => c.ElevationInMeters).Take(1);

PrintEach(highestElevation, "Mayor elevación");

// 7.- Use the highest elevation variable to find a print the name of the Volcano with that elevation.
// string volcanoNameHighestElevation = "";
IEnumerable<string> volcanoNameHighestElevation = highestElevation.Select(e => e.Volcano);

PrintEach(volcanoNameHighestElevation,"Nombre volcan mayor elevacion");

// 8.-Print all Volcano names alphabetically.
IEnumerable<string> volcanoNames = eruptions.OrderBy(n => n.Volcano).Select(e => e.Volcano);

PrintEach(volcanoNames, "Nombre de volcanes ordenados por nombre");

// 9.-Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.

IEnumerable<Eruption> eruptionAfterOneThousandYear = eruptions.Where(e => e.Year > 1000).OrderBy(y => y.Volcano);

PrintEach(eruptionAfterOneThousandYear, "Erupciones ocurridas después del año 1000 después de Cristo 1");

// 10.- BONUS: Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.

IEnumerable<string> eruptionAfterOneThousandYear2 = eruptions.Where(e => e.Year > 1000).OrderBy(n => n.Volcano).Select(n => n.Volcano);


PrintEach(eruptionAfterOneThousandYear2, "Erupciones ocurridas después del año 1000 después de Cristo 2, solo nombres");


// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{

    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}