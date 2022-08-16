void PrintIfPalindrom(bool Yes) 
{
   if (Yes)
    System.Console.WriteLine("Да, это палиндром.");
  else  
    System.Console.WriteLine("Нет, не палиндром.");
}     


// программа работает со сторокой любой длины
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
  
  while ( Flag & shift <= middle -even )
     { 
      
        if ( arr[middle+shift]!=arr[middle-shift-even])
           Flag = false;
        shift ++;   

     }
  
  return Flag;
}

int[] NumberToArray(int number)
{
  int count =0;
  

}

int[] NumberArray = new int[6];
int Number;
System.Console.Write("Введите 6-значное число :  ");
Number = Convert.ToInt32(System.Console.ReadLine());
if (Number.Length == 6)
   PrintIfPalindrom(IfPalindrom(Number));
else    
   System.Console.Write("");
