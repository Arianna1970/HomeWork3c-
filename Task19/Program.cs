 
void PrintIfPalindrom(bool Yes ) 
{
   if (Yes)
    System.Console.WriteLine("Да, это палиндром.");
  else  
    System.Console.WriteLine("Нет, не палиндром.");
}     


// программа работанет с любыми числами
// для задачи используется  6значное число 
bool IfPalindrom(int[] arr)
{ 
  int len = arr.Length;
  int middle = len/2;
  bool Flag = true;
  int shift=len%2;
  int even = 0;
  // является ли число разрядов четным
  if (shift == 0)
      even = 1;
  
  while (  shift <= middle -even )
     { 
      
        if ( arr[middle+shift]!=arr[middle-shift-even])
           { Flag = false;
             break;
           } 
        shift ++;   

     }
  
   return Flag;

}
// преобразование цифр десятичного числа в массив целых чисел 
int[] NumberToArray(int number)
{
 
  int TempNumber = number;
  int Count=0;
  // определим, сколько в числе разрядов
  while ( TempNumber!=0 )
  { 
    TempNumber/=10;
    Count++;
  }    
  int[] Arr= new int[Count];

  while ( number!=0 )
  { 
    Arr[Count-1]=number%10;
    number/=10;
    Count--;
  }    
return Arr;
}
// сначала проверим на фиксированных числах
System.Console.WriteLine("135531 ?");
PrintIfPalindrom(IfPalindrom(NumberToArray(135531)));
System.Console.WriteLine("135431 ?");
PrintIfPalindrom(IfPalindrom(NumberToArray(135431)));
System.Console.WriteLine("125531 ?");
PrintIfPalindrom(IfPalindrom(NumberToArray(125531)));
System.Console.WriteLine("235531 ?");
PrintIfPalindrom(IfPalindrom(NumberToArray(235531)));


int Number;
System.Console.Write("Введите 6-значное число :  ");
// но можно и любое
Number = Convert.ToInt32(System.Console.ReadLine());
PrintIfPalindrom(IfPalindrom(NumberToArray(Number)));

