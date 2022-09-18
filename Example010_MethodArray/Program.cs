int[] array = {15,22,3,42,54,116,7,18,29};
int n = array.Length;
int find = 3;
int index = 0;
while (index < n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}