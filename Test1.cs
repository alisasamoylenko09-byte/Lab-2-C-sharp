using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1Test
{
    [TestClass]
    public class UnitTest1
    {
        // ТЕСТ 1: Перевірка периметра
        [TestMethod]
        public void TestPerimeterCalculation()
        {
            // Вхідні дані (трикутник зі сторонами 3, 4, 5)
            double x1 = 0, y1 = 0;
            double x2 = 0, y2 = 3;
            double x3 = 4, y3 = 0;

            // Виклики методу периметра
            double actualP = ConsoleApp1.Program.CalculatePerimeter(x1, y1, x2, y2, x3, y3);

            // Перевірка (Очікуємо 12.0)
            Assert.AreEqual(12.0, actualP, 0.0001, "Периметр обчислено некоректно");
        }

        // ТЕСТ 2: Перевірка площі
        [TestMethod]
        public void TestAreaCalculation()
        {
            // Ті ж самі вхідні дані
            double x1 = 0, y1 = 0;
            double x2 = 0, y2 = 3;
            double x3 = 4, y3 = 0;

            // Виклики методу площі
            double actualS = ConsoleApp1.Program.CalculateArea(x1, y1, x2, y2, x3, y3);

            // Перевірка (Очікуємо 6.0)
            Assert.AreEqual(6.0, actualS, 0.0001, "Площу обчислено некоректно");
        }
    }
}