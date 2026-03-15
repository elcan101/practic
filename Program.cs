





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






//string result = Find(20);
//Console.WriteLine(result);

//static string Find(int num1)
//{
//    if (num1 > 0) return "musbet";
//    else if (num1 < 0) return "menfi";
//    else return "0-a beraberdir";
//}








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




//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());

//FindType(a, b, c);

//static void FindType(int a, int b, int c)
//{
//    if (a == b && b == c)
//    {
//        Console.WriteLine("berabertereflidir");
//    }
//    else if (a == b || b == c || a==c)
//    {
//        Console.WriteLine("beraberyanli");
//    }
//    else
//    {
//        Console.WriteLine("muxtelifterefli");
//    }
//}



//int a = 34;

//Oyun(a);

//static void Oyun(int a)
//{
//    int c = 0;
//    while (c < 5)

//    {
//        int b = Convert.ToInt32(Console.ReadLine());
//        if (a == b)
//        {
//            Console.WriteLine("you won");
//            break;
//        }
//        else
//        {
//            c++;
//            if (c == 5) { Console.WriteLine("you lost all chance"); break; }
//            Console.WriteLine("You losed. Enter again");
//        }
//    } 
//}







//Console.WriteLine("Sahesini tapmaq istediyiniz fiquru daxil edin (kvadrat, ucbucaq, dordbucaq):");
//string fiqur = Console.ReadLine();

//int a = 0;
//int b = 0;
//int h = 0;

//Console.WriteLine("a daxil edin:");
//a = Convert.ToInt32(Console.ReadLine());

//if (fiqur == "kvadrat")
//{
//    b = a; // kvadratda b = a
//}
//else if (fiqur == "dordbucaq")
//{
//    Console.WriteLine("b daxil edin:");
//    b = Convert.ToInt32(Console.ReadLine());
//    h = b; // duzbucaqlida h = b
//}
//else if (fiqur == "ucbucaq")
//{
//    Console.WriteLine("h daxil edin:");
//    h = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("Sahe: " + Sahe(fiqur, a, b, h));

//static int Sahe(string fiqur, int a, int b, int h)
//{ 
//    switch (fiqur)
//    {
//        case "kvadrat":
//            return a * a;

//        case "dordbucaq":
//            return a * b;

//        case "ucbucaq":
//            return a * h / 2;

//        default:
//            return 0;
//    }
//}






//int a = Convert.ToInt32(Console.ReadLine());
//Palindrom(a);
//static void Palindrom(int a)
//{
//    int original = a;
//    int reverse = 0;

//    while (a > 0)
//    {
//        int digit = a % 10;          // son rəqəm
//        reverse = reverse * 10 + digit;
//        a = a / 10;                  // son rəqəmi sil
//    }

//    if (original == reverse)
//    {
//        Console.WriteLine("Palindromdur");
//    }
//    else
//    {
//        Console.WriteLine("Palindrom deyil");
//    }
//}






//cube(100);
//static void cube(int num1)
//{
//    if (num1 < 100 && num1 > 1)
//    {
//        Console.WriteLine (num1 * num1 * num1);
//    }
//    else
//    {
//        Console.WriteLine("1 ve 100 araliginda bir eded daxil edin");
//    }
//}







//string name = Console.ReadLine();
//string surname = Console.ReadLine();
//Console.WriteLine(Call(name,surname));
//static string Call(string name, string surname)
//{
//    return "Welcome " + name + " " + surname;   
//}







//string word = Console.ReadLine();
//Console.WriteLine(FindCount(word));
//static int  FindCount(string word)
//{
//    int count = 0;
//    char[] chars = word.ToCharArray();
//    for (int i = 0; i < chars.Length; i++)
//    {
//        count++;
//    }return count;
//}






//Console.WriteLine("Bir meyve secirsiniz.3 cehd haqqiniz var.");
//string answer = "alma";
//string fruit = Console.ReadLine().ToLower();
//Game( fruit, answer);

//static void Game(string fruit, string answer)
//{
//    int i = 1;
//    while (i<=3)
//    {
//        if (fruit == answer)
//        {
//            Console.WriteLine("you won");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("you lost");
//            break;
//        } i++;
//    } 
//}







//int[] arr = new int[100];
//Diz(arr);

//static void Diz(int[] arr)
//{
//    for (int i = 0; i <= arr.Length; i++)
//    {
//        int number = i + 1;
//        if (number % 7 == 0 || number % 10 == 7)
//        {
//            Console.WriteLine("Diz");
//        }
//        else
//        {
//            Console.WriteLine(number);
//        }
//    }
//}







//int[] arr ={10, 12, 22, 10, 32, 22, 16, 32, 22, 10, 11, 23, 32, 10, 10, 23, 23, 15};
//int Count = FindCount(arr);
//Console.WriteLine(Count);
//static int FindCount(params int[] arr)
//{
//    int Count = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        bool IsRepeat = false;
//        for (int j = 0; j < i; j++)
//        {
//            if (arr[i] == arr[j])
//            {
//                IsRepeat = true;
//                break;
//            }
//        }
//        if (!IsRepeat)
//        {
//            Count++;
//        }
//    } return Count;
//}








//using System.Numerics
//int a = 5;
//int b = 6;
//Change(ref a, ref b);

//Console.WriteLine(a);
//Console.WriteLine(b);

//static void Change( ref int num1, ref int num2)
//{
//    int temp = num1;
//        num1 = num2;
//        num2 = temp;
//}







//int a = 5;
//int num1 = 0;
//Addition(ref a);
//Console.WriteLine(a);

//static void Addition(ref int num1)
//{
//    num1 += 10;
//}






//int a = 37;
//int b = 6;
//int result;
//int qaliq;
//Addition(ref a,ref b, out qaliq,out result);

//Console.WriteLine("qaliq: " + qaliq);
//Console.WriteLine("Netice: " + result);

//static void Addition(ref int num1,ref int num2, out int qaliq, out int result)
//{
//    qaliq= num1 % num2;
//    result = num1/num2;
//}






//3 ədəd qəbul edən metod yazın və ən böyük və ən kiçik ədədi out ilə qaytarsın. (out) FindMinMax(int a, int b, int c, out int min, out int max)

//FindMinMax(5, 8, 20, out int min, out int max);

//Console.WriteLine($"min: {min}, max: {max}");

//static void FindMinMax(int a, int b, int c, out int min, out int max)
//{
//    min = a;
//    max = a;

//    if (b < min) min = b;
//    if (c < min) min = c;

//    if (b > max) max = b;
//    if (c > max) max = c;
//}






//int score = 56;

//IncreaseScore(ref  score);
//Console.WriteLine(score);

//static void IncreaseScore(ref int num1)
//{
//    num1 += 10;
//}





//string name;
//int age;
//string result;

//Adult(out name, out age, out result);
//Console.WriteLine(result);

//static void Adult(out string name, out int age, out string result)
//{
//    age = 23;
//    name = "Nahid";
//    if (age > 18)
//    {
//         result = "name: " + name + " yetkindir";
//    }else
//    {
//         result = "Name: " + name + " Yetkin deyil";
//    }
//}




//double [] arr = { 24, 52, 60, 100 };
//double[] arr1 = new double[arr.Length];

//endirim(ref arr, out arr1);

//for (int i = 0; i < arr1.Length; i++)
//{
//    Console.WriteLine(arr1[i]);
//}
//static void endirim(ref double[] arr, out double[] arr1)
//{
//     arr1 = new double[arr.Length];
//    for (int i = 0; i < arr.Length; i++)
//    {
//        arr1[i]= arr[i]* 0.6;
//    }
//}



//string name;
//string surname;
//int age;
//string email;
//string pasword;
//string username;

//Register(out name, out surname, out age, out email, out pasword,out username);

//static void  Register(out string  name, out string surname, out int age, out string email,out string pasword,out string username)
//{
//    Console.WriteLine("enter name");
//     name =Console.ReadLine();
//    Console.WriteLine("enter surname");
//     surname =Console.ReadLine();
//    Console.WriteLine("enter age ");
//    age  = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("enter email");
//     email = Console.ReadLine();
//    Console.WriteLine("enter pasword");
//    pasword  =Console.ReadLine();
//    Console.WriteLine("enter username");
//    string inputusername = Console.ReadLine();
//    string date = DateTime.Now.ToString("ddMMyyyyHHmmss");
//    username = inputusername + date;
//    Console.WriteLine("name: " + name);
//    Console.WriteLine("surname: " + surname);
//    Console.WriteLine("age: " + age);
//    Console.WriteLine("email: " + email);
//    Console.WriteLine("pasword: " + pasword);
//    Console.WriteLine("username: " + username);
//}