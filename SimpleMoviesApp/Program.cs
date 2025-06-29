namespace SimpleMoviesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieManager m1 = new MovieManager();
            int choice = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. for add Movie");
                Console.WriteLine("2. for dispaly Movies");
                Console.WriteLine("3. for ClearAll Movies");
                Console.WriteLine("4. for exit");
                
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        m1.addMovie();
                        break;
                    case 2:
                        m1.displayMovies();
                        break;
                    case 3:
                        m1.ClearMovies();
                        break;
                    case 4:
                        Console.WriteLine("exited successfully");
                        break;
               


                }

            } while (choice != 4);

        }
    }
}
