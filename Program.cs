namespace CalculateWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
          while(true)
            {
                Console.Write("Enter your weight: ");
                float weiht = float.Parse(Console.ReadLine());
                Console.Write("Enter your height: ");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine($"BMI:{(weiht / (height * height)) * 10000} m/h^2");
                Console.WriteLine();
            }
           
        }
    }
}