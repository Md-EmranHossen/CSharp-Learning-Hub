int[] Intake = new int[4];

Intake[1] = 4;
Intake[2] = 6;
Intake[3] = 7;

int[] Section = [3, 4, 5, 6, 4, 3,];

foreach (int student in Intake)
{
    Console.WriteLine(student);
}

// 2D Array
int[,] grid = new int[2, 3];

grid[0, 0] = 1;
grid[1, 0] = 4;

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(grid[i, j] + " ");
    }
    Console.WriteLine();
}
