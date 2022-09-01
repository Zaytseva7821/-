System.Console.WriteLine("Вас приветствует Анастасися Викторовна!");
System.Console.WriteLine("Представься, пожалуйста");
if (Console.ReadLine() == "Тая")
{
    System.Console.WriteLine("Очень приятно, Папайя");
}
else
{
   System.Console.WriteLine("Наверно, вы имели ввиду Тая, да?");
   string answer = Console.ReadLine();
    while (answer.ToLower() != "да")
    {
    System.Console.WriteLine("Подумайте еще раз");
    answer = Console.ReadLine();
    }
    System.Console.WriteLine("Очень приятно, Папайя");
}
System.Console.WriteLine("Хотите ли вы немного скрасить ваш день?");
string answer1 = Console.ReadLine();
    while (answer1.ToLower() != "да")
    {
    System.Console.WriteLine("Вам стоит подумать еще");
    answer1 = Console.ReadLine();
    }
   System.Console.WriteLine("Я пока не знаю, можно ли сюда вообще вставлять картинки, поэтому просто откройте фото hehe.jpg");