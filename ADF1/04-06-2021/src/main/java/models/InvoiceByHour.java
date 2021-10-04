package models;

import java.util.Date;

public class InvoiceByHour extends Invoice {
    private Float hour;
    public InvoiceByHour(String id, Date invoiceDate,
                         String customerName,
                         String roomId, Double unitPrice,
                         Float hour
    ) {
        super(id, invoiceDate, customerName, roomId, unitPrice);
        this.hour = hour;
    }

    @Override
    public String toString() {
        return super.toString() +
                "hour=" + hour;
    }

    @Override
    public Double getTotalPrice() throws Exception{
        if(this.hour > 30) {
            //bao loi nhung van tra ve ket qua => ko on
            throw new Exception("Bạn phải dùng hóa đơn theo ngày");
        }
        return (this.hour > 24 && this.hour < 30 ? 24 : this.hour)* getUnitPrice();
    }
}
