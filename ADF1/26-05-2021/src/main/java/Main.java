import controllers.CDController;
import models.CompactDisk;
import validations.Validation;

public class Main {
    public static void main(String[] args) {
        //Validation.isValidID("123cd");
        Validation.isValidID("456");
//        Validation.isValidID("110000");
//        Validation.isValidID("-21");

//        CDController cdController = new CDController();
//        cdController.showMenu();
        /*
        cdController.insertCD(new CompactDisk(1, "title abnc",
                "nguyen van a", 12, 123.3));
        cdController.insertCD(new CompactDisk(2, "title abnc",
                "nguyen van b", 13, 133.3));
        cdController.insertCD(new CompactDisk(1, "title abnc",
                "nguyen van C", 22, 143.3));

        cdController.insertCD(new CompactDisk(3, "title abnc",
                "nguyen van D", 22, 143.3));
        cdController.insertCD(new CompactDisk(4, "title abnc",
                "nguyen van E", 22, 143.3));
        cdController.insertCD(new CompactDisk(5, "title abnc",
                "nguyen van F", 22, 143.3));
        System.out.println(String.format("Total price = %f", cdController.getTotalPrice()));
        cdController.showAllCDs();
        */


    }
}
