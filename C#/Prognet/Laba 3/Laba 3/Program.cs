using System.Reflection.PortableExecutable;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //Task1();
        //Task2();    
        //Task3();
        //Task4();
        //Task5();
        Task6();
    }

    static void Task1()
    {
        Random rand = new Random();
        string[][] jaggedArray = new string[5][];
        using (StreamWriter writer = new StreamWriter("TaskRandom.txt"))
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int lenght = rand.Next(5, 15);
                char[] chars = new char[lenght];
                for (int j = 0; j < lenght; j++) 
                {
                    chars[j] = (char)rand.Next(97, 123);
                }
                jaggedArray[i] = new string[] {new string(chars)};
                writer.WriteLine(jaggedArray[i][0]);
            }
        }
    }

    static void Task2()
    {
        using (StreamReader reader = new StreamReader("Task1.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                int count = line.Split('s').Length - 1;
                Console.Write(count + ", ");
            }
        }
        Console.WriteLine();
    }

    static void Task3()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        using (StreamReader reader = new StreamReader("Task1.txt", Encoding.GetEncoding(866)))
        using (StreamWriter writer = new StreamWriter("Task1_new.txt", false, Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line);
            }
        }
    }

    static void Task4()
    {
        using (StreamReader reader = new StreamReader("Task2.txt"))
        using (StreamWriter writer = new StreamWriter("Task2_new.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line.Replace("объект", "класс"));
            }
        }
    }

    static void Task5()
    {
        string text3 = File.ReadAllText("Task2.txt");
        string[] text3New = text3.Split(' ');
        int text3Number = text3New.Length;
        Console.WriteLine($" Кол-во слов: {text3Number}");
    }

    static void Task6()
    {
        //C:\Program Files
        string path = @"C:\Program Files";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      

        var di = new DirectoryInfo(path);
        DirectoryInfo[] dirs = di.GetDirectories();
        FileInfo[] files = di.GetFiles();

        for (int i = 0; i < dirs.Length; i++) 
        { 
            Console.WriteLine("Директории: " + dirs[i].FullName);
            
        }
        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine("Файлы: " + files[i].FullName);   
        }

    }
}