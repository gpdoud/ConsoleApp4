using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4;

internal class TQL {

    public int SecredNumber { get; set; }

    public void DisplayClassname() {
        Console.WriteLine($"Classname is TQL; SecretNumber is {SecredNumber}");
    }

    public int RandomizeSecretNumber(int RandomNumber) {
        SecredNumber *= RandomNumber;
        return SecredNumber;
    }

}
