int[] numbers = new int[7]; // 7 elemanlık bir dizi boyutu oluşturuyoruz.
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Enter a number:\t"); // Kullanıcının diziye eleman aktarması. 
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        numbers[i] = value;
    }
    else
    {
        Console.WriteLine("Invalid number");// Kullanıcı eğer integer değer aralığın dışında bir eleman girerse geçersiz sayılır.
    }
}
foreach (int value in numbers)
{
    Console.WriteLine($"\n Your number is {value}");
}

