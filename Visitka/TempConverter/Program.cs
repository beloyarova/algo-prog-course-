double celsius = 19.5;
const int F = 32;
const double K = 273.15;

double F1 = celsius * (9 / 5) + F;
double K1 = celsius + K;

Console.WriteLine($"{celsius}°C = {F1}°F = {K1}K");