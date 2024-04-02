class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значения через запятую:");
        string input = Console.ReadLine();
        string[] arr = input.Split(',');

        string[] result = FilterStrings(arr);

        Console.WriteLine("Значения длиной 3 и меньше:");
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] arr)
    {
        int resultLength = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
            {
                resultLength++;
            }
        }

        string[] result = new string[resultLength];
        int index = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }
}
