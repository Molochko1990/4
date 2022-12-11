int[] arr = new int[8];
Random rand = new Random();
int Def(int a)
{
    return arr[a];
}
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0,10);
    Console.Write(Def(i) + " "); 
}

// for (int i = 0; arr.Length > i; i++)
// {
//     Console.WriteLine(arr[i]); 
// }
