using System.Reflection.Metadata.Ecma335;

bool HasMinLength(string password, int minLength)
{
    return password.Length >= minLength;
}

bool HasDigit(string password)
{
    foreach (char letter in password)
    {
        if (char.IsDigit(letter))
        {
            return true;
        }
    }
    return false;
}

bool HasUpperCase(string password)
{
    foreach (char letter in password)
    {
        if (char.IsUpper(letter))
        {
            return true;
        }
    }
    return false;
}

bool IsPasswordValid(string password)
{
    return HasMinLength(password, 8) && HasDigit(password) && HasUpperCase(password);
}

Console.WriteLine("Введите пароль: ");
string password = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"Длина >= 8: {HasMinLength(password, 8)}");
Console.WriteLine($"Есть цифра: {HasDigit(password)}");
Console.WriteLine($"Есть заглавная буква: {HasUpperCase(password)}");
Console.WriteLine();
Console.WriteLine($"Пароль верный: {IsPasswordValid(password)}");