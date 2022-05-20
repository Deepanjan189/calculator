
namespace TestProject
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            var parts = numbers.Split(',');
            var result = 0;
            var negatives = new List<int>();

            foreach (var part in parts)
            {
                int.TryParse(part, out int number);

                if (number < 0)
                {
                    negatives.Add(number);
                }
                else if(number <= 1000)
                        {
                    result += number;
                }
            }

            if (negatives.Count > 0)
            {
                var negativesList = string.Join(',', negatives);
                var exceptionMessage = $"Negative numbers not allowed: {negativesList}.";
                throw new ArgumentException(exceptionMessage);
            }

            return result;
        }
    }
}
