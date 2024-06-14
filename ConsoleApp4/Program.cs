namespace ConsoleApp4;

internal class Program {

    static void Main( string[] args) {

        TQL tql = new TQL { SecredNumber = 1 };
        tql.SecredNumber = 1;
        tql.DisplayClassname();
        var newSecretNumber = tql.RandomizeSecretNumber(321);
        Console.WriteLine($"newSecretNumber is {newSecretNumber}");
        tql.DisplayClassname();
    }
}
