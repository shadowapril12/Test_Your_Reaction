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
}

