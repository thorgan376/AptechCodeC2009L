package models;
public class Product {
    //mot so cac thuoc tinh(field)
    public String name;
    public Integer year;
    public String color;
    //constructor giong ten class
    public Product(String name, Integer year, String color) {
        this.name = name;
        this.year = year;
        this.color = color;
    }
    //default constructor
    public Product() {
        this.name = "";
        this.year = 0;
        this.color = "";
    }
}
