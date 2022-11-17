using ReadInformation;
ReadInKeyboard reader = new ReadInKeyboard();
ReadInFile fileReader = new ReadInFile();
void Menu()
{
    Console.WriteLine("Меню");
    Console.WriteLine();
    Console.WriteLine("1. Считать информацию с клавиатуры");
    Console.WriteLine("2. Считать информацию в файл");
    Console.WriteLine("3. Вывести информацию о разработчике программы");
    Console.WriteLine("4. Вывести всю информацию записанную с клавиатуры");
    Console.WriteLine("5. Вывести информацию с файла");
    Console.WriteLine("6. Выход");
}
void GetMenu()
{
    string menu = Console.ReadLine();
    bool parse = int.TryParse(menu, out var select);
    if (parse)
    {
        switch (select)
        {
            case 1:
                reader.WriteInfo();
                break;

            case 2:
                fileReader.WriteInfo();
                break;

            case 3:
                Console.WriteLine("В главных ролях");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Ларионов Дмитрий");
                Console.WriteLine();
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Казарян Данил");
                Console.WriteLine();
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Сивягин Олег");
                break;
            case 4:
                reader.ReadInfo();
                break;

            case 5:
                fileReader.ReadInfo();
                break;

            case 6:
                Console.WriteLine("Нюхай бэбру");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine();
                Console.WriteLine("Ошибка, выберите пункт из меню");
                Console.WriteLine();
                break;
        }
    }
    else
    {
        string path = @"C:\Users\Студент1\Desktop\log.txt";
        FileInfo log = new FileInfo(path);
        if (log.Exists)
        {
            using (StreamWriter writeLog = new StreamWriter(path, true))
            {
                writeLog.WriteLine("Ошибка ввода корректного значения в меню");
                writeLog.WriteLine();
            }
        }
        else
        {
            using (log.Create())
            {

            }
            using (StreamWriter writeLog = new StreamWriter(path, true))
            {
                writeLog.WriteLine("Ошибка ввода корректного значения в меню");
                writeLog.WriteLine();
            }
        }
    }
}
while (true)
{
    Menu();
    GetMenu();
}
