using System.IO;

int packetSize = 14;
string input = File.ReadAllText("6.txt");
int index = input
    .Select((_, i) => i)
    .Where(i => i + packetSize < input.Length)
    .First(i => input[i..(i + packetSize)].Distinct().Count() == packetSize);
Console.WriteLine(index + packetSize);
