using System.Globalization;

namespace gubiarpa.kidso_challenge.console
{
    public class MoneyParts
    {
        private readonly decimal[] denominations;

        public MoneyParts()
        {
            denominations = [200m, 100m, 50m, 20m, 10m, 5m, 2m, 1m, 0.5m, 0.2m, 0.1m, 0.05m];
        }

        public List<List<decimal>> Build(string amountString)
        {
            if (!decimal.TryParse(amountString, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var amount))
                throw new ArgumentException("Invalid amount format.", nameof(amountString));

            var results = new List<List<decimal>>();

            FindCombinations(amount, new List<decimal>(), 0, results);

            return results;
        }

        private void FindCombinations(decimal remaining, List<decimal> current, int start, List<List<decimal>> results)
        {
            if (remaining == 0) // if solution was found
            {
                results.Add([.. current]); // adding solution
                return;
            }

            for (int i = start; i < denominations.Length; i++)
            {
                decimal coin = denominations[i];
                if (coin <= remaining) // taking lower values
                {
                    current.Add(coin);
                    FindCombinations(remaining - coin, current, i, results);
                    current.RemoveAt(current.Count - 1);
                }
            }
        }
    }
}
