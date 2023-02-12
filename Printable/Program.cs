namespace Printable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book It = new Book();
            Book Call_of_Cthulhu = new Book();
            Magazine magazineFirst = new Magazine();
            Magazine magazineSecond = new Magazine();
            Printable[] warehouse = { It, Call_of_Cthulhu, magazineFirst, magazineSecond};
            for (int i =0; i < warehouse.Length;i++)
            {
                warehouse[i].Print();
            }

            Book.printBook(warehouse);
            Magazine.printMagazines(warehouse);
        }
    }

    public interface Printable
    {
        public void Print();
    }

    public class Book : Printable
    {
        public static void printBook(Printable[] printable)
        {
            for (int i = 0; i < printable.Length; i++)
            {
                if (printable[i].GetType() == typeof(Book))
                {
                    printable[i].Print();
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Book");
        }
    }
    public class Magazine : Printable
    {
        public static void printMagazines(Printable[] printable)
        {
            for (int i = 0; i < printable.Length; i++)
            {
                if (printable[i].GetType() == typeof(Magazine))
                {
                    printable[i].Print();
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Magazine");
        }
    }
}