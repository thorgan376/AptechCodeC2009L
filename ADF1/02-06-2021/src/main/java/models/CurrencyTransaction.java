package models;

import java.util.Date;

public class CurrencyTransaction  extends Transaction{
    private Float rate;
    private CurrencyType currencyType;

    public CurrencyTransaction() {
        rate = 1.0f;
        currencyType = CurrencyType.VND;
    }
    public CurrencyTransaction(int id, Date date,
                               Float unitPrice,
                               int amount, Float rate,
                               CurrencyType currencyType) {
        super(id, date, unitPrice, amount);
        this.rate = rate;
        this.currencyType = currencyType;
    }

    public Float getTotalPrice() {
        /*
        if(currencyType == CurrencyType.USD ||
                currencyType == CurrencyType.EURO) {
            return getAmount() * getUnitPrice() * rate;
        } else{
            return  getAmount() * getUnitPrice();
        }
        */
         return  getAmount() * getUnitPrice() *
                 (currencyType == CurrencyType.USD ||
                currencyType == CurrencyType.EURO ? rate : 1);
    }
    @Override
    public String toString() {
        return super.toString() +
                "rate=" + rate +
                ", currencyType=" + currencyType +
                '}';
    }
}
