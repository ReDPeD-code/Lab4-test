using Lab4.Core;

namespace Lab4.Tests;

[TestClass]
public class ValidatorTests
{
    // ===== Корректные значения + границы: IsAdult =====

    [TestMethod]
    [DataRow(17, false)]   // граница: на единицу меньше
    [DataRow(18, true)]    // граница: ровно 18
    [DataRow(19, true)]    // граница: на единицу больше
    [DataRow(0, false)]    // нижняя граница диапазона
    [DataRow(150, true)]   // верхняя граница диапазона
    public void IsAdult_Boundaries(int age, bool expected)
    {
        Assert.AreEqual(expected, Validator.IsAdult(age));
    }

    [TestMethod]
    [DataRow(-1)]
    [DataRow(151)]
    public void IsAdult_OutOfRange_Throws(int age)
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => Validator.IsAdult(age));
    }

    // ===== Grade: все ветки и границы =====

    [TestMethod]
    [DataRow(100, "Отлично")]
    [DataRow(90, "Отлично")]
    [DataRow(89, "Хорошо")]
    [DataRow(75, "Хорошо")]
    [DataRow(74, "Удовлетворительно")]
    [DataRow(60, "Удовлетворительно")]
    [DataRow(59, "Неудовлетворительно")]
    [DataRow(0, "Неудовлетворительно")]
    public void Grade_ReturnsExpected(int score, string expected)
    {
        Assert.AreEqual(expected, Validator.Grade(score));
    }

    [TestMethod]
    [DataRow(-1)]
    [DataRow(101)]
    public void Grade_OutOfRange_Throws(int score)
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => Validator.Grade(score));
    }
}

