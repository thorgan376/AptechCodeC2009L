import models.Line;
import models.Person;
import models.Point;
import models.Product;

public class Main {
    public static void main(String [] args) {
        System.out.println("Hello");
        //Khoi tao doi tuong, ko lam nhu the nay !
        Product productA = new Product(); //khoi tao doi tuong(initialize an Object)
        productA.name = "iphone X";
        productA.year = 2018;
        productA.color  = "red";
        //cach 2: khoi tao bang ham constructor
        Product productB = new Product("iphone 6", 2016, "blue");
        Product productC = productB;//tham chieu(reference)
        //productC.color = "red";
        //Reference counting
//        productB = null;
//        productC = null;
        //clone an object
        Product productD = new Product();//tao ra productD trong
        productD.name = productB.name;//copy tung thuoc tinh tu B
        productD.year = productB.year;
        productD.color = productB.color;
        productD.color = "yellow";
        Person mrA = new Person("Hoang", "hoang@gmail.com", 18);
        //mrA.name = "Hoang";//ko truy cap duoc vao thuoc tinh name(vi private)
        //public, private, default,... goi la "access modifier"
        System.out.println(String.format("mrA'name is : %s", mrA.getName()));
        System.out.println(String.format("mrA'email is : %s", mrA.getEmail()));
        System.out.println(String.format("mrA'age is : %d", mrA.getAge()));
        //System.out.println("mrA detail : "+mrA);//ko hien thong tin chi tiet
        //muon hien ? Phai viet ham(method)
        System.out.println("mrA's detail is :");
        //neu co ...100 fields ?
        mrA.showDetailInformation();
        //con cach khac de hien thong tin doi tuong ? Yes
        System.out.println("Hien thong tin dung phuong thuc toString");
        System.out.println(mrA.toString());
        Point p1 = new Point(2.0, 1.0);
        Point p2 = new Point(6.0,4.0);
        //Double distance = Math.sqrt(Math.pow(p1.getX() - p2.getX(), 2) + Math.pow(p1.getY() - p2.getY(), 2));
        Double distance = p2.getDistance(p1);
        System.out.println("distance between p1 and p2 : "+distance);
        //viet cach khac nhin tuong minh hon ?
        Line lineAB = new Line(p1, p2);
        System.out.println(String.format("length of AB is : %f", lineAB.getLength()));
        System.out.println(lineAB.toString());
        Point p3 = Point.input();
        Point p4 = Point.input();
        Line lineCD = new Line(p3, p4);
        System.out.println("haha");
    }
}
