/* write a program to reverse the words of a sentence
* difficulty level: rookie
* Sample Output: 
* Original string: display the pattern like pyramid using the alphabet.
* Reversed string: alphabet. the using pyramid like pattern the display
*/

using System;

class SolvingThree
{

    static List<string> ReverseIt(string text)
    {
        string result = "";
        List<string> reverseWords = new List<string>(); //list to store reversed strings

        //splits the string into individual words
        string[] words = text.Split(new[] { " " }, StringSplitOptions.None); // stringsplitoptions is an enum that determines how the results are treated when a string is divided.
                                                                             // the .None means that empty parts (or white spaces) will be included.

        for (int i = words.Length - 1; i >= 0; i--)
        {
            result += words[i] + " "; // builds the reversed string by adding words in reverse order 
        }

        reverseWords.Add(result);

        return reverseWords;

    }

    static void Main()
    {

        Console.WriteLine("type the line you want it reversed!");

        string line = Console.ReadLine();
        if (line == "")
        {
            Console.WriteLine("please! write something to be reversed");
        }

        List<string> reversedText = ReverseIt(line);

        foreach (var reversedLine in reversedText)
        {
            Console.WriteLine($"first, the original line: {line}");
            Console.WriteLine($"then the new, reversed line: {reversedLine}");
        }
    }

}
