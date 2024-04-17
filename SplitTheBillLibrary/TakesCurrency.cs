namespace SplitBill. SplitTheBillLibrary;
public class SplitBill
{
    public decimal SplitAmount(int people, decimal currency){
        if(currency == 0){
             return 0;
        }

        else 
            if(people == 0){
                throw new  DivideByZeroException("Number of People can't be zero");
            }
        
        else{
            return currency/people; 
        } 

    }
}