using Ejemplo02;
using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();

var repository = new StringRepository(100000000, 10);
var processor = new StringProcessor(repository);
var filterString = processor.FilterString();

foreach (var filter in filterString) Console.WriteLine(filter);

stopwatch.Stop();
Console.WriteLine($"Tiempo trancurrido {stopwatch.ElapsedMilliseconds} ms");
