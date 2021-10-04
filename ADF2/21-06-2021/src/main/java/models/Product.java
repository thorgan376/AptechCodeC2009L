package models;
/*
CREATE TABLE tblProduct(
    id INTEGER AUTO_INCREMENT PRIMARY KEY,
    productName VARCHAR(300),
    year int
);
INSERT INTO tblProduct(productName,year)
VALUES("iphone 8", 2018);
* */

public class Product {
    private Long id;
    private String productName;
    private int year;

    //Builder Pattern
    public Product(String productName, int year) {
        this.productName = productName;
        this.year = year;
    }
    //overload constructor
    public Product(Long id, String productName, int year) {
        this.id = id;
        this.productName = productName;
        this.year = year;
    }


    public String getProductName() {
        return productName;
    }

    public void setProductName(String productName) {
        this.productName = productName;
    }

    public int getYear() {
        return year;
    }

    public void setYear(int year) {
        this.year = year;
    }

    @Override
    public String toString() {
        return "Product{" +
                "id=" + id +
                ", productName='" + productName + '\'' +
                ", year=" + year +
                '}';
    }
}
