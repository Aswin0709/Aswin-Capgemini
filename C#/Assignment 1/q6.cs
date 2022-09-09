
class Program
{

    struct Books
    {
        public int bookId { get; set; }
        public string title { get; set; }
        public float price { get; set; }
        public enum BookType : int { Magazine = 1, Novel = 2, ReferenceBook = 3, Miscellaneous = 4 }

        public BookType bookType { get; set; }
    }

    public static void Main(string[] args)
    {
        int choice;
        Books book1 = new Books();

        do
        {
            System.Console.WriteLine("What Operation do you want to perform \n" +
                                     "1. Add Details of Book\n" +
                                     "2. Display Details of Book\n");
            choice = Convert.ToInt32(System.Console.ReadLine());
            if (choice != 1 && choice != 2)
            {
                System.Console.WriteLine("Enter a valid choice.");
            }


            

            if (choice == 1)
            {

                Console.WriteLine("Enter id of the book");
                book1.bookId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter title of the book");
                book1.title = Console.ReadLine();
                Console.WriteLine("Enter price of the book");
                book1.price = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of the type of the book:\n 1.Magazine\n 2.Novel\n3.ReferenceBook\n 4.Miscellanous");
                int num = Convert.ToInt32(Console.ReadLine());
                book1.bookType = (Books.BookType)num;


            }

            else
            {
                Console.WriteLine("Id of the book is :{0}\nTitle of the book is :{1}\nPrice of the book is :{2}\n Type of the book is :{3}\n", book1.bookId, book1.title, book1.price, book1.bookType);

            }

        } while (choice == 1 || choice == 2);
    }
}