using System;

class Program
{
    static int GenerateBill(int UnitsConsumed)
    {
        int Meter_Charge = 75, Charge = 0, TotalWaterBill = 0;
        if (UnitsConsumed <= 100)
            Charge = UnitsConsumed * 5;
        else if (UnitsConsumed <= 250)
            Charge = UnitsConsumed * 10;
        else
            Charge = UnitsConsumed * 20;
        TotalWaterBill = Charge + Meter_Charge;

        return TotalWaterBill;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number of units consumed");
        int UnitsConsumed = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Total Water bill: " + GenerateBill(UnitsConsumed));
    }
}
