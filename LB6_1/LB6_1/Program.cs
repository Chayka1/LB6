class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mylist = new MyList<int>(5);
            mylist[0] = 1;
            Console.WriteLine("Емкость списка: {0} элемент(-ов)", mylist.Capacity);
            Console.WriteLine("Список фактически содержит: {0} элемент(-ов)", mylist.Count);
            mylist.Add(15);
            Console.WriteLine("Емкость списка: {0} элемент(-ов)", mylist.Capacity);
 
            Console.ReadKey();
        }
    }
}
