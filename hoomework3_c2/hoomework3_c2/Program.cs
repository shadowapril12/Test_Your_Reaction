using System;
using System.Threading;

namespace hoomework3_c2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                ///В цикле создается экземпляр класса Random - ran, для задания интервала времени
                ///через которое запуститься метод StartTest
                Random ran = new Random();
                ///Текущий поток выполенеия программы приостанавливатеся
                ///на количество миллисекунд в диапазоне от 0 до 10000
                Thread.Sleep(ran.Next(0, 10000));
                StartTest();
            }

            
        }
        /// <summary>
        /// Метод StartTest выводит сообщение  указывающее пользователю, какую кнопку
        /// ему следует нажать, и рассчитывает время, которое потребовалось на нажатие
        /// </summary>
        static void StartTest()
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
            switch(button.Key)
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
