package models;

import java.util.Date;

public abstract class Transaction {
    private int id;
    private Date date;
    private Float unitPrice;
    private int amount;
    public Transaction(){}

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Date getDate() {
        return date;
    }

    public void setDate(Date date) {
        this.date = date;
    }

    public Float getUnitPrice() {
        return unitPrice;
    }

    public void setUnitPrice(Float unitPrice) {
        this.unitPrice = unitPrice;
    }

    public int getAmount() {
        return amount;
    }

    public void setAmount(int amount) {
        this.amount = amount;
    }

    public Transaction(int id, Date date, Float unitPrice, int amount) {
        this.id = id;
        this.date = date;
        this.unitPrice = unitPrice;
        this.amount = amount;
    }

    @Override
    public String toString() {
        return "Transaction{" +
                "id=" + id +
                ", date=" + date +
                ", unitPrice=" + unitPrice +
                ", amount=" + amount +
                '}';
    }
    public abstract Float getTotalPrice();
}
