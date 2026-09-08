// See https://aka.ms/new-console-template for more information
string name1 = "Белоярова Александра Алексеевна";
string name2 = "Алексеевская Елена Александровна";
string groop = "ИСП-251";
int course = 2;
string specialty = "09.02.07";

double ball1 = 4.0;
double ball2 = 4.5;
double ball3 = 4.9;
const double min_ball = 4.0;
double sred_ball = (ball1 + ball2 + ball3) / 3.0;

bool grant = sred_ball >= min_ball;

int weeks = 16;

Console.WriteLine($"ФИО первого ученика:    {name1}");
Console.WriteLine($"ФИО второго ученика:    {name2}");
Console.WriteLine($"Группа:                 {groop}");
Console.WriteLine($"Курс:                   {course}");
Console.WriteLine($"Специальность: {specialty}");
Console.WriteLine();
Console.WriteLine($"Средний балл за 3 работы: {sred_ball}");
Console.WriteLine($"Стипендия положена (>= 4.0): {grant}");
Console.WriteLine();
Console.WriteLine($"Учебных недель осталось в семестре: {weeks}");

