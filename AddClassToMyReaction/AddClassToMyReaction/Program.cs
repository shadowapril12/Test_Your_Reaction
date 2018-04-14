using System;
using System.Threading;
namespace AddClassToMyReaction
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Создание экземпляра класса Test
            Test obj = new Test();

            ///Интервал времени, использующийся для задержки
            int interval = obj.MountRandomInterval();

            while(true)
            {
                Thread.Sleep(interval);
                obj.StartTest();
            }
        }
    }

    class Test
    {
        /// <summary>
        /// Публичный метод MountRandom принимает с консоли параметры, являющимися начальным и конечным
        /// значениями, в интервали между каторыми будет браться рандомное число, означающее задержку перед
        /// запуском основной программы
        /// </summary>
        /// <returns>Возвращает рандомное значение, являющееся задержкой</returns>
        public int MountRandomInterval()
        {
            Random ran = new Random();

            Console.WriteLine("Введите начальное значение интервала в миллисекундах");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конечное значение интервала в миллисекундах");
            int finish = int.Parse(Console.ReadLine());

            int randomInterval = ran.Next(start, finish);

            return randomInterval;
        }
        /// <summary>
        /// Метод StartTest выводит сообщение, о том, какую кнопку пользователю необходимо нажать,
        /// и рассчитывает время, которе потребовалось на нажатие
        /// </summary>
        public void StartTest()
        {
            ///Сообщение выводится красным шрифтом
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нажмите на клавишу 'w' (клавиша 'ц')");
            ///begin - время, взятое за начальное
            var begin = DateTime.Now;
            //Возврат цвета консольного шрифта к дефолтному
            Console.ResetColor();

            ///button - экземпляр структуры ConsoleKeyInfo
            ConsoleKeyInfo button = Console.ReadKey();

            ///Key - возвращает клавишу консоли, предоставленную текущим объектом button
            switch (button.Key)
            {
                ///В случае, если нажата клавиша 'ц'(она же 'w'), выводится сообщение 'Верно'
                case ConsoleKey.W:
                    Console.WriteLine("\nВерно");
                    ///end - время, взятое за конечное, после вывода сообщения в консоль
                    var end = DateTime.Now;
                    ///res - время, потраченное на нажатие требуемой кнопки
                    var res = end - begin;
                    Console.WriteLine("Время потраченное на нажатие {0}\n", res.TotalSeconds);
                    break;
                ///Если пользователь нажимает какую либо другу кнопку,
                ///то выводится указанное ниже сообщение, а конечное время не фиксируется,
                ///пока нужная кнопка не будет нажата
                default:
                    Console.WriteLine("\nПочти, попробуйте еще раз");
                    break;
            }
        }

    }
}

