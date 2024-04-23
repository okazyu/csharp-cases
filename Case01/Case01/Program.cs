/* average of a stream of numbers 
 * difficulty level: rookie
 * Given a stream of numbers, print the average (or mean) of the stream at every point. For example, let us consider the stream as 10, 20, 30, 40, 50, 60, ...
 * To print the mean of a stream, we need to find out how to find the average when a new number is being added to the stream. 
 * To do this, all we need is the count of numbers seen so far in the stream, previous average, and new number. 
 * Output:
 * Average of 1 numbers is 10.00000
 * Average of 2 numbers is 15.00000
 * Average of 3 numbers is 20.00000
 * and so it goes...
 */

using System;

class SolvingOne
{
    static int sum, n;

    //Returns the new average after including x
    static float getAvg(int x)
    {
        sum += x;
        return (((float)sum) / ++n);
    }

    //Prints average of a stream of numbers
    static void streamAvg(float[] arr, int n)
    {
        float avg = 0;
        for (int i = 0; i < n; i++)
        {
            avg = getAvg((int)arr[i]);

            if (i == 0)
            {
                Console.WriteLine("Average of {0} number " + "is {1}", (i + 1), avg);
            }
            else
            {
                Console.WriteLine("Average of {0} numbers " + "is {1}", (i + 1), avg);
            }
            
        }
        return;
    }
    static int Main()
    {
        float[] arr = new float[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        int n = arr.Length;
        streamAvg(arr, n);

        return 0;
    }
}