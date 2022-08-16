
int[] strToCoord(string a)
{
    a = a.Replace(" ", "");
    string[] b = a.Split(",");
    int[] c = new int[3] ;
    for (int i = 0; i < 3; i++)
    {
        c[i] = Convert.ToInt32(b[i]);
    }
    return c;
}

double Distanse( int[] p1, int[] p2)
{
   double dist=0;
   for (int i = 0; i < 3; i++)
   {
    dist+= (p1[i]-p2[i])*(p1[i]-p2[i]);
   }
   return System.Math.Round(System.Math.Sqrt(dist),2);
}


Console.Write("Введите три кординаты первой точки через , :  ");
int[] point1 = strToCoord(Console.ReadLine());

Console.Write("Введите три кординаты второй точки через , :  ");
int[] point2 = strToCoord(Console.ReadLine());
System.Console.Write("Расстояние равно ");
System.Console.WriteLine(Distanse(point1, point2));

