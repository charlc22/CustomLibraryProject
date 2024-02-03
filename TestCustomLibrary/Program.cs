/*Name: Charles Cetta
 Course: CPS 3330-02
 Lab: #2
 Kean ID#: 1193276
*/

using static System.Console;

using CustomLibrary_project;

class Program
{
    static void Main(string[] args)
    {
        //ask user for two nums
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        //Avg of two nums
        double twoave = Average.MyAverage(num1, num2);
        Console.WriteLine($"The average of the two numbers is: {twoave}");

        // Additional num
        Console.Write("Enter an additional number: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        //Avg of three nums
        double threeave = Average.MyAverage(num1, num2, num3);
        Console.WriteLine($"The average of the three numbers is: {threeave}");

    }
}
