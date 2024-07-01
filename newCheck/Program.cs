//  ПЕРВЫЙ СЕМИНАР


// System.Console.WriteLine("input: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("kvadr " + x + "is " + x * x);


//////////////////////////////////////////////////
///
//Является ли вторая переменная квадратом первой

// System.Console.WriteLine("input 1NUM: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input 2NUM: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x == y * y)
// {
//     System.Console.WriteLine($"x = {x}, y = {y} -> yes");
// }
// else
// {
// System.Console.WriteLine($"x = {x}, y = {y} -> no");
// }


///////////////////////////////////////////////////////////
////////////////////////////////////
///
// показать целые чсла от -n до n

// System.Console.WriteLine("input 1NUM: ");
// int n = Convert.ToInt32(Console.ReadLine());
////////////////// Первое решение
// int arr = 0;

// for(arr = n * -1; arr <= n; arr++)
// {
// System.Console.Write(arr + " ");
// }
//////////////////////////Второе решение
//  int arr = -n;
//  while(arr <= n)
//  {
//     System.Console.Write(arr + " ");
//     arr++;
//  }


//////////////////////////////////////////////////////////////////////////
/////////////////////////////
//////////////
/// ПРоверить число на трехзначность
/// 

// System.Console.WriteLine("input NUM: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n > 99 && n < 1000)
// {
//     int ed = n % 10;
//     int sot = n / 100;

//     System.Console.WriteLine($"{ed + sot} n - Техзначное");
// }
// else
// {
//     System.Console.WriteLine($"{n} - He Техзначное");
// }

///////////////////
///////////////////////////
/////////////////////////ВТОРОЙ СЕМИНАР!!!!!!!!!!!!!!!1

// Метод корторый возвращает квадрат числа

// int Pow(int n)
// {
//    ////// n = n * n;
//     return n * n;
// }
// System.Console.WriteLine("input NUM: ");
// int num = Convert.ToInt32(Console.ReadLine());

// ////num = Pow(num); !!!!!!!!один из вариантов
// System.Console.WriteLine(Pow(num));

///////////////////////////////
/////////////////////
///
//// второе задание


// int Pow(int n)
// { 
//     return n * n;
// }

// void Pow2(int n)
// {
//     System.Console.WriteLine($"kbad {n} = {n * n}");
// }

// System.Console.WriteLine("input NUM: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Pow2(num);


// System.Console.WriteLine("input NUM: ");
// int num = Convert.ToInt32(Console.ReadLine());

//////////////////////////
////////////////////
/////////////////////
//ПРограмма принимает на вход трехзначное число и удаляет вторую цифру числа


// bool Trehznachnost(int x)
// {
//     if(x > 99 && x < 1000)
//     {
//         return true;
//     }
//     return false;
// }

// int ProcessWithNumber(int n)
// {
//     if(Trehznachnost(n))
//     {
//         int ed = n % 10;
//         int sot = n / 100;
//         return sot *10 + ed;
//     }
//     else
//     {
//         System.Console.WriteLine("Не трехзнач");
//         return 0;
//     }
    
// }
// System.Console.WriteLine("input NUM: ");
// int num = Convert.ToInt32(Console.ReadLine());


// System.Console.WriteLine(ProcessWithNumber(num));


// два метода который определяет трехзначность другой удалит среднюю цифру

///////////////////////////////
/////////////////////////
///////////////////////////////
/////////////////////////////////
////Прога принимает число и возводит вторую цифру в степень третьей

// bool Trehznachnost(int x)
// {
//     if(x > 99 && x < 1000)
//     {
//         return true;
//     }
//     return false;
// }

// void ProcessWithNumber(int n)
// {
//     if(Trehznachnost(n))
//     {
//         int ed = n % 10;
//         int des = n /10 % 10;
        
//         System.Console.WriteLine(Math.Pow(des, ed));
//     }
//     else
//     {
//         System.Console.WriteLine("Не трехзнач");
       
//     }
    
// }
// System.Console.WriteLine("input NUM: ");
// int num = Convert.ToInt32(Console.ReadLine());

// ProcessWithNumber(num);


// bool Trehznachnost(int x, int y)
// {
//     if(x % y == 0)
//     {
//         return true;
//     }
//     return false;
// }


// void Kratnost(int i, int j)
// {

//     if(Trehznachnost(i, j))
//     {
//         System.Console.WriteLine(i / j); 
//     }
//     else
//     {
//         System.Console.WriteLine(i % j);
//     }
// }

// System.Console.WriteLine("input NUM1: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input NUM2: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Kratnost(x, y);
