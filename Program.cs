//  Задача;  принимаает число целое и выдает сумму чисел до него 

int FindSum (int num)
{
    int sum = 0;

    for ( int current = 1; current <= num; current++)
    sum+= current;

    return sum;

}
Console.WriteLine ("Input posotov integer numbe:  r");
int a = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine($" sum of number from 1 to {a} is {FindSum (a)}");



// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.  сами 

int FindDigit (int num)
{
 int length_num = 0;
 

 for (length_num = 0; num > 0; length_num++  )    // цикл подсчета разряда 
 {
    num = num/10;   //делим на 10 получаем разряд 

 }
return length_num;

Console.WriteLine ("введите число :  ");
int a = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine($" колличество цифр  {FindDigit} ");


}







// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. сами

int FindSum (int num)
{
    int sum = 0;

    for ( int current = 1; current <= num; current++)
    sum*= current;

    return sum;

}
Console.WriteLine ("Input posotov integer numbe:  r");
int a = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine($" sum of number from 1 to {a} is {FindSum (a)}");





// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.  сами

Int [] FindArray (int [] arr)
{
    int length = arr.Length;
    int index = 0

    while (index < length)
    {
        arr(index) = new Random().Next(0, 2);
        index++;
    }
    

    return arr

}
 Console.WriteLine (" получили массив {               }");
int array  = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine(   );

// в общем зале 

