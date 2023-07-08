
//В войдах можно убрать результат и сократить строчки, но пока мне лень



//В войдах можно убрать результат и сократить строчки, но пока мне лень



Menu();

 



void Menu()

{

     Console.Clear();
        Console.WriteLine("Добро пожаловать в миниКалькулятор от Насти!");
        Console.WriteLine("Введите указанную цифру чтобы произвести вычисление:");
        Console.WriteLine("1 - Сложение");
        Console.WriteLine("2 - Вычитание");
        Console.WriteLine("3 - Умножение");
        Console.WriteLine("4 - Деление");
        Console.WriteLine("5 - Возведение в степень");
        int number = Convert.ToInt16(Console.ReadLine());

        switch(number)

        {
            case 1:

            Console.Clear();
            Addition();
            break;

            case 2:

            Console.Clear();
            Minus();
            break;

            case 3:

            Console.Clear();
            Um();
            break;

            case 4:

            Console.Clear();
            Del();
            break;

            case 5:

            Console.Clear();
            Step();
            break;



            default:

            Console.Clear();
                    Console.WriteLine("Принимаются - только указанные в меню числа");
                    Console.ReadLine();
                    break;

        }
}


void Addition ()
{
    Console.WriteLine("Введите первое число");
    double firstNumber = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    double secondNumber = Convert.ToDouble(Console.ReadLine());

    double result = firstNumber + secondNumber;

    Console.WriteLine($"Сумма числа {firstNumber} c числом {secondNumber} равняется {result}");
    
}

void Minus()

{

    Console.WriteLine("Введите первое число");
    double firstNumber = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите второе число");
   double secondNumber = Convert.ToDouble(Console.ReadLine());

    double result = firstNumber - secondNumber;

   

    Console.WriteLine($"Число, полученное при вычитании из числа {firstNumber} числа {secondNumber} равняется {result}");

}

void Um()
{
Console.WriteLine("Введите первое число");
    double firstNumber = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите второе число");
   double secondNumber = Convert.ToDouble(Console.ReadLine());

    double result = firstNumber * secondNumber;

    Console.WriteLine($"Умножение числа {firstNumber} и числа {secondNumber} равняется {result}");

}

void Del()

{

    Console.WriteLine("Введите первое число");
     double firstNumber = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    double secondNumber = Convert.ToDouble(Console.ReadLine());

    if(secondNumber == 0)
    {
        Console.WriteLine("Делить на ноль нельзя!");
    }


    else
    {

    double result = firstNumber / secondNumber;

    Console.WriteLine($"Деление числа {firstNumber} и числа {secondNumber} равняется {result}");
    }
}

void Step ()

{

    Console.WriteLine("Введите число");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Число {firstNumber} возведённое в степень {secondNumber} равняется " + Math.Pow(firstNumber,secondNumber));

}

