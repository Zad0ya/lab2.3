using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23
{

    class Program
    {

        static void Main(string[] args)
        {
            Employee converter = new Employee(31487, 54167, 15765, 26951, 8658, 0.20);
            converter.Print();
            Console.ReadKey();
        }
    }
    //Створити клас Employee.
    class Employee
    {
        private double buh { get; set; }
        private double boss { get; set; }
        private double prod { get; set; }
        private double otdpr { get; set; }
        private double ubor { get; set; }
        private double podatok { get; set; }


        public Employee(double buh, double boss, double prod, double otdpr, double ubor, double podatok)
        {
            this.buh = buh;
            this.boss = boss;
            this.prod = prod;
            this.otdpr = otdpr;
            this.ubor = ubor;
            this.podatok = podatok;
        }

        public void Print()
        {
            Console.WriteLine("----------------------------Система управління бухгалтерського обліку Макс3000----------------------------");
            Console.WriteLine("Оберіть операцію:");
           Console.WriteLine("\n1.Пошук працівників за ініцалами \n2.Пошук прізвища ");
            int vol = Convert.ToInt32(Console.ReadLine());
            switch (vol)
            {
                case 1:
                    Console.WriteLine("Оберіть Працівника:");
                    Console.WriteLine("\n1.ЗМО \n2.ВАП \n3.ГСМ \n4.МОЕ");
                    int vol2 = Convert.ToInt32(Console.ReadLine());
                    switch (vol2)
                    {
                        case 1:
                            Console.WriteLine("Заробітна плаата працівника без податкового збору скаладає " + boss);
                            Console.WriteLine("Податковий збір" + podatok);
                            double zboss = boss - (boss * podatok);
                            Console.WriteLine("Заробітна плата працівника з податковим збором: " + zboss);
                            Console.WriteLine("Можлива надбавка за стаж");
                            Console.WriteLine("\n1.<3 років \n2.3-5 років \n3.7> років");
                            int voln = Convert.ToInt32(Console.ReadLine());
                            switch (voln)
                            {
                                case 1:
                                    Console.WriteLine("Можлива надбавка за стаж відсутня");
                                    break;
                                case 2:
                                    Console.WriteLine("Надбавка за стаж +3%");
                                    double zbossnad1 = zboss * 1.03;
                                    Console.WriteLine("Заробітна плата працівника з податковим збором та надбавкою складає: " + zbossnad1);
                                    break;
                                case 3:
                                    Console.WriteLine("Надбавка за стаж +5%");
                                    double zbossnad2 = zboss * 1.05;
                                    Console.WriteLine("Заробітна плата працівника з податковим збором та надбавкою складає: " + zbossnad2);
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Заробітна плаата працівника без податкового збору скаладає " + buh);
                            Console.WriteLine("Податковий збір" + podatok);
                            double zbuh = buh - (buh * podatok);
                            Console.WriteLine("Заробітна плата працівника з податковим збором: " + zbuh);
                            Console.WriteLine("Можлива надбавка за стаж");
                            Console.WriteLine("\n1.<3 років \n2.3-5 років \n3.7> років");
                            int vola = Convert.ToInt32(Console.ReadLine());
                            switch (vola)
                            {
                                case 1:
                                    Console.WriteLine("Можлива надбавка за стаж відсутня");
                                    Console.WriteLine("Заробітна плата працівника з податковим збором та надбавкою складає: " + zbuh);
                                    break;
                                case 2:
                                    Console.WriteLine("Надбавка за стаж +3%");
                                    double zbuhnad1 = zbuh * 1.03;
                                    Console.WriteLine("Заробітна плата працівника з податковим збором та надбавкою складає: " + zbuhnad1);
                                    break;
                                case 3:
                                    Console.WriteLine("Надбавка за стаж +5%");
                                    double zbuhnad2 = zbuh * 1.05;
                                    Console.WriteLine("Заробітна плата працівника з податковим збором та надбавкою складає: " + zbuhnad2);
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Заробітна плаата працівника без податкового збору скаладає " + prod);
                            Console.WriteLine("Податковий збір" + podatok);
                            double zprod = prod - (prod * podatok);
                            Console.WriteLine("Заробітна плата працівника з податковим збором: " + zprod);
                            Console.WriteLine("Можлива надбавка за стаж");
                            Console.WriteLine("\n1.<3 років \n2.3-5 років \n3.7> років");
                            int volb = Convert.ToInt32(Console.ReadLine());
                            switch (volb)
                            {
                                case 1:
                                    Console.WriteLine("Можлива надбавка за стаж відсутня");
                                    Console.WriteLine("Заробітна плата працівника з податковим збором та надбавкою складає: " + zprod);
                                    break;
                                case 2:
                                    Console.WriteLine("Надбавка за стаж +3%");
                                    double zprodnad1 = zprod * 1.03;
                                    Console.WriteLine("Заробітна плата працівника з податковим збором та надбавкою складає: " + zprodnad1);
                                    break;
                                case 3:
                                    Console.WriteLine("Надбавка за стаж +5%");
                                    double zprodnad2 = zprod * 1.05;
                                    Console.WriteLine("Заробітна плата працівника з податковим збором та надбавкою складає: " + zprodnad2);
                                    break;
                            }
                            break;
                        case 4:
                            Console.WriteLine("Заробітна плаата працівника без податкового збору скаладає " + otdpr);
                            Console.WriteLine("Податковий збір" + podatok);
                            double zotdpr = otdpr - (otdpr * podatok);
                            Console.WriteLine("Заробітна плата працівника з податковим збором: " + zotdpr);
                            Console.WriteLine("Можлива надбавка за стаж");
                            Console.WriteLine("\n1.<3 років \n2.3-5 років \n3.7> років");
                            int volc = Convert.ToInt32(Console.ReadLine());
                            switch (volc)
                            {
                                case 1:
                                    Console.WriteLine("Можлива надбавка за стаж відсутня");
                                    Console.WriteLine("Заробітна плата працівника з податковим збором та надбавкою складає: " + zotdpr);
                                    break;
                                case 2:
                                    Console.WriteLine("Надбавка за стаж +3%");
                                    double zotdprnad1 = zotdpr * 1.03;
                                    Console.WriteLine("Заробітна плата працівника з податковим збором та надбавкою складає: " + zotdprnad1);
                                    break;
                                case 3:
                                    Console.WriteLine("Надбавка за стаж +5%");
                                    double zotdprnad2 = zotdpr * 1.05;
                                    Console.WriteLine("Заробітна плата працівника з податковим збором та надбавкою складає: " + zotdprnad2);
                                    break;
                            }
                            break;
                        case 5:
                            Console.WriteLine("Заробітна плаата працівника без податкового збору скаладає " + ubor);
                            Console.WriteLine("Податковий збір" + podatok);
                            double zubor = ubor - (ubor * podatok);
                            Console.WriteLine("Заробітна плата працівника з податковим збором: " + zubor);
                            Console.WriteLine("Можлива надбавка за стаж");
                            Console.WriteLine("\n1.<3 років \n2.3-5 років \n3.7> років");
                            int vold = Convert.ToInt32(Console.ReadLine());
                            switch (vold)
                            {
                                case 1:
                                    Console.WriteLine("Можлива надбавка за стаж відсутня");
                                    Console.WriteLine("Заробітна плата працівника з податковим збором та надбавкою складає: " + zubor);
                                    break;
                                case 2:
                                    Console.WriteLine("Надбавка за стаж +3%");
                                    double zubornad1 = zubor * 1.03;
                                    Console.WriteLine("Заробітна плата працівника з податковим збором та надбавкою складає: " + zubornad1);
                                    break;
                                case 3:
                                    Console.WriteLine("Надбавка за стаж +5%");
                                    double zubornad2 = zubor * 1.05;
                                    Console.WriteLine("Заробітна плата працівника з податковим збором та надбавкою складає: " + zubornad2);
                                    break;
                            }
                            break;
                    }
                    break;

              
            }
        }
    }
     }