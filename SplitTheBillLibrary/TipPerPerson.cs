namespace SplitBill. SplitTheBillLibrary;

public class TipPersonMethod{
    public decimal tipPerPerson(decimal price, int patron, float tipPercentage){

        var totalPrice = price * patron;

        var totalTip = (totalPrice * (decimal)tipPercentage) / 100;

        if(patron == 0){
            return 0.0M;
        }

        return totalTip/patron;
    }
}