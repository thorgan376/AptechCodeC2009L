package models;

public class Calculation {
    private Double x;
    private Double y;
    public Calculation(Double x, Double y) {
        this.x = x;
        this.y = y;
    }
    public Double divide() {
        try {
            Double z = null;
            System.out.println("z = "+z.toString());
            return x / y;//ko bao loi
        }catch (Exception e) {
            return  0.0;
        } finally {
            //don dep
            System.out.println("haha");
        }

    }
}
