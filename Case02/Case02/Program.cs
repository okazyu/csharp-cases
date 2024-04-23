/* convert a hexadecimal number to a decimal number and a decimal nunmber to a hexadecimal number
 * difficulty level: rookie
 * Sample Output: 
 * Hexadecimal Number: 4B0
 * Convert to - Decimal number: 1200
 * extra challenge: don't use System.Globalization.NumberStyles.HexNumber
 *
 */


using System;

class SolvingTwo
{
    static int decNumber;
    static string hexNumber;

    //first, the hex to dec
    static int convertToDec(string hex)
    {
        decNumber = 0;

        //convert all characters to uppercase
        hex = hex.ToUpper();

        //iterates over each digit of the hexadecimal number
        for (int i = 0; i < hex.Length; i++)
        {
            char digit = hex[i];
            int digitValue;

            //if the character is a numerical digit, converts directly to integer
            if (char.IsDigit(digit))
            {
                digitValue = digit - '0';
            }
            else //if the character is a letter, calculates its correspondent value
            {
                digitValue = digit - 'A' + 10;
            }

            decNumber = decNumber * 16 + digitValue;
        }

        return decNumber;
    }

    //then, the dec to hex
    static string convertToHex(int dec)
    {
        string hexChars = "0123456789ABCDEF";
        string hex = "";

        while (dec > 0)
        {
            int remainder = dec % 16;
            hex = hexChars[remainder] + hex;
            dec /= 16;
        }

        return hex;
    }

    static void Main()
    {
        //lets create a little simple interface to select the conversion we want to do
        Console.WriteLine("hello! welcome to the conversion app. please, what do you want to convert?");
        Console.WriteLine("ps.: use hex (to convert to hex) or dec(to convert to dec) to choose!");
        string choice = Console.ReadLine();

        if (choice == "dec" || choice == "decimal")
        {
            Console.WriteLine("Type a hexadecimal value to convert: ");
            hexNumber = Console.ReadLine();
            decNumber = convertToDec(hexNumber);
            Console.WriteLine($"The converted number was {hexNumber}, and it's result is: {decNumber}");
        }
        else if (choice == "hex" || choice == "hexadecimal")
        {
            Console.WriteLine("Type a decimal value to convert: ");
            decNumber = int.Parse(Console.ReadLine());
            hexNumber = convertToHex(decNumber);
            Console.WriteLine($"The converted number was {decNumber}, and it's result is: {hexNumber}");
        }
    }
}