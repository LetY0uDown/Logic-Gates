namespace Logic_Gates;

public class LogicGates
{
    private LogicGates() { }

    public static bool Not(bool bit) => !bit;

    public static bool And(bool bit1, bool bit2) => bit1 && bit2;    

    public static bool Nand(bool bit1, bool bit2) => Not(And(bit1,
                                                             bit2));

    public static bool Or(bool bit1, bool bit2) => Nand(Not(bit1),
                                                        Not(bit2));

    public static bool Nor(bool bit1, bool bit2) => Not(Or(bit1, bit2));

    public static bool Xor(bool bit1, bool bit2) => Or(And(Not(bit1),
                                                           bit2),
                                                       And(bit1,
                                                           Not(bit2)));

    public static bool Xnor(bool bit1, bool bit2) => Not(Xor(bit1, bit2));
}