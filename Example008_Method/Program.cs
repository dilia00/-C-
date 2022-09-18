int Max(int arg1, int arg2, int arg3)
{
    int resalt = arg1;
    if (arg2 > resalt) resalt = arg2;
    if (arg3 > resalt) resalt = arg3;
    return resalt;
}

int a1 = 15;
int b1 = 25;
int c1 = 13;
int a2 = 81;
int b2 = 4;
int c2 = 13;
int a3 = 18;
int b3 = 29;
int c3 = 11;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);
