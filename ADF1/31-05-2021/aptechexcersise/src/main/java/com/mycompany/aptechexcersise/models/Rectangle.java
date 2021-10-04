package com.mycompany.aptechexcersise.models;

public class Rectangle extends Shape {
    //ngoai name va color co them width, height
    private Double width;
    private Double height;
    public Rectangle(String name, String color, Double width, Double height) {
        super(name, color); //super => tham chieu den parent(Shape)
        this.width = width;
        this.height = height;
    }
    public void doSomething(){
        System.out.println("name = "+this.getName());
    }

    @Override
    public Double calculateArea() {
        return width * height;
    }
    //ko bat buoc thuc thi doXX
    //thu thi thi cung duoc
    @Override
    public void doXX() {
        //super.doXX();
        System.out.println("do xx(in Rectangle)");
    }

    @Override
    public String toString() {
        return super.toString() +
                "width=" + width +
                ", height=" + height;
    }
}
