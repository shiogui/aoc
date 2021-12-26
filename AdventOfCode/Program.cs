var inputs = File.ReadAllLines("Input.txt");

if (inputs == null || !inputs.Any())
{
    Console.WriteLine("Nothing Here!");
    return;
}

int count = 0;
int previous = 0;

for (int i = 0; i < inputs.Length; i++)
{
    int v = int.Parse(inputs[i]);
    if (previous > 0 && v > previous)
        count++;
    previous = v;
}

Console.WriteLine(count);
Console.WriteLine("Finished");
Console.ReadKey();