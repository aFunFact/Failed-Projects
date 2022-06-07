string Board = @"
════════════════
║    ║    ║    ║
║    ║    ║    ║
║    ║    ║    ║
╬════║════║════╬
║    ║    ║    ║
║    ║    ║    ║
║    ║    ║    ║
╬════║════║════╬
║    ║    ║    ║
║    ║    ║    ║
║    ║    ║    ║
════════════════";
string circlemove = @"
 __ 
/  \
\__/";
string xmove =@""
 "    " + "\n" +
@" \/ " + "\n" +
@" /\ ";
string empty =
"    " + "\n" +
"    ";
Console.WriteLine(Board);
Random Random = new();

while (true)
{

    int moveright = 1;
    var (left, top) = location(moveright);
    Console.SetCursorPosition(left, top);
    Render(xmove);
    while (true)
    {
        ConsoleKey key = Console.ReadKey(true).Key;
        if (key is ConsoleKey.D)
        {
            if (moveright >= 10)
            {
                moveright = 7;
            }
            
            Console.SetCursorPosition(left, top);
            Render(circlemove);
            moveright +=3;
            Console.WriteLine(moveright);
        }
    }
    
    Render(xmove);
    Console.ReadKey(true);
}
(int left, int top) location(int hole) =>
hole switch
{
    1 => (1, 1),
    2 => (1, 5),
    3 => (1, 9),
    4 => (6, 1),
    5 => (6, 5),
    6 => (6, 9),
    7 => (11, 1),
    8 => (11, 5),
    9 => (11, 9),
    _ => throw new NotImplementedException(), 
};

void Render(string @string) {
    int x = Console.CursorLeft;
    int y = Console.CursorTop;
    foreach (char c in @string)
    {
        if (c == '\n')
        {
            
            Console.SetCursorPosition(x, ++y);
            
        }
        else
        {
            Console.Write(c);
        }
        
    }
}
