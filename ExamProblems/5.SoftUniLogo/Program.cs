using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SoftUniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var widthRows = 4 * n - 2;
            var heightCols = 12 * n - 5;

            var hashtags = 1;

            for (int row = 1; row <= 2 * n; row++)
            {
                var dots = (heightCols - hashtags) / 2;
                string d = new string('.', dots);
                string h = new string('#', hashtags);
                hashtags += 6;
                Console.WriteLine("{0}{1}{0}", d, h);
            }

            var startDots = 2;
            var endDots = 3;
            var hashtagsMiddle = heightCols - startDots - endDots - 1;

            for (int row = 1; row <= widthRows - 3 * n; row++)
            {
                string dotsStart = new string('.', startDots);
                string dotsEnd = new string('.', endDots);
                string middle = new string('#', hashtagsMiddle);
                Console.Write("|");
                Console.WriteLine("{0}{1}{2}", dotsStart, middle, dotsEnd);
                startDots += 3;
                endDots += 3;
                hashtagsMiddle -= 6;
            }

            var lowerStartDots = n * 3 - 4;
            var lowerEndDots = n * 3 - 3;
            var lowerHashtags = heightCols - lowerEndDots * 2;
            string replace = new string('@', 1);

            for (int row = 1; row <= n; row++)
            {
                var dots = new string('.', lowerStartDots);
                var lowHash = new string('#', lowerHashtags);
                var endDot = new string('.', lowerEndDots);
                var pipe = new string('|', 1);
                if (row == n)
                {
                    pipe = replace;
                }
                Console.WriteLine("{3}{0}{1}{2}", dots, lowHash, endDot, pipe);
            }
        }
    }
}
