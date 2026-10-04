using Lab4.Core;

namespace Lab4.Tests;

[TestClass]
public class BankAccountTests
{
    // ===== 1. Корректные значения =====

    [TestMethod]
    public void Constructor_NoArguments_BalanceIsZero()
    {
        var account = new BankAccount();
        Assert.AreEqual(0m, account.Balance);
    }

    [TestMethod]
    public void Deposit_PositiveAmount_IncreasesBalance()
    {
        var account = new BankAccount(100);
        account.Deposit(50);
        Assert.AreEqual(150m, account.Balance);
    }

    [TestMethod]
    public void Withdraw_ValidAmount_DecreasesBalance()
    {
        var account = new BankAccount(100);
        account.Withdraw(30);
        Assert.AreEqual(70m, account.Balance);
    }

    // ===== 2. Граничные условия =====

    [TestMethod]
    public void Withdraw_ExactBalance_BalanceBecomesZero()
    {
        var account = new BankAccount(100);
        account.Withdraw(100);
        Assert.AreEqual(0m, account.Balance);
    }

    [TestMethod]
    public void Deposit_MinimalAmount_Works()
    {
        var account = new BankAccount();
        account.Deposit(0.01m);
        Assert.AreEqual(0.01m, account.Balance);
    }

    [TestMethod]
    public void Constructor_ZeroInitialBalance_IsAllowed()
    {
        var account = new BankAccount(0);
        Assert.AreEqual(0m, account.Balance);
    }

    // ===== 3. Исключительные ситуации =====

    [TestMethod]
    public void Constructor_NegativeBalance_Throws()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new BankAccount(-1));
    }

    [TestMethod]
    public void Deposit_ZeroAmount_Throws()
    {
        var account = new BankAccount(100);
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Deposit(0));
    }

    [TestMethod]
    public void Withdraw_MoreThanBalance_ThrowsInvalidOperation()
    {
        var account = new BankAccount(100);
        Assert.ThrowsException<InvalidOperationException>(() => account.Withdraw(100.01m));
    }

    [TestMethod]
    public void Withdraw_NegativeAmount_Throws()
    {
        var account = new BankAccount(100);
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Withdraw(-5));
    }
}

