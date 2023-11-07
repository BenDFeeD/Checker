using System;
using System.Diagnostics;
using System.Threading;

class Checker
{
    static void Main()
    {
        string Path = @"D:\Загрузки\setup\SDA-1.0.10\Steam Desktop Authenticator.exe"; // Путь к программе

        while (true)
        {
            if (!IsRunning("Steam Desktop Authenticator")) // Имя программы
            {
                Process.Start(Path);
                Thread.Sleep(30000); // 30 сек
            }
            else
            {
                Thread.Sleep(300000); // 5 мин
            }
        }
    }

    static bool IsRunning(string Name)
    {
        Process[] process = Process.GetProcessesByName(Name);
        return process.Length > 0;
    }
}