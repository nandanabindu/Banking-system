public class RecurringAccount : IBank
{
    
    float amount;
    public float deposit(float amtDeposit){
        amount = amount + amtDeposit;
        return amount;
    }

    public float withdrawal(float amtWithdraw){
        if(amtWithdraw>amount){
            return -1;

        }
         amount = amount - amtWithdraw;
         return amount;
    }
    public float getBalance(){
        return amount;
    }
}
