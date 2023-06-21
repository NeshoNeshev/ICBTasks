public static class Program
{
    static void Main()
    {
       
        while (true)
        {
            var salary = Decimal.Parse(Console.ReadLine());
            Console.WriteLine(Salary.NetSalary(salary));
        }
        
    }

    
}
public static class Salary
{
   
    const int taxFree = 1000;
    const int maxTax = 3000;
    const int socialContribution = 15;
    const int tax = 10;
    public static decimal NetSalary(decimal salary)
    {
       
        if (salary == taxFree)
        {
            return taxFree;
        }
        else if (salary < taxFree)
        {
            return salary;
        }
        var difference = salary - taxFree;
        var thenPercentage = (difference * tax) / 100;    

        decimal currentTaxation = 0;

        if (salary > 3000)
        {
            currentTaxation = maxTax - taxFree;
            decimal total = (currentTaxation * socialContribution) / 100;
            thenPercentage += total;
        }
    
        return Math.Round(salary - thenPercentage,2) ;
    }

}