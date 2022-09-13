using Logic_Gates;

bool[] firstNumberBits = { false, true, true, true };
int firstNumberDecimal = BitsConverter.BitsArrayToInt(firstNumberBits);

bool[] secondNumberBits = { false, false, false, true };
int secondNumberDecimal = BitsConverter.BitsArrayToInt(secondNumberBits);

var bitsAddingResult = BitMath.FourBitsAdder(firstNumberBits, secondNumberBits);

Console.WriteLine($"{firstNumberDecimal} + {secondNumberDecimal} = {bitsAddingResult.DecimalOutput} ({firstNumberDecimal + secondNumberDecimal})");

Console.WriteLine();
PrintBitsArray(firstNumberBits);
PrintBitsArray(secondNumberBits);
Console.WriteLine("----------------");
PrintBitsArray(bitsAddingResult.BitsOutput);

static void PrintBitsArray(bool[] array)
{
    Console.Write("[ ");

    foreach (bool bit in array)
        Console.Write(BitsConverter.BitToInt(bit) + ", ");

    Console.WriteLine(" ]");
}