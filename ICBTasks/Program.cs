public static class Program
{
    static void Main()
    {
        //var nums = new List<int>() { 1, 2, 3, -4 };
        //var result = FirstTask.SumNumbersUsingRecursion(nums);
        //Console.WriteLine(String.Join(",", result));

        List<string> firstList = new List<string>() { "a","b","c" };
        List<int> secondList = new List<int>() { 1, 2, 3 };

        List<string> result = FirstTask.CombinesTwoLists(firstList, secondList);

        Console.WriteLine(String.Join(",", result));
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
        List<string> combinedList = new List<string>();
        int maxLength = Math.Max(firstList.Count, secondList.Count);

        for (int i = 0; i < maxLength; i++)
        {
            if (i < firstList.Count)
            {
                combinedList.Add(firstList[i]);
            }

            if (i < secondList.Count)
            {
                combinedList.Add(secondList[i].ToString());
            }
        }

        return combinedList;
    }
}