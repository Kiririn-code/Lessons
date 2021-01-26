using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroAction;
            int howlLifetime = 0;
            int avoidAttack;
            int bossBackstab = 9999999;
            int holySword = 99;
            float avoidBuff = 1.2f;
            float bossHp = 1000, heroHp = 800;
            float bossAttack,heroAttack;
            float howlBust = 1.2f;
            bool isHowlExist = false;
            bool isGameContinue = true;
            Random ob = new Random();

            Console.WriteLine("Перед вами великий и ужасный Колормочу,обладающий "+ bossHp+" жизней, бегите в страхе");
            Console.WriteLine("Темный маг Дарыгер - у вас имеется "+ heroHp +" жизней \nПобедите Колормочу чтобы спасти принцессу");

            while (isGameContinue)
            {
                heroAttack = ob.Next(30, 50);
                bossAttack = ob.Next(60, 80);
                Console.WriteLine("Список способностей: ");
                Console.WriteLine("1 - Чындык кылычы - ударить босса священным мечом");
                Console.WriteLine("2 - Боорукер арбак - призвать на помощь духа предков,сила атаки возрастает на 20 процентов");
                Console.WriteLine("3 - Руханий дарылоо - дух предков исцеляет определенное количество здоровья");
                Console.WriteLine("4 - Качуу - с 50 % вероятности вы уворачиваетесь от следующей атаки босса,урон так же уменьшается");
                Console.WriteLine("5 - Сдаться");
                Console.Write("Выберете спосбоность ");
                heroAction = Convert.ToInt32(Console.ReadLine());

                switch (heroAction)
                {
                    case 1:
                        heroAttack = holySword;
                        break;

                    case 2:
                        if (howlLifetime == 0)
                        {
                            Console.WriteLine("Вы призвали великого духа Арбак");
                            isHowlExist = true;
                            howlLifetime = 3;
                        }
                        else
                        {
                            Console.WriteLine("Добрый дух уже призван, и будет жить еще "+ howlLifetime+" ходов");
                        }
                        break;

                    case 3:
                        if (isHowlExist)
                        {
                            heroHp += ob.Next(50,100);
                            Console.WriteLine("Вас подхилили,у вас "+ heroHp + "жизней");
                        }
                        else
                        {
                            Console.WriteLine("Доброго духа нет на поле. \n Призовите его,чтобы иметь возможность лечиться");
                        }
                        break;

                    case 4:
                        avoidAttack = ob.Next(0, 2);
                        if (avoidAttack == 1)
                        {
                            Console.WriteLine("Вы успешно увернулись,сила атаки увеличена на 20%");
                            bossAttack = 0;
                            heroAttack *= avoidBuff;
                        }
                        else
                        {
                            Console.WriteLine("Попытка увернуться вышла Вам боком,сила босса увеличена на 20%");
                            bossAttack *= avoidBuff;
                        }
                        break;

                    case 5:
                        Console.WriteLine("Вы попробовали позорно сбежать,но Колормочу почувствовал вашу слабость,и ударил вас в спину");
                        bossAttack = bossBackstab;
                        break;

                    default:
                        Console.WriteLine("Команда не распознанна");
                        break;
                }
                //Время существования призрака
                if (isHowlExist)
                {
                    howlLifetime--;
                    heroAttack *= howlBust;
                    if (howlLifetime == 0)
                    {
                        isHowlExist = false;
                        Console.WriteLine("Добрый дух покинул поле боя");
                    }
                }
                bossHp -= heroAttack;
                heroHp -= bossAttack;
                Console.WriteLine("У Колормочу осталось - "+ bossHp +" жизней, вы ударили на "+heroAttack+" едениц урона");
                Console.WriteLine("По вам прошла атака в "+bossAttack+" едениц урона. У Вас осталось  - "+heroHp+" жизней");
                Console.ReadKey();
                Console.Clear();

                if (heroHp<=0)
                {
                    Console.WriteLine("Колормочу победил,Ваше остывшее тело лежит под сводами замка");
                    isGameContinue = false;
                }
               else if(bossHp<=0)
                {
                    Console.WriteLine("Вы одолели босса!");
                    isGameContinue = false;
                }
            }
        }
    }
}
