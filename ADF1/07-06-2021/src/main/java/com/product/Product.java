package com.product;

import java.util.Scanner;

public abstract class Product {
    protected String proId;
    protected String proName;
    protected int year;
    protected float price;
    //moi lan nhap tao 1 doi tuong scanner moi
    //=> dung ham getter sinh ra doi tuong moi lan goi
    protected Scanner getScanner() {
        return new Scanner(System.in);
    }
    //default constructor
    public Product() {
        proId = "";
        proName = "";
        year = 0;
        price = 0.0f;
    }
    //constructor co tham so
    public Product(String proId, String proName, int year, int price) {
        this.proId = proId;
        this.proName = proName;
        this.year = year;
        this.price = price;
    }

    public String getProId() {
        return proId;
    }

    public void setProId(String proId) {
        this.proId = proId;
    }

    public String getProName() {
        return proName;
    }

    public void setProName(String proName) {
        this.proName = proName;
    }

    public int getYear() {
        return year;
    }

    public void setYear(int year) {
        this.year = year;
    }

    public float getPrice() {
        return price;
    }

    public void setPrice(float price) {
        this.price = price;
    }

    public abstract void input();
    public abstract void display();
}
