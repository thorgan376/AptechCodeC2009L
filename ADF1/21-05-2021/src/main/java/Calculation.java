public class Calculation {
    //thuc hien cong, tru, nhan, chia
    //Moi class la 1 file .java
    public Integer sum(Integer x, Integer y) {
        return x + y;
    }
    public Integer minus(Integer x, Integer y) {
        return x - y ;
    }
    public Integer multiply(Integer x, Integer y) {
        return x * y;
    }
    public Integer divide(Integer x, Integer y) {
        return y == 0 ? 0  : x / y; //neu nhap y = 0, chuong trinh se crash
        //return  x / y;
    }
    public void doSomething() {
        System.out.println("do something");
        //for loop giong C
        for(int i = 0; i < 100_000_000; i++) {
            System.out.print(String.format("i = %d, ", i));
            if(i % 9 == 0) {
                System.out.println();
            }
        }
    }
}
