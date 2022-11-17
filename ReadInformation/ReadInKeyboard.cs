using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadInformation;

public class ReadInKeyboard : IReader, IRead
{
    private List<string> readInKeyboard;
    public ReadInKeyboard()
    {
        readInKeyboard = new List<string>();
    }
    public void WriteInfo()
    {
        Console.WriteLine("Введите информацию для считывания");
        string read = Console.ReadLine();
        readInKeyboard.Add(read);
        Console.WriteLine();
        Console.WriteLine("Информация считана");
        Console.WriteLine($"Информация которую вы записали - {read}");
    }
    public void ReadInfo()
    {
        if (readInKeyboard.Count!=0)
        {
            foreach (var info in readInKeyboard)
            {
                Console.WriteLine($"{info}");
                Console.WriteLine();
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
                    writeLog.WriteLine("Ошибка, информации нет");
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
                    writeLog.WriteLine("Ошибка, информации нет");
                    writeLog.WriteLine();
                }
            }
        }
    }
}
