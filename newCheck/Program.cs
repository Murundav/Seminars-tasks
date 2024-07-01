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
