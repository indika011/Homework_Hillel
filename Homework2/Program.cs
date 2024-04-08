using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8; // на всякий випадок

        // а) Обчислення величини знижки

        double productCost = 150.0; // Вартість товару
        double discount = 10.0; // Відсоток знижки
        double discountAmount = productCost * (discount / 100); // Обчислення величини знижки
        Console.WriteLine($"Величина знижки: {discountAmount}");

        // б) Час в секундах

        int hours = 2; // Час у годинах
        int minutes = 35; // Час у хвилинах
        int seconds = 50; // Час у секундах
        int totalTimeInSeconds = (hours * 3600) + (minutes * 60) + seconds; // Обчислення загального часу у секундах
        Console.WriteLine($"Загальний час у секундах: {totalTimeInSeconds}");

        // в) Інформація про книгу

        string bookTitle = "Назва книги"; // Назва книги
        string bookAuthor = "Автор книги"; // Автор книги
        int bookYear = 2024; // Рік видання
        double bookPrice = 200.0; // Ціна книги
        Console.WriteLine($"Назва книги: {bookTitle}, Автор: {bookAuthor}, Рік видання: {bookYear}, Ціна: {bookPrice}");
    }
}