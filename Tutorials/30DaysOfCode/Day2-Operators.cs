public static void solve(double meal_cost, int tip_percent, int tax_percent)
{
    double tip, tax;
    double total_cost;

    tip = (meal_cost * tip_percent) / 100;

    tax = (meal_cost * tax_percent) / 100;

    total_cost = Math.Round(meal_cost + tip + tax, 0);

    Console.WriteLine(total_cost);
}