package models;

import java.util.Date;

public class GoldTransaction extends Transaction{
    private GoldType goldType;
    public GoldTransaction() {
        this.goldType = GoldType.TYPE1;
    }

    public GoldTransaction(int id, Date date,
                           Float unitPrice,
                           int amount, GoldType goldType) {
        super(id, date, unitPrice, amount);
        this.goldType = goldType;
    }
    @Override
    public Float getTotalPrice() {
        return this.getAmount()*getUnitPrice();
    }

    @Override
    public String toString() {
        return super.toString() +
                "goldType=" + goldType +
                '}';
    }
}
