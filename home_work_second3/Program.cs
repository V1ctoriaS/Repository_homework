// See https://aka.ms/new-console-template for more information

{
    Console.WriteLine ("Введите цифру от 1 до 7");
    int dayofweek = int.Parse (Console.ReadLine());
    if (dayofweek == 6 || dayofweek == 7) Console.WriteLine ("Ответ: Выходной день.");
    else if (dayofweek <= 5) Console.WriteLine ("Ответ: Будний день.");
    else if (dayofweek > 7) Console.WriteLine ("Ошибка: В неделе всего 7 дней!");
}
