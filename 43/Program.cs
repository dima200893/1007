double b1=InputInt("Введите число b1=");
double k1=InputInt("Введите число k1=");
double b2=InputInt("Введите число b2=");
double k2=InputInt("Введите число k2=");
//уравнения прямой 1 y=k1*x+b1 уравнение прямой 2 y=k2*x+b2 
//решив систему вычисляем чему равен x и y
double x=(b2-b1)/(k1-k2);
double y=k1*x+b1;
if(k1*x+b1-y!=k2*x+b2-y)
{
  Console.WriteLine("Точки пересечения нет");
}
else
{
Console.WriteLine("Точка пересечения двух прямых имеет координаты " + "{" + x +";"+ y + "}");
}

double InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToDouble(Console.ReadLine());
}