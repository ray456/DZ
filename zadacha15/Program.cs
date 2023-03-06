Console.WriteLine("Введите число > ");
int number = Convert.ToInt32(Console.ReadLine());
// if (number > 7)
// {
//     Console.WriteLine("Это не день недели");
// }
if (number > 5 && number <= 7)
{
   
    Console.WriteLine("Выходной день");

}
else 
{
    Console.WriteLine("Рабочий день");
}