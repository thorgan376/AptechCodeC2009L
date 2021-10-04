import models.GoldTransaction;
import models.InvoiceByDay;
import models.InvoiceByHour;

import java.text.SimpleDateFormat;
import java.util.Date;

public class App {
    public static void main(String [] args) {
        try {
            InvoiceByHour invoice2 = new InvoiceByHour("22",
                    Helper.toDate("01/06/2021"),
                    "nv b", "r22", 20.0, 35.0f);
            System.out.println("total = "+invoice2.getTotalPrice());
            InvoiceByDay invoice1 = new InvoiceByDay(
                "1",
                Helper.toDate("31/05/2021"),
                "ngyen van qa",
                    "room11", 123.0, 2
                );
            System.out.println("total = "+invoice1.getTotalPrice());

        }catch (Exception exception) {
            System.out.println(exception.getMessage());
        }
    }
}
