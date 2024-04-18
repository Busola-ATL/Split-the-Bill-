namespace SplitBill.SplitTheBillTestLib;
using SplitTheBillLibrary;

[TestClass]
public class TipPercentageTest
{
    TipPercentage tipPercentage = new TipPercentage();
    Dictionary<string, decimal> mealDetails = new Dictionary<string, decimal>{
        {"Aminat", 78.0M},
        {"Atanda", 87.0M},
        {"Ayo", 98.0M}
    };

    float tipPercent = 15.0f; 

    [TestMethod]
    public void returningActualValueWhenAllParameterArePassed(){

        var ret = tipPercentage.getTipPercentageCalculated(mealDetails, tipPercent);

        Assert.AreEqual((double)11.7M, (double)ret["Aminat"]); //total tip is 39.45

    }

    [TestMethod]
    public void retuning_Zero_Amount_Paid_ForTheTip_WhenZeroTipPercentageIsPassed(){
        float tipPercent = 0.0f;
        var ret = tipPercentage.getTipPercentageCalculated(mealDetails, tipPercent);
        Assert.AreEqual(0, ret["Aminat"]);
        Assert.AreEqual(0, ret["Atanda"]);
        Assert.AreEqual(0, ret["Ayo"]);
    }
    [TestMethod]
    public void return_Empty_Dictionary_When_Empty_Value_Of_Dictionary_Is_Passed_AsParameter(){
        Dictionary<string, decimal> mealDetails = new Dictionary<string, decimal>();
        var ret = tipPercentage.getTipPercentageCalculated(mealDetails, tipPercent);
        Assert.IsNull(ret);
        Assert.AreEqual(null, ret);
    }
}