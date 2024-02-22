using System;

public class Division
{
	static int Div(int A, int B)
	{
        if (B == 0) {
            WriteLine("You can't divide by zero!");
            return 0;
        }
        return A / B;
    }
}
