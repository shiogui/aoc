var inputs = File.ReadAllLines("Input.txt");

if (inputs == null || !inputs.Any())
{
    Console.WriteLine("Nothing Here!");
    return;
}

var chunks = new int[inputs.Length];

for (int i = 0; i < chunks.Length; i++)
{
    if (i + 1 >= inputs.Length || i + 2 >= inputs.Length)
    {
        break;
    }

    chunks[i] = int.Parse(inputs[i]) + int.Parse(inputs[i + 1]) + int.Parse(inputs[i + 2]);
}

int count = 0;
int previous = 0;

for (int i = 0; i < chunks.Length; i++)
{
    int v = chunks[i];

    if (v == 0)
    {
        break;
    }

    if (previous > 0 && v > previous)
        count++;

    previous = v;
}

Console.WriteLine(count);
Console.WriteLine("Finished");
Console.ReadKey();