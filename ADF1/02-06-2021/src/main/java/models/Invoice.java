package models;

import java.util.Date;

public abstract class Invoice {
   private String id;
   private Date invoiceDate;
   private String customerName;
   private String roomId;
   private Double unitPrice;

    public Invoice(String id, Date invoiceDate, String customerName,
                   String roomId, Double unitPrice) {
        this.id = id;
        this.invoiceDate = invoiceDate;
        this.customerName = customerName;
        this.roomId = roomId;
        this.unitPrice = unitPrice;
    }

    @Override
    public String toString() {
        return String.format(
                "id = %s, invoiceDate = %s, customer's name: %s, roomId : %s, unitPrice: %f",
                id, invoiceDate.toString(),customerName,roomId, unitPrice);
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public Date getInvoiceDate() {
        return invoiceDate;
    }

    public void setInvoiceDate(Date invoiceDate) {
        this.invoiceDate = invoiceDate;
    }

    public String getCustomerName() {
        return customerName;
    }

    public void setCustomerName(String customerName) {
        this.customerName = customerName;
    }

    public String getRoomId() {
        return roomId;
    }

    public void setRoomId(String roomId) {
        this.roomId = roomId;
    }

    public Double getUnitPrice() {
        return unitPrice;
    }

    public void setUnitPrice(Double unitPrice) {
        this.unitPrice = unitPrice;
    }
    public abstract Double getTotalPrice() throws Exception;
}
