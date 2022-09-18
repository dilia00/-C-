
int Max(int arg1, int arg2, int arg3)
{
    int resalt = arg1;
    if (arg2 > resalt) resalt = arg2;
    if (arg3 > resalt) resalt = arg3;
    return resalt;
}

int[] array = {15,22,3,42,54,116,7,18,29};


int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
    );
Console.WriteLine(max);
