using System;

public class ProcessFile
{
    public static void Main()
    {
        DateTime dt = new DateTime(2024, 03, 10, 22, 8, 45);
        Console.WriteLine(dt.ElapsedTime());
    }
}