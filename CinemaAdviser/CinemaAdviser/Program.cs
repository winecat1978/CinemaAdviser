namespace CinemaAdviser
{
    class Program
    {
        static void Main ( string [] args )
        {
            Console.WriteLine("Эта программа поможет подобрать вам фильм для вечернего просмотра");
            Console.WriteLine("Как вас зовут?");
            String name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name);

            Console.WriteLine("Фильм какого жанра вы бы хотели посмотреть: комедия, боевик, драма, мультик, мюзикл, артхаус, мелодрама, фантастика?");
            String genre = Console.ReadLine();

            Console.WriteLine("В таком случае, рекомендую вам следующие фильмы: ");
            if (genre == "комедия")
            {
                Console.WriteLine("Гараж");
                Console.WriteLine("Назад в будущее");
                Console.WriteLine("1+1");
                Console.WriteLine("Тот самый Мюнхгаузен");
            }
            else if (genre == "драма")
            {
                Console.WriteLine("Титаник");
                Console.WriteLine("Гений");
                Console.WriteLine("Хатико");
            }
            else if (genre == "мюзикл")
            {
                Console.WriteLine("Вест-сайдская история");
                Console.WriteLine("Мама Миа!");
                Console.WriteLine("Призрак оперы");
            }
            else if (genre == "артхаус")
            {
                Console.WriteLine("Догвилль");
                Console.WriteLine("Зеркало");
                Console.WriteLine("Трудно быть Богом");
            }
            else if (genre == "боевик")
            {
                Console.WriteLine("Заложница");
                Console.WriteLine("Кингсман");
                Console.WriteLine("Матрица");
            }
            else if (genre == "мелодрама")
            {
                Console.WriteLine("Гордость и предубеждение");
                Console.WriteLine("Неадекватные люди");
                Console.WriteLine("Легкое поведение");
            }
            else if (genre == "мультик")
            {
                Console.WriteLine("Душа");
                Console.WriteLine("Бесподобный мистер Фокс");
                Console.WriteLine("Коралина в стране кошмаров");
            }
            else if(genre == "фантастика")
            {
                Console.WriteLine("Гарри Поттер");
                Console.WriteLine("Дюна");
            }
            else
            {
                Console.WriteLine("Отель Гранд Будапешт");
                Console.WriteLine("Король говорит");
                Console.WriteLine("Остров собак");
            }
            Console.ReadLine();
        }
    }
}
