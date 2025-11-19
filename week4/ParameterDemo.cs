namespace Week4.Week4
{
    // ParameterDemo class to demonstrate different parameter types
    public class ParameterDemo
    {
        // Method using ref parameter to increase the number by 10
        public void Increase(ref int number)
        {
            number += 10;
        }

        // Method using out parameter to return full name
        public void GetFullName(out string fullname)
        {
            fullname = "Karan Bastola";
        }

        // Method using params parameter to return sum of all numbers
        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
