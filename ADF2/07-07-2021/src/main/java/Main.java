public class Main {
    public static void main(String [] args) {
        Number number = new Number();
        number.saveToFile();
        OddEven oddEven = new OddEven();
        oddEven.create2Files();
        oddEven.saveTo2Files();
    }
}
