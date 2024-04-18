namespace SplitBill.SplitTheBillTestLib;
using SplitTheBillLibrary;

[TestClass]
public class TipPersonTest{
    TipPersonMethod tipPersonMethod = new TipPersonMethod();

    [TestMethod]
    public void return_Exact_Value_WhenAll_Parameters_ArePassed(){
        decimal price = 1000.0M; 
        int patrons = 15;
        float tipercentage = 25.0f; 

        var ret = tipPersonMethod.tipPerPerson(price, patrons, tipercentage);
        Assert.AreEqual(250, (double)ret);
    }

    [TestMethod]
    public void return_Zero_if_Patron_Value_IsZero_And_Other_Parameters_ArePassed(){
        decimal price = 1000.0M; 
        int patrons = 0;
        float tipercentage = 25.0f; 

        var ret = tipPersonMethod.tipPerPerson(price, patrons, tipercentage);
        Assert.AreEqual(0, (double)ret);
    }
    [TestMethod]
    public void return_Zero_When_Price_Value_IsZero_And_Other_Parameters_ArePassed(){
        decimal price = 0.0M; 
        int patrons = 5;
        float tipercentage = 25.0f; 

        var ret = tipPersonMethod.tipPerPerson(price, patrons, tipercentage);
        Assert.AreEqual(0, (double)ret);
    }
}