
namespace helloworld
{

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                System.Console.WriteLine("helloworld 이름");
                System.Console.ReadKey(); //me
                return;
            }

            System.Console.WriteLine("hello,{0}", args[0]);
            System.Console.ReadKey(); /* 콘솔창에서 키를 입력받기위해 대기 */
       
        }
      
            
    
     }
}
