//проверка входных данных
if (int.TryParse(Console.ReadLine(), out int number)) { }
else Console.WriteLine("В следующий раз введите число:)");

#region Половинка елки
string tree = "";
for (int i = 0; i < number; i++)
{
    tree += "*";
    Console.WriteLine(tree);
}
#endregion

#region Целиковая елка
int decrementNumber = number;
string secondTree = "*";
string secondTreeHelper = "";

for (int i = 0; i < number; i++)
{
    for (int j = 0; j < decrementNumber; j++)
    {
        secondTreeHelper += " ";
    }
    Console.WriteLine(secondTreeHelper + secondTree);
    secondTree += "**";
    decrementNumber--;
    secondTreeHelper = "";
}
#endregion