//проверка входных данных
using Test;

CristmosTree cristmosTree = new CristmosTree();
bool isValidNumber = int.TryParse(Console.ReadLine(), out int number);

if (isValidNumber)
{
    Console.WriteLine(cristmosTree.HalfCristmosTreeRecording(number));
    Console.WriteLine(cristmosTree.CristmosTreeRecording(number));
}
else
    Console.WriteLine("В следующий раз введите число:)");

