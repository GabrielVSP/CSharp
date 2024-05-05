int[] age = [1, 2, 3];
int[,] s = new int[2, 2];
int[][] array = [[1, 2], [2], [3]];

//Single dimensional

int[] marks = new int[5] { 0, 0, 1, 5, 8};
marks[0] = 24;
marks[1] = 25;

foreach (int i in marks)
{
    Console.WriteLine(i);
}

Console.WriteLine("=============================");

//Multi dimensional

int[,] multi = new int[3, 4]
{
    { 1, 2, 3, 4},
    { 5, 6, 7, 8}, 
    { 9, 10, 11, 12 }, 
};
string oi = "aaaa";
Console.WriteLine(oi.Count());


for (int i = 0; i <= 2; i++)
{
    for (int j = 0; j <= 3; j++)
    {
        Console.Write(multi[i, j] + "\t");
    }

    Console.WriteLine();
}
