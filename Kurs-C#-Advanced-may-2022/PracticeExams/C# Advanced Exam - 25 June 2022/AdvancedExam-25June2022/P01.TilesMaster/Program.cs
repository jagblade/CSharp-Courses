
int[] whiteInput = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int[] grayInput = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Stack<int> white = new Stack<int>(whiteInput); 
Queue<int> gray = new Queue<int>(grayInput);

Dictionary<string,int> locations = new Dictionary<string,int>()
{
    {"Floor",0},
    {"Countertop",0},
    {"Oven",0},
    {"Sink",0},
    {"Wall",0}

};

while (white.Any() && gray.Any())
{
    if (gray.Peek() == white.Peek())
    {
        int newTile = gray.Peek() + white.Peek();

        
            if (newTile == 40)
            {
                locations["Sink"]++;
                
            }
            else if (newTile == 50)
            {
                locations["Oven"]++;
                
            }
            else if (newTile == 60)
            {
                locations["Countertop"]++;
            }
            else if (newTile == 70)
            {
                locations["Wall"]++;
            }
            else
            {
                locations["Floor"]++;
            }
            
        white.Pop();
        gray.Dequeue();

        }

   
    else
    {
        int newWhite = white.Pop() / 2;
        white.Push(newWhite);

        int returnGray = gray.Dequeue();
        gray.Enqueue(returnGray);
    }
}

if (white.Count == 0)
{
    Console.WriteLine("White tiles left: none");
}
else
{
    Console.WriteLine($"White tiles left: " + string.Join(", ", white));
}
if (gray.Count == 0)
{
    Console.WriteLine("Grey tiles left: none");
}
else
{
    Console.WriteLine($"Grey tiles left: " + string.Join(", ", gray));
}

foreach (var loc in locations)
{
    if (loc.Value > 0)
    {
            Console.WriteLine($"{loc.Key}: {loc.Value}");
    }

}
Console.WriteLine();
