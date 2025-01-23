void Triple(ref int x)
{
    x *= 3;
}


int a = 10;
Triple(ref a);
Console.WriteLine(a);