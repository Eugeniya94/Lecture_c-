

int Max (int arg1, int arg2, int arg3)   // это функция
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;

    }
// index        0  1  2   3   4   5  6  7   8
int [] array = {1, 3, 5, 42, 50, 66, 7, 4, 95};

 //array[0] = 12; // присваивает индексу 0 значение 12. после текущего кода будет присвоено это значение

//Console.WriteLine(array[0]); // показывает значение по индексу.


int result /* или (max)*/ = Max (
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
    );
    
    
Console.WriteLine(result);




