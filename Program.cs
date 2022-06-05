class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите номер задания (нумерация начинается с 1):");
        string lesson = Console.ReadLine();
        try
        {
            int lesson_int = Convert.ToInt32(lesson);
            switch (lesson_int)
            {
                case 1:
                    string number;
                    for (; ; )
                    {
                        Console.WriteLine("Введите число");
                        number = Console.ReadLine();
                        try
                        {
                            int numberint = Convert.ToInt32(number);
                            int modulo = numberint % 2;
                            switch (modulo)
                            {
                                case 0:
                                    Console.WriteLine("Число {0} чётное", numberint);
                                    break;
                                case 1:
                                    Console.WriteLine("Число {0} нечётное", numberint);
                                    break;
                                case -1:
                                    Console.WriteLine("Число {0} нечётное", numberint);
                                    break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Число не распознано Повторите попытку\n");
                        }
                        Console.WriteLine("Нажмите ESC для выхода\nДля подолжения нажмите любую другу кнопку.");
                        if(Console.ReadKey(true).Key == ConsoleKey.Escape) break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Добрый день!\nдля подсчёта суммы карт введите количество карт в руке");
                    for (; ; )
                    {
                        string count;
                        count = Console.ReadLine();
                        try
                        {
                            int count_int = Convert.ToInt32(count);
                            int Cards = 0;
                            for(int i=0;i<count_int;i++)
                            {
                                Console.WriteLine("Введите номинал карты");
                                string card = Console.ReadLine();
                                try
                                {
                                    int card_int = Convert.ToInt32(card);
                                    if (card_int > 1 && card_int < 11)
                                    {
                                        Cards += card_int;
                                    }
                                    else
                                    {
                                        Console.WriteLine("карта введена неверно, повторите попытку");
                                        i--;//необходимо, чтобы ошибочный ввод не засчитался
                                    }
                                }
                                catch
                                {
                                    if (card == "A" || card == "a" 
                                        || card == "T" || card == "t"
                                        || card == "J" || card == "j"
                                        || card == "Q" || card == "q"
                                        || card == "K" || card == "k") //перечислил все возможные обозначения картинок буквами
                                        Cards += 10;
                                    else
                                    {
                                        Console.WriteLine("карта введена неверно, повторите попытку");
                                        i--;//необходимо, чтобы ошибочный ввод не засчитался
                                    }

                                }
                            }
                            Console.WriteLine("Сумма карт равна {0}", Cards);

                        }
                        catch
                        {
                            Console.WriteLine("число введено не корректно, введите корректное число");
                        }
                        Console.WriteLine("Для еще одного расчёта нажмите любую клавишу\nдля выхода нажмите ESC");
                        if (Console.ReadKey(true).Key == ConsoleKey.Escape) break;
                    }
                    break;
                case 3:                  
                    string number_string;
                    for (; ; )
                    {
                        Console.WriteLine("Введите число, которое необходимо проверить на простоту");
                        number_string = Console.ReadLine();
                        int number_int;
                        try
                        {
                            number_int = Convert.ToInt32(number_string);
                            bool cheker = false;
                            for (int i = 2; i < number_int / 2; i++)   //поделил переменную на два, т.к. 2 наименьшим делителем для простых чисел, 
                            {
                                if (number_int % i == 0)            //а следовательно для разложения на простые множители наибольшим может быть число вдвое меньше проверяемого.
                                {
                                    cheker = true;
                                    break;              //break использую, т.к. если нашлось одно число, на которое number_int делится без остатка, то ответ очевиден
                                }
                            }
                            if (cheker)
                            {
                                Console.WriteLine("Число {0} не является простым",number_int);
                            }
                            else
                            {
                                Console.WriteLine("Число {0} является простым",number_int);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Число введено неверно");
                        }
                        Console.WriteLine("Для еще одной проверки нажмите любую клавишу\nдля выхода нажмите ESC");
                        if(Console.ReadKey(true).Key== ConsoleKey.Escape) break;
                    }
                    break;
                default:
                    Console.WriteLine("номер задания введён неверно");
                    Console.ReadKey();
                    break;
            }
        }
        catch
        {
            Console.WriteLine("номер задания введён неверно");
            Console.ReadKey();
        }


    }
}