public static class Program
{
    static void Main()
    {
       
    }

}
public static class FirstTask
{


    public static int SumNumbersUsingLoop(List<int> numbers)
    {
        var result = 0;
        foreach (var number in numbers)
        {
            result += number;
        }
        return result;
    }
    public static int SumNumbersUsingWhileLoop(List<int> numbers)
    {
        var result = 0;
        int index = 0;

        while (index < numbers.Count)
        {
            result += numbers[index];
            index++;
        }

        return result;
    }
    public static int SumNumbersUsingRecursion(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            return 0;
        }
        else
        {
            int lastNumber = numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1);
            return lastNumber + SumNumbersUsingRecursion(numbers);
        }
    }
    public static List<string> CombinesTwoLists(List<string> firstList, List<int> secondList)
    {
        List<string> result = new List<string>();
        int maxLength = Math.Max(firstList.Count, secondList.Count);

        for (int i = 0; i < maxLength; i++)
        {
            if (i < firstList.Count)
            {
                result.Add(firstList[i]);
            }

            if (i < secondList.Count)
            {
                result.Add(secondList[i].ToString());
            }
        }

        return result;
    }
    public static List<ulong> ComputeFibonacciNumbers(int count)
    {
        List<ulong> fibonacciNumbers = new List<ulong>();

        ulong a = 0;
        ulong b = 1;

        for (int i = 0; i < count; i++)
        {
            fibonacciNumbers.Add(a);

            ulong temp = a;
            a = b;
            b = temp + b;
        }

        return fibonacciNumbers;
    }
    public static List<string> ArrangeLargestNumber(List<int> numbers)
    {
        List<string> arrangestNumbers = numbers.Select(n => n.ToString()).ToList();

        arrangestNumbers.Sort((first, second) =>
        {
            string firstResult = first + second;
            string secondResult = second + first;
            return secondResult.CompareTo(firstResult);
        });

        return arrangestNumbers;
    }
    
}