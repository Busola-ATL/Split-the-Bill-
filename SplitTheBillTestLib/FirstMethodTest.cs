namespace SplitBill.SplitTheBillTestLib;
using SplitTheBillLibrary;

[TestClass]
public class SplitBillTestClass
{
    TakeCurrency takeCurrency = new TakeCurrency();

    [TestMethod]
    public void zero_is_return_when_noAmount_passed()
    {
        
        var ret = takeCurrency.SplitAmount(7, 0);
        Assert.AreEqual(0, ret);
    }

    [TestMethod]
    public void exeption_return_when_PepleIsZero_InValue()
    {
        Assert.ThrowsException<DivideByZeroException>(()=> takeCurrency.SplitAmount(0, 5));
    }

    [TestMethod]
    public void AmountToBeSplilted()
    {
        var ret = takeCurrency.SplitAmount(10, 500);
        Assert.AreEqual(50, ret);
    }
}