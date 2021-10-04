
//khac voi C, khac voi Javascript
public class App {
    public static void main(String[] args) {
        //cac kieu du lieu nguyen thuy = primitive value type
        int x = 10;

        float y = 120.3f;
        double z = 1234.67;
        long creditCardNumber = 1245_9876_6543_2345L;
        //kieu du lieu object cua Java:
        Integer x1 = 123;
        //System.out.println("x = "+x+", y = "+y);//cach 1
        System.out.println(String.format("Gia tri cua x = %d, y = 5f", x, y));
        System.out.println(String.format("z = %d", creditCardNumber));
        System.out.println("max int = "+Integer.MAX_VALUE+", min int = "+Integer.MIN_VALUE);
        System.out.println("max float = "+Float.MAX_VALUE+", min float = "+Float.MIN_VALUE);
        System.out.println("max double = "+Double.MAX_VALUE+", min double = "+Double.MIN_VALUE);
        Calculation calculation = new Calculation(); //tao doi tuong calculation(cap phat bo nho)
        //Calculation calculation2 = new Calculation();
        //Calculation calculation3 = new Calculation();
        System.out.println("sum 20 and 30 is : "+calculation.sum(20, 30));
        System.out.println("divide 20 and 10 is : "+calculation.divide(20, 0));
        calculation.doSomething();
    }
}
