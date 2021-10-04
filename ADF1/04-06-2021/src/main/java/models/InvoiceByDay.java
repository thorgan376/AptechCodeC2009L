package models;

import java.util.Date;

public class InvoiceByDay extends Invoice{
    private Integer days;

    public InvoiceByDay(String id, Date invoiceDate, String customerName, String roomId,
                        Double unitPrice, Integer days) {
        super(id, invoiceDate, customerName, roomId, unitPrice);
        this.days = days;
    }

    @Override
    public Double getTotalPrice(){
        /*
        Double totalPrice = 0.0;
        if(days > 7) {
            totalPrice = 7 * getUnitPrice() + (days - 7)*getUnitPrice()*0.8;
        } else {
            totalPrice = days * getUnitPrice();
        }*/
        return (days > 7) ? 7 * getUnitPrice() + (days - 7)*getUnitPrice()*0.8 :
                            days * getUnitPrice();
        //return totalPrice;
    }
    @Override
    public String toString() {
        return super.toString() + "days=" + days;
    }
}
