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
    var (left, top) = boardHole(hole);
    Console.SetCursorPosition(left, top);
    Render(test);
    ConsoleKey key = Console.ReadKey(true).Key;
    if (key is ConsoleKey.D && hole is 1 or 4 or 2 or 5 or 3 or 6)
    {
        hole += 3;
    }
    if (key is ConsoleKey.S && hole is 1 or 2 or 4 or 5 or 7 or 8)
    {
        hole += 1;
    }
    if (key is ConsoleKey.A && hole is 9 or 6 or 8 or 5 or 7 or 4)
    {
        hole -= 3;
    }
    if (key is ConsoleKey.W && hole is 3 or 2 or 5 or 6 or 8 or 9)
    {
        hole -= 1;
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
