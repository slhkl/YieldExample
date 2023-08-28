using App;
using System.Diagnostics;

IEnumerable<string> cars = null;

Stopwatch sw = Stopwatch.StartNew();
cars = Cars.GetCars();
foreach (var car in cars)
    Console.Write(car + "\n");
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);

sw.Restart();
cars = Cars.GetCarsFromList();
foreach (var car in cars)
    Console.Write(car + "\n");
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);

sw.Restart();
cars = Cars.GetCarsFromYieldReturn();
foreach (var car in cars)
    Console.Write(car + "\n");
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);