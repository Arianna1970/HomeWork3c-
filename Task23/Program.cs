void PrintCubes(int N)
{
  System.Console.Write($"{N} =>");   
  for (int i = 1; i <= N ; i++)
  {
      System.Console.Write($"{i*i*i}"); 
      if ( i<N) 
         System.Console.Write(", ");
  }      
 
 }  

int N;
System.Console.Write("Input N = ");
N = Convert.ToInt32(System.Console.ReadLine());
PrintCubes(N);