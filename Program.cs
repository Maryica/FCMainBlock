//string[] arrayStrings = new string[4] { "Hello", "2", "world", ":-)" };
//string[] arrayStrings = new string[4] { "1234", "1567", "-2", "computer science" };
string[] arrayStrings = new string[3] { "Russia", "Denmark", "Kazan" };


int count = 0;
for (int i = 0; i <= arrayStrings.Length - 1; i++)
{
    if (arrayStrings[i].Length <= 3)
    {
        count++;
    }

}

string[] newArrayThreeCharacters = new string[count];
int parameter = 0;
for (int i = 0; i <= arrayStrings.Length - 1; i++)
{
    if (arrayStrings[i].Length <= 3)
    {
        newArrayThreeCharacters[parameter] = arrayStrings[i];
        parameter++;
    }

}


void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("[]");
    }
    else
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"'{array[i]}',");

        }
        Console.Write($"{array[^1]}");
        Console.Write("]");
        Console.WriteLine();
    }
}


PrintArray(arrayStrings);
PrintArray(newArrayThreeCharacters);
