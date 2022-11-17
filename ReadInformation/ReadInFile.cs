using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadInformation;

public class ReadInFile : IReader, IRead
{
    public ReadInFile()
    {

    }
    public void WriteInfo()
    {
        Console.WriteLine("Введите путь считывания информации");
        string path = Console.ReadLine();
        FileInfo file = new FileInfo($"{path}.txt");
        if (file.Exists)
        {
            string read = Console.ReadLine();
            using (StreamWriter write = new StreamWriter(file.FullName, true))
            {
                write.WriteLine(read);
                write.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Информация считана");
                Console.WriteLine($"Информация которую вы записали - {read}");
            }
        }
        else
        {
            string pathLog = @"C:\Users\Студент1\Desktop\log.txt";
            FileInfo log = new FileInfo(pathLog);
            if (log.Exists)
            {
                using (StreamWriter writeLog = new StreamWriter(pathLog, true))
                {
                    writeLog.WriteLine("Ошибка, открытие несуществующего файла");
                    writeLog.WriteLine();
                }
            }
            else
            {
                using (log.Create())
                {

                }
                using (StreamWriter writeLog = new StreamWriter(pathLog, true))
                {
                    writeLog.WriteLine("Ошибка, открытие несуществующего файла");
                    writeLog.WriteLine();
                }
            }
        }
    }
    public void ReadInfo()
    {
        Console.WriteLine();
        Console.WriteLine("Введите путь для просмотра информации");
        string path = Console.ReadLine();
        FileInfo file = new FileInfo($@"{path}.txt");

        if (file.Exists)
        {
            using (StreamReader reader = new StreamReader(file.FullName))
            {
                string readInFile = reader.ReadToEnd();
                if (String.IsNullOrEmpty(readInFile))
                {
                    string pathLog = @"C:\Users\Студент1\Desktop\log.txt";
                    FileInfo log = new FileInfo(pathLog);
                    if (log.Exists)
                    {
                        using (StreamWriter writeLog = new StreamWriter(pathLog, true))
                        {
                            writeLog.WriteLine("Ошибка, файл пуст");
                            writeLog.WriteLine();
                        }
                    }
                    else
                    {
                        using (log.Create())
                        {

                        }
                        using (StreamWriter writeLog = new StreamWriter(pathLog, true))
                        {
                            writeLog.WriteLine("Ошибка, файл пуст");
                            writeLog.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine(readInFile);
                }
            }
        }
        else
        {
            string pathLog = @"C:\Users\Студент1\Desktop\log.txt";
            FileInfo log = new FileInfo(pathLog);
            if (log.Exists)
            {
                using (StreamWriter writeLog = new StreamWriter(pathLog, true))
                {
                    writeLog.WriteLine("Ошибка, открытие несуществующего файла");
                    writeLog.WriteLine();
                }
            }
            else
            {
                using (log.Create())
                {

                }
                using (StreamWriter writeLog = new StreamWriter(pathLog, true))
                {
                    writeLog.WriteLine("Ошибка, открытие несуществующего файла");
                    writeLog.WriteLine();
                }
            }
        }
    }
}
