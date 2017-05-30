using System;

class FiveDifferentNumbers
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if ((b - a) < 5)
        {
            Console.WriteLine("No");
        }
        else
        {
            for (int i = a; i <= b; i++)
            {
                for (int c = a; c <= b; c++)
                {
                    for (int d = a; d <= b; d++)
                    {
                        for (int f = a; f <= b; f++)
                        {
                            for (int g = a; g <= b; g++)
                            {
                                if (c <= i || d <= c || f <= d || g <= f)
                                {
                                    continue;
                                }

                                else
                                {
                                    Console.Write(i + " ");
                                    Console.Write(c + " ");
                                    Console.Write(d + " ");
                                    Console.Write(f + " ");
                                    Console.WriteLine(g);
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}