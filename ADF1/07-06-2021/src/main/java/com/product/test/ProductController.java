package com.product.test;

import com.computers.Computer;
import com.product.Product;
import com.product.books.Book;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.Scanner;

public class ProductController {
    private Scanner scanner = new Scanner(System.in);
    private ArrayList<Computer> computers = new ArrayList<Computer>();
    private ArrayList<Book> books = new ArrayList<Book>();
    public void inputBooks() {
        System.out.println("Enter number of books: ");
        int numberOfBooks = scanner.nextInt();
        for (int i = 0; i < numberOfBooks; i++){
            Book book = new Book();
            book.input();
            books.add(book);
        }
    }
    public void inputComputers() {
        System.out.println("Enter number of computers: ");
        int numberOfComputers = scanner.nextInt();
        for (int i = 0; i < numberOfComputers; i++){
            Computer computer = new Computer();
            computer.input();
            computers.add(computer);
        }
    }
    public void sortComputersByPrice() {
        //cach dung interface
        /*
        this.computers.sort(new Comparator<Computer>() {
            @Override
            public int compare(Computer computer1, Computer computer2) {
                return computer1.getPrice() - computer2.getPrice() > 0 ? 1 : -1;
            }
        });
        */
        //cach 2 - dung bieu thuc lambda(Java > 1.8)
//        String proId, String proName, int year, int price,
//        String speed, String producer
        this.computers.sort((Computer computer1, Computer computer2)
                -> computer1.getPrice() - computer2.getPrice() < 0 ? 1 : -1);
        for(Computer computer: this.computers) {
            computer.display();
        }
    }
    public void sortBooksByPublisher() {
        this.books.sort((Book book1, Book book2)
                -> book1.getPublisher().compareTo(book2.getPublisher()));
        for(Book book: this.books) {
            book.display();
        }
    }
}
