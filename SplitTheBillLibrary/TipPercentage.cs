namespace SplitBill. SplitTheBillLibrary;

public class TipPercentage{
    public Dictionary<string, decimal> getTipPercentageCalculated(Dictionary<string, decimal> detail, float tipPercentage){

        Dictionary<string, decimal> namesAndTips = new Dictionary<string, decimal>();

        decimal totalMealCost = 0;

        foreach(var nameTip in detail){
            totalMealCost += nameTip.Value;
        }

        decimal totalTipAmount = totalMealCost * (decimal)(tipPercentage/100);

        foreach(var single in detail){
            decimal tipForAPerson = (single.Value / totalMealCost) * totalTipAmount;
            namesAndTips.Add(single.Key, tipForAPerson);
        }
        
        if(namesAndTips.Count == 0 ){
            return null;
        }

        return namesAndTips;
    }

    

}