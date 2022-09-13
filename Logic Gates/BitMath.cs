namespace Logic_Gates;

public static class BitMath
{
    public static BitsAdderOutput TwoBitsAdder(bool bit1, bool bit2, bool carry = false)
    {
        bool firstXOR = LogicGates.Xor(bit1, bit2);

        bool result = LogicGates.Xor(firstXOR, carry);

        bool carryOut = LogicGates.Or(LogicGates.And(firstXOR, carry), LogicGates.And(bit1, bit2));

        return new BitsAdderOutput(new bool[] { result }, carryOut);
    }

    public static BitsAdderOutput FourBitsAdder(bool[] firstBits, bool[] secondBits, bool carry = false)
    {
        bool[] bitsOutput = new bool[4];

        var res1 = TwoBitsAdder(firstBits[0], secondBits[0], carry);
        var res2 = TwoBitsAdder(firstBits[1], secondBits[1], res1.Carry);
        var res3 = TwoBitsAdder(firstBits[2], secondBits[2], res2.Carry);
        var res4 = TwoBitsAdder(firstBits[3], secondBits[3], res3.Carry);

        bitsOutput[0] = res1.BitsOutput[0];
        bitsOutput[1] = res2.BitsOutput[0];
        bitsOutput[2] = res3.BitsOutput[0];
        bitsOutput[3] = res4.BitsOutput[0];

        return new BitsAdderOutput(bitsOutput, res4.Carry);
    }

    public readonly struct BitsAdderOutput
    {
        public BitsAdderOutput(bool[] output, bool carry)
        {
            BitsOutput = output;
            Carry = carry;
        }

        public readonly bool[] BitsOutput;

        public readonly bool Carry;

        public int DecimalOutput => BitsConverter.BitsArrayToInt(BitsOutput);
    }
}