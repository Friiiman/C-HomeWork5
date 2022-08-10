// ------------- ЗАДАЧИ -------------
// ----------------------------------

void Task1(){

    // Задайте массив заполненный случайными положительными трёхзначными числами. 
    // Напишите программу, которая покажет количество чётных чисел в массиве.

    Console.Write("Задайте длинну массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    FillArray(array, 100, 999);
    PrintArray(array);
    EvenNumber(array);
}

void Task2(){

    // Задайте одномерный массив, заполненный случайными числами. 
    // Найдите сумму элементов, стоящих на нечётных позициях.

    Console.Write("Задайте длинну массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    SumOddIndexNumber(array);

}

void Task3(){

    // Задайте массив вещественных чисел. 
    // Найдите разницу между максимальным и минимальным элементов массива.

    Console.Write("Задайте длинну массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];
    FillArrayDouble(array, -100, 100);
    PrintArrayDouble(array);
    DifMinMaxDouble(array);
}

// ------------- МЕТОДЫ -------------
// ----------------------------------

void FillArray(int[] array, int startNumber = 0, int finishNumber = 100){
    finishNumber++;
    int size = array.Length;
    Random random = new Random();

    for(int i = 0; i < size; i++){
        array[i] = random.Next(startNumber, finishNumber);
    }
}

void PrintArray(int[] array){
    int size = array.Length;

    for(int i = 0; i < size; i++){
        Console.Write(array[i] + ", ");
    }
    Console.Write("\b\b.");
    Console.WriteLine();
}

void FillArrayDouble(double[] array, int startNumber = 0, int finishNumber = 100){
    int size = array.Length;
    Random random = new Random();

    for(int i = 0; i < size; i++){
        array[i] = Math.Round(random.Next(startNumber, finishNumber) + random.NextDouble(), 2);
    }
}

void PrintArrayDouble(double[] array){
    int size = array.Length;

    for(int i = 0; i < size; i++){
        Console.Write(array[i] + ", ");
    }
    Console.Write("\b\b.");
    Console.WriteLine();
}

void DifMinMaxDouble(double[] array){
    int size = array.Length;
    int maxPosition = 0;
    int minPosition = 0;

    for(int i = 0; i < size; i++){
        if(array[i] < array[minPosition]){
            minPosition = i;
        }
    }

    for(int i = 0; i < size; i++){
        if(array[i] > array[maxPosition]){
            maxPosition = i;
        }
    }

    double result = Math.Round(array[maxPosition] - array[minPosition], 2);
    Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + result);
}

void EvenNumber(int[] array){
    int size = array.Length;
    int result = 0;

    for(int i = 0; i < size; i++){
        if(array[i] % 2 == 0){
            result++;
        }
    }

    Console.WriteLine("Колличество чётных чисел в массиве: " + result);
}

void SumOddIndexNumber(int[] array){
    int size = array.Length;
    int sum = 0;

    for(int i = 0; i < size; i += 2){
        sum += array[i];
    }

    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);
}

// ------------- ВЫВОД РЕШЕНИЯ ЗАДАЧ -------------
// -----------------------------------------------

Task1();
// Task2();
// Task3();
