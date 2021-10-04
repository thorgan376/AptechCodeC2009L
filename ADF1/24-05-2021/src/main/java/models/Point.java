package models;

import java.util.Scanner;

public class Point {
    private Double x, y;
    //ham constructor co tham so
    public Point(Double x, Double y) {
        this.x = x;
        this.y = y;
    }
    public Double getDistance(Point p) {
        return Math.sqrt(Math.pow(this.x - p.getX(), 2) + Math.pow(this.y - p.getY(), 2));
    }
    public Double getX() {
        return x;
    }

    public void setX(Double x) {
        this.x = x;
    }

    public Double getY() {
        return y;
    }

    public void setY(Double y) {
        this.y = y;
    }

    @Override
    public String toString() {
        return String.format("x = %3.2f, y = %3.2f", x, y);
    }
    //viet ham nhap x, y tu ban phim,
    //nhap xong thi khoi tao doi tuong Point
    //Luc nhap => doi tuong chua ton tai !
    public static Point input() {
        System.out.println("Enter detail point:");
        Scanner scanner = new Scanner(System.in);
        System.out.println("enter x:");
        Double x = scanner.nextDouble();
        System.out.println("enter y:");
        Double y = scanner.nextDouble();
        return new Point(x, y);//factory method
    }
}
