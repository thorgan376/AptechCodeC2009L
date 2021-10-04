package controllers;

import models.CompactDisk;
import models.SortType;
import validations.Validation;

import java.util.ArrayList;
import java.util.Scanner;

public class CDController {
    private int maxItems = 4;
    public Scanner getScanner() {
        return new Scanner(System.in);
    }
    //array de luu danh sach doi tuong CD them vao
    private ArrayList<CompactDisk> compactDisks = new ArrayList<>();
    public void insertCD() {
        System.out.println("Enter id : ");
        String strID = this.getScanner().next();
        //viet cach basic
        /*
        if(!Validation.isValidID(id)) {
            System.err.println("Id must be from 0 to 1000000");
            return;
        }
        */
        if(!Validation.isValidID(strID)) {
            System.err.println("Id must be from 0 to 1000000, must be number");
            return;
        }
        int id = Integer.valueOf(strID);
        System.out.println("Enter title : ");
        String title = this.getScanner().next();
        //lam tuong tu
        System.out.println("Enter artist : ");
        String artist = this.getScanner().next();

        System.out.println("Enter number of songs: ");
        int numberOfSongs = this.getScanner().nextInt();

        System.out.println("Enter price : ");
        Double price = this.getScanner().nextDouble();

        CompactDisk compactDisk = new CompactDisk(id, title, artist,numberOfSongs ,price);
        //kiem tra, validate
        if(this.compactDisks.size() >= maxItems) {
            return;
        }
        for(CompactDisk eachCD: this.compactDisks) {
            if(eachCD.getId() == compactDisk.getId()) {
                System.err.println("The CD has dublicated id");
                return;
            }
        }
        this.compactDisks.add(compactDisk);
    }
    public int getNumberOfCDs() {
        return this.compactDisks.size();
    }
    public Double getTotalPrice() {
        Double total = 0.0;
        for(int i = 0; i < this.compactDisks.size(); i++) {
            CompactDisk compactDisk = this.compactDisks.get(i);
            total += compactDisk.getPrice();
        }
        return total;
    }
    public void sort(SortType sortType) {
        //0 la tang dan, 1 la giam dan => ko nen lam cach nay
        if(sortType == SortType.ASCENDING) {
            this.compactDisks.sort( (CompactDisk item1, CompactDisk item2) ->
                    item1.getCdTitle().compareTo(item2.getCdTitle()));
        }else if(sortType == SortType.DESCENDING) {
            //test roi viet tiep
        }
    }
    public void showAllCDs() {
        int index = 0;
        for(CompactDisk compactDisk: this.compactDisks) {
            index ++;
            System.out.println(String.format("%d. %s", index, compactDisk.toString()));
        }
    }
    public void showMenu() {
        System.out.println("--------------------------------------------");
        System.out.println("1. Insert a CD");
        System.out.println("2. Show all CDs");
        System.out.println("3. Show total price");
        System.out.println("4. Exit");
        System.out.println("--------------------------------------------");
        int choice = 0;
        do {
            System.out.println("Enter your choice: ");
            choice = this.getScanner().nextInt();
            switch (choice) {
                case 1:
                    this.insertCD();
                    break;
                case 2:
                    this.showAllCDs();
                    break;
                case 3:
                    System.out.println(String.format("Total price = %f", this.getTotalPrice()));
                    break;
                default:
                    if(choice != 4) {
                        System.out.println("Please enter 1, 2, 3, 4");
                    }
                    break;
            }
        }while (choice != 4);
        System.out.println("Program ended");



    }
}
