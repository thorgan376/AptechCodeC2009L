package models;

import javax.persistence.*;

@Entity // This tells Hibernate to make a table out of this class
@Table(name = "tblProduct")
public class Product {
    @Id
    //@GeneratedValue(strategy=GenerationType.AUTO)
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer productId;
    private String productName;
    private Integer year;

    public Product(String productName, Integer year) {
        this.productName = productName;
        this.year = year;
    }
    public Integer getProductId() {
        return productId;
    }

    public void setProductId(Integer productId) {
        this.productId = productId;
    }

    public String getProductName() {
        return productName;
    }

    public void setProductName(String productName) {
        this.productName = productName;
    }

    public Integer getYear() {
        return year;
    }

    public void setYear(Integer year) {
        this.year = year;
    }
}
