//проверка входных данных
using Test;

var cristmosTree = new CristmosTree();
bool isValidNumber = int.TryParse(Console.ReadLine(), out int number);

if (isValidNumber)
{
    Console.WriteLine(cristmosTree.GetHalfCristmosTreeRecording(number));
    Console.WriteLine(cristmosTree.GetCristmosTreeRecording(number));
}
else
    Console.WriteLine("В следующий раз введите число:)");

