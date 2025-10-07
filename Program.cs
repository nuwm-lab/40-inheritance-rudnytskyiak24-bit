using System;

class SystemOf2Vectors
{
    // Базовий клас "Коло в просторі"
    class KoloVPryostori
    {
        // Координати центру
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        // Радіус кола
        public double Radius { get; set; }

        // Метод введення даних
        public virtual void ZadatyDani()
        {
            Console.WriteLine("\n--- Введення даних для кола в просторі ---");

            Console.Write("Введіть координату X центру: ");
            X = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть координату Y центру: ");
            Y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть координату Z центру: ");
            Z = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть радіус кола: ");
            Radius = Convert.ToDouble(Console.ReadLine());
        }

        // Метод виведення даних
        public virtual void VivestyDani()
        {
            Console.WriteLine($"\nКоло з центром у точці ({X}, {Y}, {Z}) та радіусом {Radius}");
        }

        // Метод для обчислення довжини кола
        public double DovzhynaKola()
        {
            return 2 * Math.PI * Radius;
        }
    }

    // Похідний клас "Конус"
    class Konus : KoloVPryostori
    {
        // Координати вершини
        public double VertexX { get; set; }
        public double VertexY { get; set; }
        public double VertexZ { get; set; }

        // Твірна
        public double Tvyrna { get; set; }

        // Перевантаження методу введення
        public override void ZadatyDani()
        {
            Console.WriteLine("\n--- Введення даних для конуса ---");

            Console.Write("Введіть координату X вершини: ");
            VertexX = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть координату Y вершини: ");
            VertexY = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть координату Z вершини: ");
            VertexZ = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть твірну конуса: ");
            Tvyrna = Convert.ToDouble(Console.ReadLine());

            // Введення центру основи та радіуса
            base.ZadatyDani();
        }

        // Перевантаження методу виведення
        public override void VivestyDani()
        {
            Console.WriteLine($"\nКонус:");
            Console.WriteLine($"Вершина: ({VertexX}, {VertexY}, {VertexZ})");
            Console.WriteLine($"Твірна: {Tvyrna}");
            Console.WriteLine($"Центр основи: ({X}, {Y}, {Z})");
            Console.WriteLine($"Радіус основи: {Radius}");
        }

        // Метод для обчислення бічної поверхні
        public double BichnaPoverkhnia()
        {
            return Math.PI * Radius * Tvyrna;
        }

        // Метод для отримання радіуса основи (можна просто використати Radius)
        public double RadiusOsnovy()
        {
            return Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // === Коло ===
            KoloVPryostori kolo = new KoloVPryostori();
            kolo.ZadatyDani();
            kolo.VivestyDani();

            double dovzhyna = kolo.DovzhynaKola();
            Console.WriteLine($"Довжина кола: {dovzhyna:F2}");

            // === Конус ===
            Konus konus = new Konus();
            konus.ZadatyDani();
            konus.VivestyDani();

            Console.WriteLine($"Радіус основи конуса: {konus.RadiusOsnovy():F2}");
            Console.WriteLine($"Бічна поверхня конуса: {konus.BichnaPoverkhnia():F2}");
        }
    }
}
