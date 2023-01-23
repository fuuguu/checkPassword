internal class Program
{
    private static void Main(string[] args)
    {
        int triesCount = 5;
        string password = "123456";
        string userInput;

        for (int i=0; i<triesCount; i++)
        {
            Console.Write("Введите пароль: ");
            userInput= Console.ReadLine();
            if(userInput==password)
            {
                Console.WriteLine("Добро пожаловать");
                break;
            }
            else
            {
                Console.WriteLine("Введен неверный пароль.");
                    Console.WriteLine($"У вас осталось попыток: {triesCount-(i+1)}");
            }
        }
    }
}