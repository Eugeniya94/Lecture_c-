int [] array = {1, 3, 5, 42, 50, 66, 5, 7, 4, 95};

int n = array.Length;
int find = 5;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // оператор нужен, когда в массиве несколько одинаковых искомых элементов.
                // он прерывает цикл при нахождении первого нужного элемента.
    }
    index++;
}