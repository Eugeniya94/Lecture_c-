
// FillArray - название метода. нужен для заполнения массива.
// collection- название аргумента для обозначения массива
void FillArray(int[] collection){

        int length = collection.Length;
        int index = 0;

        while(index < length){

            collection[index] = new Random().Next(1, 10);
            index++;
        }

}

// PrintArray - нужна для печати массива. 
// col тот же collection. массивы нужно называть по разному, чтобы не запутаться
// VOID - (есть методы которые возвращают значения(return),а есть те , которые не возвращают.)
// void относится к тем, которые не возвращают.
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count){
         
         Console.WriteLine(col[position]);
         position++;
    }

}


//  int[]collection, int find - аргументы
//IndexOf- название метода дя поиска числа.
int IndexOf (int[]collection, int find)
{

    int count = collection.Length;
    int index = 0;
    int position = -1; // если элемента нет, вернется -1

    while(index < count){
        
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
} 
                                        
int [] array = new int [10]; // (вызвали массив из 10 элементов) new int [10] - создай новый массив, в котором будет 10 элементов.
                            // по умолчанию он бцдет заполнен нулями.

FillArray(array); // заполнил массив cлучайными числами
PrintArray(array); // распечатает результат                         
Console.WriteLine();

int pos = IndexOf(array, 45);
Console.WriteLine(pos);



