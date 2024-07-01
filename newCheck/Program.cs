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



/////////////////////////////
////////////////////////
/////////////////////////
///////////////////////////////
/////////////////////////////////
////ТРЕТИЙ СЕМИНАР
////Создаем массив определяем есть ли числа в массиве

// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random random = new Random();
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }
//     return array;
// }

// void Printarray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// bool SearchNum(int[] array, int num)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == num)
//         {
//             return true;
//         }
//     }
//     return false;
// }


// System.Console.WriteLine("input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size, min, max);
// Printarray(myArray);

// System.Console.WriteLine("input num: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(SearchNum(myArray, num));



//////////////////////
////////////////////////////
/////////////////////
///////////////////////
////////////////////////////////Второе задание
///////////// Массив от - 10 до 10 пменять местами


// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random random = new Random();
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }
//     return array;
// }

// void Printarray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int[] RevoltArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// System.Console.WriteLine("input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size, min, max);
// Printarray(myArray);
// myArray = RevoltArr(myArray);
// Printarray(myArray);


// ////////////////////////////
///////////////////////////
////////////////////////////
//////////////////////////////////
/////////////////////////// создать массив, перемножить перый и последний элементы и вывести в массив


// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random random = new Random();
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }
//     return array;
// }

// void Printarray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int[] ProcessArr (int[] array)
// {
//     int[] resultArray = new int[array.Length / 2];

//     for (int i = 0; i < resultArray.Length; i++)
//     {
//         resultArray[i] =  array[i] * array[array.Length - i - 1];
//     }
//     return resultArray;
// }


// System.Console.WriteLine("input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size, min, max);
// Printarray(myArray);
// Printarray(ProcessArr(myArray));


///////////////////////////////
////////////////////////////////
/////////////////////////////
////////////////////////////////
//////////////////////////////
//// Четвертая лекция


// int CounterDigits(int number)
// {
//     int counter = 0;
//     while(number > 0)
//     {
//         number = (number - number % 10) / 10;
//         counter++;
//     }
//     return counter;
// }


// System.Console.WriteLine("input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(CounterDigits(num)); 


////////////////////////////
////////////////////////////
////////////////////////////
////////////////////////////
///////////////////////////