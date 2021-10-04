import controllers.TransactionController;
import models.*;
import org.junit.jupiter.api.Test;

import java.util.Date;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class MyTest {
    @Test
    public void testTransaction(){
        TransactionController transactionController = new TransactionController();
        transactionController
                .insert(new CurrencyTransaction(
                        1, new Date(), 111f, 2, 1.1f, CurrencyType.USD));
        transactionController
                .insert(new GoldTransaction(
                        5, new Date(), 555f, 5, GoldType.TYPE1));
        transactionController
                .insert(new CurrencyTransaction(
                        2, new Date(), 222f, 3, 2.2f, CurrencyType.USD));
        transactionController
                .insert(new GoldTransaction(
                        4, new Date(), 444f, 4, GoldType.TYPE2));
        //System.out.println("average = "+transactionController.getCurrencyAverage());
        //test automation => ko nhin bang mat

        assertEquals(42, Integer.sum(19, 23));
        assert transactionController.getCurrencyAverage() == 427.35004f;
        System.out.println("test average ok");
        assert transactionController.getTransactions().size() == 4 : "wrong size";
        System.out.println("test size ok");
    }
}
