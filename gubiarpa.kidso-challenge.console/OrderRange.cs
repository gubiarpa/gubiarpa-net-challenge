namespace gubiarpa.kidso_challenge.console
{
    public class OrderRange
    {
        public (List<int> oddNumbers, List<int> evenNumbers) Build(IEnumerable<int> numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            var oddNumbers = numbers.Where(n => n % 2 == 0).OrderBy(n => n).ToList();
            var evenNumbers = numbers.Where(n => n % 2 != 0).OrderBy(n => n).ToList();

            return (oddNumbers, evenNumbers);
        }
    }
}
