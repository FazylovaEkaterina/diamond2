using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Painter
{
    

    public Painter() { }
    public char ch;
    public bool Read(string str)
    {
        char s;
        Console.Write("Enter the letter: ");


        try
        {
            s = Convert.ToChar(str);

            if (((int)s < (int)('A')) | ((int)s > (int)('Z')))
            {
               // Console.WriteLine("You entered an incorrect character!");

                return false;

            }
        }
        catch (System.FormatException e)
        {
           // Console.WriteLine("You entered a string, not a character!" + e.Message);
            return false;


        }
        this.ch = s;
        return true;
    }
    public void Draw()
    {
        char c;
        int j, i, n, d, f, z, p;



        c = 'A';
        n = (int)this.ch - (int)c;
        j = n;
        p = n;
        n = n + n;

        for (i = 0; i <= n; i++) //strat drawing a diamond 
        {
            for (d = 1; d <= j; d++) // draw spaces 
            {
                Console.Write("_");
            }

            Console.Write(c);
            if (c != 'A') // draw spaces between letters 
            {
                z = ((int)c - (int)'A') * 2 - 1;
                for (f = 1; f <= z; f++)
                {
                    Console.Write("_");
                }
                Console.Write(c);
            }
            for (d = 1; d <= j; d++) // draw spaces 
            {
                Console.Write("_");
            }
            Console.WriteLine();

            if (i < p) // here we check that we draw first half of diamond 
            { // and need to draw a second half of diamond 
                j--;
                c = (char)((int)c + 1);
            }
            else
            {
                j++;
                c = (char)((int)c - 1);
            }
        }
        Console.ReadKey();

    }
}

namespace DIAMOND
{
    class Program
    {
        static void Main()
        {

            Painter letter = new Painter();
            if (letter.Read(Console.ReadLine()))
                letter.Draw();
            


        }
    }
}