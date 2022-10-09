for (int i = 1; i <= 10; i++)
{
    Console.Write(i + ". Sayıyı Giriniz : ");
    int sayi = int.Parse(Console.ReadLine());

    if (sayi % 2 == 0) 
        Console.WriteLine(sayi + " Sayısı Çift Sayıdır...");  
    else
        Console.WriteLine(sayi + " Sayısı Tek Sayıdır...");

    Console.WriteLine("");
}