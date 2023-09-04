class Program
{
    static void deletePreviousCoordinates(int x, int y)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.SetCursorPosition(x, y);
        Console.Write(' ');
    }

    static void showSnakeCoordinates(int x, int y)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(x, y);
        Console.Write(' ');
    }

    static void showBaitCoordinates(int x, int y)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(x, y);
        Console.Write(' ');
    }

    static void Main(string[] args)
    {
        Console.Clear();

        int width = 20;
        int height = 8;

        // Vẽ hàng trên cùng
        Console.BackgroundColor = ConsoleColor.Red;

        for (int i = 0; i < width; i++)
        {
            Console.SetCursorPosition(i, 0);
            Console.Write('#');
        }

        // Vẽ hàng dưới cùng
        Console.BackgroundColor = ConsoleColor.Red;

        for (int i = 1; i < width; i++)
        {
            Console.SetCursorPosition(i, height);
            Console.Write('#');
        }

        // Vẽ hàng bên phải
        Console.BackgroundColor = ConsoleColor.Red;

        for (int i = 0; i < height + 1; i++)
        {
            Console.SetCursorPosition(width - 1, i);
            Console.Write('#');
        }

        // Vẽ hàng bên trái
        Console.BackgroundColor = ConsoleColor.Red;

        for (int i = 1; i < height + 1; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write('#');
        }

        Random rnd = new Random();

        int xSnake = rnd.Next(1, width - 1);
        int ySnake = rnd.Next(1, height - 1);

        Console.BackgroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(xSnake, ySnake);
        Console.Write(' ');

        int xBait = rnd.Next(1, width - 1);
        int yBait = rnd.Next(1, height - 1);

        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(xBait, yBait);
        Console.Write(' ');

        while (xSnake >= 1 && xSnake <= width-2 && ySnake>=1 && ySnake<=height-2)
        {
            var key=Console.ReadKey().Key;

            if (key == ConsoleKey.UpArrow){
                deletePreviousCoordinates(xSnake,ySnake);
                ySnake--;
                showSnakeCoordinates(xSnake,ySnake);
            }
            if (key == ConsoleKey.DownArrow){
                deletePreviousCoordinates(xSnake,ySnake);
                ySnake++;
                showSnakeCoordinates(xSnake,ySnake);
            }
            if (key == ConsoleKey.LeftArrow){
                deletePreviousCoordinates(xSnake,ySnake);
                xSnake--;
                showSnakeCoordinates(xSnake,ySnake);
            }
            if (key == ConsoleKey.RightArrow){
                deletePreviousCoordinates(xSnake,ySnake);
                xSnake++;
                showSnakeCoordinates(xSnake,ySnake);
            }

            if (xSnake == xBait && ySnake == yBait)
            {
                deletePreviousCoordinates(xBait,yBait);
                showSnakeCoordinates(xSnake,ySnake);
                xBait = rnd.Next(1, width - 1);
                yBait = rnd.Next(1, height - 1);
                showBaitCoordinates(xBait,yBait);
            }
        }

        Console.SetCursorPosition(0,height+1);
        Console.WriteLine("Game Over");

        Console.ResetColor();
    }
}
