namespace Logic_Gates;

public static class BitsConverter
{
    public static int BitToInt(bool bit) => bit ? 1 : 0;

    public static bool IntToBit(int num) => num == 1 || (num == 0 ? false : throw new ArgumentException($"Number {num} is not bit"));

    public static int BitsArrayToInt(bool[] array)
    {
        int result = 0;

        for (int i = 0; i < array.Length; i++)
        {
            result += BitToInt(array[i]) * (int)Math.Pow(2, i);
        }

        return result;
    }
}