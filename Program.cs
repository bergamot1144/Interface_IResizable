








ResizableArray ra = new ResizableArray();
Console.WriteLine("Initial size: " + ra.GetSize());

ra.Resize(2.0);
Console.WriteLine("Size after resize (factor 2.0): " + ra.GetSize());








interface IResizable
{
    void Resize(double factor);
    int GetSize();
}

public class ResizableArray : IResizable
{
    public static int SIZE = 5;
    private int[] numbers;
    public ResizableArray()
    { 
        numbers = new int[SIZE];
    }
    

    public void Resize(double factor)
    {
        int newSize = (int)(numbers.Length * factor);

        int[] newNumbers = new int[newSize];

        for (int i = 0; i < newNumbers.Length && i < numbers.Length; i++)
        {
            newNumbers[i] = numbers[i];
        }

        numbers = newNumbers;
    }



    public int GetSize()
    {
       return numbers.Length;
    }
}
 


















