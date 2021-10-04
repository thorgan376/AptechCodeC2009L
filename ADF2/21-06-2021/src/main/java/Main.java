import database.Database;
import models.Product;
import java.util.ArrayList;
//
// mvn compile exec:java -Dexec.mainClass="Main"
/*
Y tuong bai tiep theo:
test duoc "run app" o che do lenh(ko dung intellij)
//thu chuyen sang container xem build dc ko
1.Containerize App(chuyen phan chay cua app nay len 1 container Linux(Ubuntu), map thu muc code java voi thu muc tren ubuntu)
docker rm -f ubuntu-c2009l
docker run -it --name ubuntu-c2009l -v /Users/nguyenduchoang/Documents/code/Aptech/C2009L/ADF2/21-06-2021:/app ubuntu:latest
/*
apt update
apt install maven -y
apt install openjdk-16-jdk -y
2.Thay JDBC bang JPA
 */

//build bang command
//mvn compile exec:java -Dexec.mainClass="Main"
public class Main {
    public static void main(String [] args) {
        Product iphoneX = new Product("iphone X", 2019);
        long newId = Database.getInstance().insertProduct(iphoneX);
        //Database.getInstance().updateProduct(2, new Product("iphone 8", 2018));
        //Database.getInstance().insertProduct(new Product("iphone 7", 2017));
//        ArrayList<Product> foundProducts = Database.getInstance().searchProducts("iphone");
//        for (Product eachProduct: foundProducts) {
//            System.out.println(eachProduct.toString());
//        }
        //Database.getInstance().deleteProduct(3);
        System.out.println("hehe");
    }
}
