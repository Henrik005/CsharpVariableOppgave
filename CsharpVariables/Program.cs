// See https://aka.ms/new-console-template for more information
int number = 100;
double commaSepperated = 5.5;
long manyNumbers = 99999999l;
float highPrecisionNum = 6.6f;
decimal veryHighPrecisionNum = 7.7m;
string txtString = "Yo yo, what is up?";
char singleCharacter = 'E';
bool trueAndFalse = false;


 decimal CombineNumbers()
{
    int a = 5;
    decimal b = 3m;
    decimal sum = a + b;
    return sum;
}
Console.Write($"{CombineNumbers()}");