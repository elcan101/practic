//string ad = Console.ReadLine();
//string soyad = Console.ReadLine();
//Console.WriteLine("Welcome," + " " + ad + " " +soyad);

//string a = Console.ReadLine();
//int count = 0;
//for (int i = 0; i < a.Length; i++)
//{
//    count++;
//}
//Console.WriteLine(a + "-" + count);



//int a = Convert.ToInt32(Console.ReadLine());

//if (a <= 100)
//{
//    Console.WriteLine(a * a * a);
//}
//else
//{
//    Console.WriteLine("100-e qeder eded daxil edin");
//}

//int attempt = 5;
//int target = 19;

//while (attempt > 0)
//{
//    Console.Write("Bir eded daxil edin: ");
//    int number = Convert.ToInt32(Console.ReadLine());

//    if (target == number)
//    {
//        Console.WriteLine("Dogru tapdiniz!");
//        break;
//    }
//    else
//    {
//        attempt--;
//        Console.WriteLine("Bir daha sinayin. Qalan cehd: " + attempt);
//    }
//}

//if (attempt == 0)
//{
//    Console.WriteLine("Game Over");
//}

//int[] numbers = new int[100];
//for (int i = 1; i <= 100; i++)
//{
//    if (i % 7 ==0 || i % 10 == 7)
//    {
//        Console.WriteLine("dizz");
//    }
//    else
//    {
//        Console.WriteLine(" " + i);
//    }
//}

//using System;
//using System.Diagnostics.CodeAnalysis;

//returntype MethodName(parametr)

//int FindMax(int num1, int num2)
//{
//    if (num1 > num2) return num1;
//    else if (num2 > num1) return num2;
//    else return num1;
//}

//int result = FindMax(32, 31);
//Console.WriteLine(result);


//string Find(int num1)
//{
//    if (num1 % 2 == 0) return "bolunur";
//    else return "bolunmur";

//}
//string result = Find(5);
//Console.WriteLine(result);

//string Find(int num1)
//{
//    if (num1 >= 100)  return "boyuk";
//    else return "kicikdir";
//}
//string result = Find(100);
//Console.WriteLine(result);



//string Find(int num1)
//{
//    if (num1 >= 18) return "adult";
//    else return "child";
//}
//string result = Find(20);
//Console.WriteLine(result);


//string Find(int num1)
//{
//    if (num1 > 0) return "musbet";
//    else if (num1 < 0) return "menfi";
//    else return "0-a beraberdir";
//}
//string result = Find(20);
//Console.WriteLine(result);



//int cube(int num1)
//{
//    return (num1 * num1 * num1);
//}
//int result = cube(3);
//Console.WriteLine(result);



//int day = Convert.ToInt32(Console.ReadLine());
//static string NameOfWeek(int day)

//{
//    switch (day)
//    {
//        case 1: return "Monday";
//        case 2: return "Tuesday";
//        case 3: return "Wendesday";
//        case 4: return "thersday";
//        case 5: return "friday";
//        case 6: return "saturday";
//        case 7: return "sunday";
//        default: return "enter number";
//    }
//}

//Console.WriteLine(NameOfWeek(day));




//int month = Convert.ToInt32(Console.ReadLine());
//static string DayOfMonth(int month)

//{
//    switch (month)
//    {
//        case 1: return "31";
//        case 2: return "28";
//        case 3: return "31";
//        case 4: return "31";
//        case 5: return "31";
//        case 6: return "31";
//        case 7: return "31";
//        case 8: return "31";
//        case 9: return "31"; 
//        case 10: return "31"; 
//        case 11: return "31"; 
//        case 12: return "31";
//        default: return "enter number";
//    }
//}

//Console.WriteLine(DayOfMonth(month));

