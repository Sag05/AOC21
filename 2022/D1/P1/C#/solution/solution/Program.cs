
string[] input = File.ReadAllLines("input");
List<int> elves = new List<int>();
List<int> output = new List<int>();

elves.Add(0);

for (int i = 0; i < input.Length; i++)
{
    if (!String.IsNullOrEmpty(input[i])) elves.Add(i);
    else output.Add(int.Parse(input[i]));
}

input.Select()










/*for (int i = 0; i < input.Length; i++)
{
    if (input[i] == "")
    {
        elves.Add(i);
    }
}
elves.Add(input.Length);

for (int i = 0; i < elves.Count; i++)
{
    output.Add(i);
    for (int j = 0; j < elves[i+1] - elves[i]; j++)
    {
        Console.WriteLine("i=" + i + ", j=" + j +", total=" + (elves[i]+j) + ", Number=" + input[elves[i] + j+i]);

        output[i] += int.Parse(input[elves[i]+j+i]);
    }
}
foreach (int item in output)
{ 
    Console.WriteLine(item);
}*/

//int elves = 1;
/*foreach (string line in input)
{
    //Console.WriteLine(line);
    if(line == "")
    {
        elves++;
    }
}
Console.WriteLine("\n" + elves);

Console.ReadLine();
*/