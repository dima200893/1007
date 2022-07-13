Console.WriteLine("В введите последовательность чисел , разделяя каждое число запятой ");
string numbers =Console.ReadLine(); 
Console.WriteLine(numbers);
int count=0;
if (numbers[0] != '-'&& numbers[0]!='0')
    {
        count++;
    }
for(int i=0;i<numbers.Length;i++)
{
    if (numbers[i] == ',' && numbers[i + 1] != '-' && numbers[i + 1] != '0')
    {
        count++;
    }   
}
Console.WriteLine("В веденом диапазоне  "+ count + " чисел больше 0");