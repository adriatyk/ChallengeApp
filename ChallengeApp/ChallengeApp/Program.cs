int number = 14374;
string numberInString = number.ToString();
char[] digitsNumber = numberInString.ToArray();
char[] digits = new char[10];
digits[0] = '0';
digits[1] = '1';
digits[2] = '2';
digits[3] = '3';
digits[4] = '4';
digits[5] = '5';
digits[6] = '6';
digits[7] = '7';
digits[8] = '8';
digits[9] = '9';

Console.WriteLine("Wyniki dla liczby: " + number);

foreach (char digit1 in digits)
{
    int n = 0;
    foreach (char digit2 in digitsNumber)
    {
        if (digit1 == digit2)
        {
            n++;
        }
    }
    Console.WriteLine(digit1 + " => " + n);
}
