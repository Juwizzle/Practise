using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook_lIkes_31st_Oct_2020_Chapter_6_Question_1
{
    class Program
    {
        static void Main(string[] args)

        {
            // Test for numbers of likes
            Console.WriteLine("Input the name of friends");
            string inputName = Console.ReadLine();
            string[] words = inputName.Split(',');
            if (words.Length == 1)
            {
                Console.WriteLine(words[0] + " Likes your post ");
            }
            if(words.Length == 2)
            {
                Console.WriteLine(words[0] + " , " + words[1] + " Likes your post");
            }
            if (words.Length > 2)
            {
                int others = words.Length - 2;
                string
                    values = others > 1 ? "others" : "other";
                Console.WriteLine(words[0] + "," + words[1] + " and " + others.ToString()  + " " + values  + " Likes your post");
            }
        }
    }
}
