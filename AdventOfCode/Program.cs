var inputs = File.ReadAllLines("Input.txt");

if (inputs == null || !inputs.Any())
{
    Console.WriteLine("Nothing Here!");
    return;
}

int hp = 0;
int depth = 0;
int aim = 0;

for (int i = 0; i < inputs.Length; i++)
{
	string[] line = inputs[i].Split(' ');
	int v = int.Parse(line[1]);
	switch (line[0])
	{
		case "forward":
			hp += v;
			depth += aim * v;
			break;
		case "up":
			aim -= v;
			break;
		case "down":
			aim += v;
			break;
	}
}

Console.WriteLine(hp * depth);
Console.WriteLine("Finished");
Console.ReadKey();
