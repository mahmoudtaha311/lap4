namespace lap4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter Length");
            //int len = int.Parse(Console.ReadLine());

            //string[] Names = new string[len];
            //int[] Ages = new int[len];

            //for (int i = 0; i < len; i++)
            //{
            //    Console.WriteLine($"Enter Name foe index{i}");
            //    Names[i] = Console.ReadLine();
            //    Console.WriteLine($"Enter Age foe index{i}");
            //    Ages[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("enter index to display data");
            //int index = int.Parse(Console.ReadLine());

            //if(index >= 0 && index < len)
            //{
            //    Console.WriteLine($"Name: {Names[index]}");
            //    Console.WriteLine($"Age: {Ages[index]}");

            //}

            Console.WriteLine("Enter Array ");
            string input = Console.ReadLine();

            var str_num = input.Split(",");
            int[] nums = new int[str_num.Length];

          
            for (int i = 0; i < str_num.Length; i++)
            {
                
                nums[i] = int.Parse(str_num[i]);
          
            }

            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
             {
                int res = 1;

                for (int j = 0; j < str_num.Length; j++)
                {
                    if (i != j)
                        res *= nums[j];

                }
                result[i] = res;
            }
            
            foreach (int num in result) 
            { 
                Console.WriteLine(num);
            

            }

            
            
        }
    }
}
