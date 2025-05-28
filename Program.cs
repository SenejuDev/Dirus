using System;


class Dirus
{
    static void Main()
    {
        Console.Title="Developer - SenejuDev v0.1";
            Console.WriteLine("Напишите /help");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Введите команду: ");

            string txt;

            txt = Console.ReadLine();

            switch (txt)
            {
                case "/help":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Команды: /table /test");
                    break;
                case "/table":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\tTable\n{Table.Present}\t{Table.Past}\t{Table.Participle+"(II)"}" +
                        $"\n{Pres.Become}\t{Pas.Became}\t{Pert.Become}\t{"-Становиться"}" +
                        $"\n{Pres.Begin}\t{Pas.Began}\t{Pert.Begun}\t{"-Начинать"}" +
                        $"\n{Pres.Break}\t{Pas.Broke}\t{Pert.Broken}\t{"-Ломать(ся)"}" +
                        $"\n{Pres.Bring}\t{Pas.Brought}\t{Pert.Bought}\t{"-Приносить"}" +
                        $"\n{Pres.Build}\t{Pas.Built}\t{Pert.Built}\t{"-Строить"}" +
                        $"\n{Pres.Buy}\t{Pas.Bought}\t{Pert.Bought}\t{"-Покупать"}" +
                        $"\n{Pres.Choose}\t{Pas.Chose}\t{Pert.Chosen}\t{"-Выбирать"}" +
                        $"\n{Pres.Come}\t{Pas.Came}\t{Pert.Come}\t{"-Приходить"}" +
                        $"\n{Pres.Cut}\t{Pas.Cut}\t{Pert.Cut}\t{"-Резать"}" +
                        $"\n{Pres.Do}\t{Pas.Did}\t{Pert.Done}\t{"-Делать"}" +
                        $"\n{Pres.Draw}\t{Pas.Drew}\t{Pert.Drawn}\t{"-Рисовать"}" +
                        $"\n{Pres.Drive}\t{Pas.Drove}\t{Pert.Driven}\t{"-Вести(машину)"}" +
                        $"\n{Pres.Fall}\t{Pas.Fell}\t{Pert.Fallen}\t{"-Падать"}" +
                        $"\n{Pres.Feel}\t{Pas.Felt}\t{Pert.Felt}\t{"-Чувствовать"}" +
                        $"\n{Pres.Find}\t{Pas.Found}\t{Pert.Found}\t{"-Находить"}" +
                        $"\n{Pres.Get}\t{Pas.Got}\t{Pert.Got}{"/"}{Pert.Gotten}\t{"-Получать"}" +
                        $"\n{Pres.Give}\t{Pas.Gave}\t{Pert.Given}\t{"-Давать"}" +
                        $"\n{Pres.Go}\t{Pas.Went}\t{Pert.Gone}\t{"-Идти"}" +
                        $"\n{Pres.Grow}\t{Pas.Grew}\t{Pert.Grown}\t{"-Расти"}" +
                        $"\n{Pres.Have}\t{Pas.Had}\t{Pert.Had}\t{"-Иметь"}" +
                        $"\n{Pres.Hear}\t{Pas.Heard}\t{Pert.Heard}\t{"-Слышать"}" +
                        $"\n{Pres.Hold}\t{Pas.Held}\t{Pert.Held}\t{"-Держать"}" +
                        $"\n{Pres.Keep}\t{Pas.Kept}\t{Pert.Kept}\t{"-Хранить"}" +
                        $"\n{Pres.Know}\t{Pas.Knew}\t{Pert.Known}\t{"-Знать"}" +
                        $"\n{Pres.Leave}\t{Pas.Left}\t{Pert.Left}\t{"-Оставлять"}" +
                        $"\n{Pres.Let}\t{Pas.Let}\t{Pert.Let}\t{"-Позволять"}" +
                        $"\n{Pres.Lie}\t{Pas.Lay}\t{Pert.Lain}\t{"-Лежать"}" +
                        $"\n{Pres.Lose}\t{Pas.Lost}\t{Pert.Lost}\t{"-Терять"}" +
                        $"\n{Pres.Make}\t{Pas.Made}\t{Pert.Made}\t{"-Делать(изготовлять)"}" +
                        $"\n{Pres.Mean}\t{Pas.Meant}\t{Pert.Meant}\t{"-Означать"}" +
                        $"\n{Pres.Meet}\t{Pas.Met}\t{Pert.Met}\t{"-Встречать"}" +
                        $"\n{Pres.Pay}\t{Pas.Paid}\t{Pert.Paid}\t{"-Платить"}" +
                        $"\n{Pres.Put}\t{Pas.Put}\t{Pert.Put}\t{"-Класть"}" +
                        $"\n{Pres.Read}\t{Pas.Read}\t{Pert.Read}\t{"-Читать"}" +
                        $"\n{Pres.Rise}\t{Pas.Rose}\t{Pert.Risen}\t{"-Поднимать(ся)"}" +
                        $"\n{Pres.Run}\t{Pas.Ran}\t{Pert.Run}\t{"-Бежать"}" +
                        $"\n{Pres.Say}\t{Pas.Said}\t{Pert.Said}\t{"-Говорить"}" +
                        $"\n{Pres.See}\t{Pas.Saw}\t{Pert.Seen}\t{"-Видеть"}" +
                        $"\n{Pres.Set}\t{Pas.Set}\t{Pert.Set}\t{"-Устанавливать"}" +
                        $"\n{Pres.Show}\t{Pas.Showed}\t{Pert.Shown}\t{"-Показывать"}" +
                        $"\n{Pres.Sit}\t{Pas.Sat}\t{Pert.Sat}\t{"-Сидеть"}" +
                        $"\n{Pres.Speak}\t{Pas.Spoke}\t{Pert.Spoken}\t{"-Разговаривать"}" +
                        $"\n{Pres.Spend}\t{Pas.Spent}\t{Pert.Spent}\t{"-Тратить"}" +
                        $"\n{Pres.Stand}\t{Pas.Stood}\t{Pert.Stood}\t{"-Стоять"}" +
                        $"\n{Pres.Take}\t{Pas.Took}\t{Pert.Taken}\t{"-Брать"}" +
                        $"\n{Pres.Tell}\t{Pas.Told}\t{Pert.Told}\t{"-Рассказывать"}" +
                        $"\n{Pres.Think}\t{Pas.Thought}\t{Pert.Thought}\t{"-Думать"}" +
                        $"\n{Pres.Wear}\t{Pas.Wore}\t{Pert.Worn}\t{"-Надевать"}" +
                        $"\n{Pres.Write}\t{Pas.Wrote}\t{Pert.Written}\t{"-Писать"}");
                    break;
                case "/test":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Is not test");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Is not command");
                    break;
            }
        }
         Console.ReadLine();
    }

    enum Table
    {
        Present,
        Past,
        Participle
    }

    enum Pres
    {
        Become,
        Begin,
        Break,
        Bring,
        Build,
        Buy,
        Choose,
        Come,
        Cut,
        Do,
        Draw,
        Drive,
        Fall,
        Feel,
        Find,
        Get,
        Give,
        Go,
        Grow,
        Have,
        Hear,
        Hold,
        Keep,
        Know,
        Leave,
        Let,
        Lie,
        Lose,
        Make,
        Mean,
        Meet,
        Pay,
        Put,
        Read,
        Rise,
        Run,
        Say,
        See,
        Send,
        Set,
        Show,
        Sit,
        Speak,
        Spend,
        Stand,
        Take,
        Tell,
        Think,
        Wear,
        Write
    }

    enum Pas
    {
        Became,
        Began,
        Broke,
        Brought,
        Built,
        Bought,
        Chose,
        Came,
        Cut,
        Did,
        Drew,
        Drove,
        Fell,
        Felt,
        Found,
        Got,
        Gave,
        Went,
        Grew,
        Had,
        Heard,
        Held,
        Kept,
        Knew,
        Left,
        Let,
        Lay,
        Lost,
        Made,
        Meant,
        Met,
        Paid,
        Put,
        Read,
        Rose,
        Ran,
        Said,
        Saw,
        Sent,
        Set,
        Showed,
        Sat,
        Spoke,
        Spent,
        Stood,
        Took,
        Told,
        Thought,
        Wore,
        Wrote
    }

    enum Pert
    {
        Become,
        Begun,
        Broken,
        Broughr,
        Built,
        Bought,
        Chosen,
        Come,
        Cut,
        Done,
        Drawn,
        Driven,
        Fallen,
        Felt,
        Found,
        Got,Gotten,
        Given,
        Gone,
        Grown,
        Had,
        Heard,
        Held,
        Kept,
        Known,
        Left,
        Let,
        Lain,
        Lost,
        Made,
        Meant,
        Met,
        Paid,
        Put,
        Read,
        Risen,
        Run,
        Said,
        Seen,
        Sent,
        Set,
        Shown,
        Sat,
        Spoken,
        Spent,
        Stood,
        Taken,
        Told,
        Thought,
        Worn,
        Written
    }
}