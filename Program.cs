using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите URL сайта: ");
        string url = Console.ReadLine();

        try
        {
            using (WebClient client = new WebClient())
            {
                string html = client.DownloadString(url);

                string directoryPath = @"D:\Scenario";
                string filePath = System.IO.Path.Combine(directoryPath, "page.html");
                System.IO.Directory.CreateDirectory(directoryPath);
                System.IO.File.WriteAllText(filePath, html);

                Console.WriteLine("Страница успешно загружена и сохранена в файле " + filePath);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}