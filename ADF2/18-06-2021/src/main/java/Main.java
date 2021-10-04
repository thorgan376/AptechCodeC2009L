import database.Database;
import models.Product;

import javax.xml.crypto.Data;
import java.sql.*;
import java.util.ArrayList;
/*
Y tuong bai tiep theo:
1.Containerize App(chuyen phan chay cua app nay len 1 container)
2.Thay JDBC bang JPA
* */

public class Main {
    public static void main(String [] args) {
//        Product iphoneX = new Product("iphone X", 2019);
//        long newId = Database.getInstance().insertProduct(iphoneX);
        //Database.getInstance().updateProduct(2, new Product("iphone 8", 2018));
        //Database.getInstance().insertProduct(new Product("iphone 7", 2017));
        ArrayList<Product> foundProducts = Database.getInstance().searchProducts("iphone");
        for (Product eachProduct: foundProducts) {
            System.out.println(eachProduct.toString());
        }
        //Database.getInstance().deleteProduct(3);
        System.out.println("haha");
    }
}
