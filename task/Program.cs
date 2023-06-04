Console.WriteLine("Введите номер задачи (47, 50, 52):");
int taskNumber = Convert.ToInt32(Console.ReadLine());
switch (taskNumber)
{
    case 47:
        TaskNumber47();
        break;

    case 50:
        TaskNumber50();
        break;

    case 52:
        TaskNumber52();
        break;    
   
    default:
        Console.WriteLine("Вы ввели неверный номер");
        break;

}

void TaskNumber47()
{
    Console.WriteLine();

    Console.WriteLine("Введите длину массива :");
    int arrayLenght = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите высоту массива :");
    int arrayHeight = Convert.ToInt32(Console.ReadLine());

    double[,] array2d = new double[arrayLenght,arrayHeight];
    for (int i=0; i<array2d.GetLength(0); i++)
    {
        for (int j=0; j<array2d.GetLength(1); j++)
        {
            double numRandom = new Random().NextDouble()* new Random().Next(0,10);
            array2d[i,j] = Math.Round(numRandom, 2);
            Console.Write(array2d[i,j] +" ");
        }
        Console.WriteLine();
    }

}


void TaskNumber50()
{
    Console.WriteLine();

    Console.Write("Введите длину массива: ");
    int arrayLenght = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите высоту массива: ");
    int arrayHeight = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите искомое число: ");
    int numFind = Convert.ToInt32(Console.ReadLine());

    int[,] array2d = new int[arrayLenght,arrayHeight];
    int indexL = 0;
    int indexH = 0;
    for (int i=0; i<array2d.GetLength(0); i++)
    {
        for (int j=0; j<array2d.GetLength(1); j++)
        {
            int numRandom = new Random().Next(0,10);
            array2d[i,j] = numRandom;
            Console.Write(array2d[i,j] +" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine( new String('-', arrayLenght*2));

    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (numFind == array2d[i,j])
            {
                indexH = j + 1;
                indexL = i + 1;
                Console.WriteLine($"Позиция числа {numFind} строка/столбец: {indexL},{indexH}");
            }           
        }    
    }  
    if (indexH==0) Console.WriteLine($"Число {numFind} в массиве не найдено");    
}


void TaskNumber52()
{
    Console.WriteLine();

    Console.Write("Введите длину массива: ");
    int arrayLenght = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите высоту массива: ");
    int arrayHeight = Convert.ToInt32(Console.ReadLine());
   
    int[,] array2d = new int[arrayHeight,arrayLenght];
    for (int i=0; i<array2d.GetLength(0); i++)
    {
        for (int j=0; j<array2d.GetLength(1); j++)
        {
            int numRandom = new Random().Next(0,10);
            array2d[i,j] = numRandom;
            Console.Write(array2d[i,j] +" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine( new String('-', arrayLenght*2));

    double[] arrayTemp = new double[arrayLenght];
    int temp = 0;
    int k = 0;
    double numSum = 0;
    double midSum = 0;
        
    while(k<arrayLenght)
    {
        for (int i=0; i<array2d.GetLength(1); i++)
        {
        
            for (int j=0; j<array2d.GetLength(0); j++)
            {
                temp = array2d[j, i];
                numSum = temp + numSum;
                
            }
            midSum = numSum / arrayHeight;
            arrayTemp[k] = Math.Round(midSum, 2);
            Console.WriteLine($"среднее значение столбца {k + 1} = {Math.Round(midSum, 2)}");
            midSum = 0;
            numSum = 0;
            k++;
        }
    
     }

    Console.WriteLine($"Массив полученых чисел: ({string.Join(", ",arrayTemp)})");

    return;

}
