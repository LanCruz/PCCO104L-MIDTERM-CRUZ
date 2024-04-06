using System;

class Program
{
    static void Main(string[] args)
    {
        int fanspd;
        char oscillate_option;
        int fanpower = 10;

      do
      {
          Console.WriteLine("Enter fan speed (1, 2, or 3):");
          if (!int.TryParse(Console.ReadLine(), out fanspd) || fanspd < 1 || fanspd > 3)
          {
              Console.WriteLine("INVALID");
            continue;
          }
      } while (fanspd < 1 || fanspd > 3);

      do
      {
          Console.WriteLine("Do you want to oscillate? (Y/N):");
          if (!char.TryParse(Console.ReadLine(), out oscillate_option) || (oscillate_option != 'Y' && oscillate_option != 'N'))
          {
              Console.WriteLine("INVALID");
            continue;
          }
      } while (oscillate_option != 'Y' && oscillate_option != 'N');


        int fanpoweroutput = fanpower * fanspd;


        if (oscillate_option == 'Y')
        {
            oscillateoutput(fanpower, fanspd);
        }
        else
        {
            steadyoutput(fanpoweroutput);
        }
    }

    static void oscillateoutput(int basefan_power, int fan_speed)
    {
       for (int i = 1; i <= basefan_power; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    for (int x = 1; x <= fan_speed; x++)
                    {
                        Console.Write("~");
                    }
                }
        Console.WriteLine();
            }
         for (int i = basefan_power; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    for (int x = 1; x <= fan_speed; x++)
                    {
                        Console.Write("~");
                    }
                }
        Console.WriteLine();
            }
    }

    static void steadyoutput(int fanpoweroutput)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(new string('~', fanpoweroutput));
        }
    }
}