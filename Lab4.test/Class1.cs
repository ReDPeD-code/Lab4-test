using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lab4.Core;

namespace Lab4.Tests;

[TestClass]
public class ReportServiceTests
{
    private readonly ReportService _service = new();

    [TestMethod]
    public void BuildReport_ValidNumbers_ReturnsQuotient()
        => Assert.AreEqual("5", _service.BuildReport(10, 2));

    [TestMethod]
    public void BuildReport_DivideByZero_ReturnsEmpty()
        => Assert.AreEqual(string.Empty, _service.BuildReport(10, 0));

    [TestMethod]
    public void Format_Text_ReturnsUpperWithUnderscores()
        => Assert.AreEqual("HELLO_WORLD: 5", _service.Format("hello world", 5));

    [TestMethod]
    public void Format_Null_ReturnsEmpty()
        => Assert.AreEqual(string.Empty, _service.Format(null, 5));
}
