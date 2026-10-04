namespace Lab4.Core;

public class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal initialBalance = 0)
    {
        if (initialBalance < 0)
            throw new ArgumentOutOfRangeException(nameof(initialBalance), "Начальный баланс не может быть отрицательным");
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Сумма должна быть положительной");
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Сумма должна быть положительной");
        if (amount > Balance)
            throw new InvalidOperationException("Недостаточно средств");
        Balance -= amount;
    }
}

public static class Validator
{
    public static bool IsAdult(int age)
    {
        if (age < 0 || age > 150)
            throw new ArgumentOutOfRangeException(nameof(age));
        return age >= 18;
    }

    public static string Grade(int score)
    {
        if (score < 0 || score > 100)
            throw new ArgumentOutOfRangeException(nameof(score));
        if (score >= 90) return "Отлично";
        if (score >= 75) return "Хорошо";
        if (score >= 60) return "Удовлетворительно";
        return "Неудовлетворительно";
    }

    // Метод, который мы НАМЕРЕННО оставим без тестов для демонстрации непокрытого кода
    public static string Reverse(string text)
    {
        if (text == null) throw new ArgumentNullException(nameof(text));
        var chars = text.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}