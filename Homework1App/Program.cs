using System;

namespace Homework1App
{
    class Program
    {
        static void Main()
        {
            //Ввод имени//
            Console.WriteLine("Введите своё имя");
            string name = Console.ReadLine();
            Console.WriteLine("Данные в эту програму вводит биологчесая приставка: "+name);

            //Нахождение корней квадратного уравнения//
            Console.WriteLine("Следующая задача находит корни квадраного уравнения по трём введённым коэффициенам");
            Console.WriteLine("Введите коэффициент A");
            bool result1 = double.TryParse(Console.ReadLine(), out double coefA);
            Console.WriteLine("Введите коэффициент B");
            bool result2 = double.TryParse(Console.ReadLine(), out double coefB);
            Console.WriteLine("Введите коэффициент C");
            bool result3 = double.TryParse(Console.ReadLine(), out double coefC);
            if (result1 && result2 && result3)
            {
                if (((Math.Pow(coefB, 2)) - 4 * coefA * coefC) > 0)
                {
                    double root1 = ((-coefB) + Math.Sqrt(Math.Pow(coefB, 2) - (4 * coefA * coefC))) / (2 * coefA);
                    double root2 = ((-coefB) - Math.Sqrt(Math.Pow(coefB, 2) - (4 * coefA * coefC))) / (2 * coefA);
                    Console.WriteLine(((-coefB) + Math.Sqrt(Math.Pow(coefB, 2) - (4 * coefA * coefC))));
                    Console.WriteLine("Уравнение имеет два корня: ");
                    Console.WriteLine("Корень 1: " + root1);
                    Console.WriteLine("Корень 2: " + root2);
                    //Проверка//
                    Console.WriteLine("Проверка. Для корня 1 результат вычисления должен быть равен 0 с учётом  ошибки вычислений");
                    Console.WriteLine(coefA + "*" + Math.Pow(root1, 2) + "+" + coefB + "*" + root1 + "+" + coefC + "=" + (coefA * Math.Pow(root1, 2) + coefB * root1 + coefC));
                    Console.WriteLine("Проверка. Для корня 2 результат вычисления должен быть равен 0 с учётом  ошибки вычислений");
                    Console.WriteLine(coefA + "*" + Math.Pow(root2, 2) + "+" + coefB + "*" + root2 + "+" + coefC + "=" + (coefA * Math.Pow(root2, 2) + coefB * root2 + coefC));

                }
                else if (((Math.Pow(coefB, 2)) - 4 * coefA * coefC) == 0)
                {
                    double root = (-coefB / (2 * coefC));
                    Console.WriteLine("Уравнение имеет один корень: " + root);
                    //Проверка//
                    Console.WriteLine("Проверка. При подстановке корня результат вычисления должен быть равен 0 с учётом  ошибки вычислений");
                    Console.WriteLine(coefA + "*" + Math.Pow(root, 2) + "+" + coefB + "*" + root + "+" + coefC + "=" + (coefA * Math.Pow(root, 2) + coefB * root + coefC));
                }
                else Console.WriteLine("Уравнение корней не имеет");
            }
            else Console.WriteLine("По крайней мере один из введённых коэффициентов не является числом");
            

            //Нахождение гипотенузы по теореме Пифагора//
            Console.WriteLine("Следующая часть программы находит гипотенузу прямоугольного треугольника по двум заданным катетам");
            Console.WriteLine("Введите катет 1");
            bool result5 = double.TryParse(Console.ReadLine(), out double cathetus1);
            Console.WriteLine("Введите катет 1");
            bool result6 = double.TryParse(Console.ReadLine(), out double cathetus2);
            if (result5&&result6)
            { double hypotenuse = Math.Sqrt(Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2));
                Console.WriteLine("Длина гипотенузы составляет: " + hypotenuse);

                //Нахождение углов прямоугольного треугольника//
                Console.WriteLine("Далее по введённым катетам и полученой гипотенузе найдём углы треугольника");
                double anglealpha = (Math.Asin(cathetus2 / hypotenuse))*57.2958;
                double anglebeta = (Math.Asin(cathetus1 / hypotenuse))*57.2958;
                Console.WriteLine("Угол альфа (прилежащий к катету 1) составляет " + anglealpha + " градусов");
                Console.WriteLine("Угол бета (прилежащий к катету 2) составляет " + anglebeta + " градусов");
                Console.WriteLine("Угол гамма сосавляет 90 градусов (по условию)");

                //Проверка суммы углов треугольника//
                Console.WriteLine("Сумма углов треугольника должна равняться 180 градусов с учётом погрешности вычислений");
                Console.WriteLine(anglealpha+"+"+anglebeta+"+"+90+"="+(anglealpha+anglebeta+90));
            }
            else Console.WriteLine("По крайней мере один из введённых катетов не является числом");

            //Закрытие//
            Console.WriteLine("Теперь вы можете нажать любую клавишу и закрыть программу");
           

           
        }
    }
}
