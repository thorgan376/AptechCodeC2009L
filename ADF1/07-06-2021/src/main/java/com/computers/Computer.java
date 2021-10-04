package com.computers;

import com.product.Product;

import java.util.Scanner;

public class Computer extends Product {
    private String speed;
    private String producer;
    public Computer() {
        //no argument
    }

    public Computer(String speed, String producer) {
        this.speed = speed;
        this.producer = producer;
    }

    public Computer(String proId, String proName, int year, int price,
                    String speed, String producer) {
        super(proId, proName, year, price);
        this.speed = speed;
        this.producer = producer;
    }

    public String getSpeed() {
        return speed;
    }

    public void setSpeed(String speed) {
        this.speed = speed;
    }

    public String getProducer() {
        return producer;
    }

    public void setProducer(String producer) {
        this.producer = producer;
    }

    @Override //@Override = thuc thi phuong thuc lop cha
    public void input() {
        System.out.println("Enter computer's ID: ");
        this.proId = getScanner().nextLine();
        System.out.println("Enter computer's name:");
        this.proName = getScanner().nextLine();
        System.out.println("Enter year : ");
        this.year = getScanner().nextInt();

        System.out.println("Enter price : ");
        this.price = getScanner().nextFloat();

        System.out.println("Enter computer's speed: ");
        this.speed = getScanner().nextLine();

        System.out.println("Enter computer's producer: ");
        this.producer = getScanner().nextLine();
    }


    @Override
    public void display() {
        System.out.println("Computer information: ");
        System.out.println(String.format(
                "id: %s, name: %s, year: %d, price : %f, speed: %s, producer : %s",
                this.proId, this.proName, this.year, this.price, this.speed, this.producer
                ));
    }
}
