// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите желаемые цифры:");
int numb= Convert.ToInt32(Console.ReadLine());
int count = 1;
int number=numb;
int result=0;
while((number /= 10)>1)
{
    ++count;
}
//Consile.WriteLine(count);//
if (count<3)
{
    //Console.WriteLine("Третья цифра осутствует");
}
else if (count == 3)
    {
        result = numb % 10;
        Console.WriteLine(result);
    }

    else
    {
        int c = 1;
        for (int i = count; i > 3; i--)
        {
            c = c * 10;
        }
        result = (numb / c) % 10;
        Console.WriteLine(result);    
    }    

