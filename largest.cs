public class Program
{
    public static void Main()
    {
        int[] myArr = {2,7,3,8,10,5};
        int largest = myArr[0];
        for (int i=0; i<myArr.Length; i++)
        {
            if(myArr[i] > largest)
                largest = myArr[i];
        }
        
        Console.Writeline(largest);
    }
}