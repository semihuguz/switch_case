﻿int month = DateTime.Now.Month;
switch(month)
{
    case 1:
        Console.WriteLine("Ocak Ayindasiniz");
        break;
    case 2:
        Console.WriteLine("Subat Ayindasiniz");
        break;
    case 3:
        Console.WriteLine("Mart Ayindasiniz");
        break;
    case 4:
        Console.WriteLine("Nisan Ayindasiniz");
        break;
    case 5:
        Console.WriteLine("Mayis Ayindasiniz");
        break;
    case 6:
        Console.WriteLine("Haziran Ayindasiniz");
        break;
    default:
        Console.WriteLine("Yanlis  veri girisi");
    break;

}

switch(month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kis Mevsimindesiniz");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Ilk bahar Mevsimindesiniz");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz Mevsimindesiniz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar mevsimindesiniz");
        break;
    default:
    break;
    
}