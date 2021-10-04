import controllers.TransactionController;
import interfaces.IDoSomething;
import interfaces.IPlayable;
import models.*;

import java.text.SimpleDateFormat;
import java.util.Date;

public class App {
    public static void main(String [] args) {
        /*
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
        */

        //bam may de tinh lai
        //IPlayable x = new IPlayable(); //ko the khoi tao dc interface
        //Goi truc tiep phuong thuc static cua interface ? Yes !
        IPlayable.doSomething();//ok
        Student studentA = new Student("nguyen van a", "nva@gmail.com");
        studentA.playAGame("gamex");
        studentA.goToLibrary("lib a");
        //co the dung interface tham chieu den class => ok
        //transmit data between screen(Android), MVVM(Android)
        IPlayable studentB = new Student("nguyen van b", "nvb@gmail.com");
        //studentB.goToLibrary("lib a");
        IPlayable y = new IPlayable() {
            @Override
            public void playAGame(String gameName) {

            }

            @Override
            public void playFoodball() {

            }
        };//anonymous Object
        studentA.doX(new IDoSomething() {
            @Override
            public void onClick(String x) {
                System.out.println("bam click :"+x);
                //Objective C va Java => ko hoc song song
            }
        });

    }
}
