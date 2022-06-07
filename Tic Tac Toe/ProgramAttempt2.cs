string test =
"XX" + "\n" +
"XX";
string empty =
"  " + "\n" +
"  ";

int newHole = 0;

int hole = 1;
while (true) 
{
    if (hole >= 10)
    {
        hole = 3;
    }
    else if (hole <= 0)
    {
        hole = 1;
    }
    var (left, top) = boardHole(hole);
    Console.SetCursorPosition(left, top);
    Render(test);
    bool anyKey = false;
    while (!anyKey) {
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.D: hole+=3; if (hole >= 7) hole = 7; anyKey = true; break;
            case ConsoleKey.A: hole-=3; anyKey = true; break;
            case ConsoleKey.S: hole += 1; anyKey = true; break;
        }
    }
    Console.SetCursorPosition(left, top);
    Render(empty);
}
(int left, int top) boardHole(int hole) =>
hole switch
{
    1 => (5, 5),
    2 => (5, 10),
    3 => (5, 15),
    4 => (10, 5),
    5 => (10, 10),
    6 => (10, 15),
    7 => (15, 5),
    8 => (15, 10),
    9 => (15, 15),
};
void Render(string @string)
{
    int x = Console.CursorLeft;
    int y = Console.CursorTop;
    foreach (char c in @string)
    {
        if (c is '\n')
        {
            Console.SetCursorPosition(x, ++y);
        }
        else
        {
            Console.Write(c);
        }
    }
}
