package models;

import javax.persistence.*;
import java.util.HashSet;
import java.util.Set;

@Entity // This tells Hibernate to make a table out of this class
@Table(name = "tblCategory")
public class Category {
    @Id
    //@GeneratedValue(strategy=GenerationType.AUTO)
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer categoryId;
    private String categoryName;
    private String description;

//    //Foreign keys
    @OneToMany(cascade = CascadeType.ALL)
    @JoinColumn(name = "productId")
    private Set<Product> products = new HashSet<>();

    public Category(String categoryName, String description) {
        this.categoryName = categoryName;
        this.description = description;
    }
    public Integer getCategoryId() {
        return categoryId;
    }

    public void setCategoryId(Integer categoryId) {
        this.categoryId = categoryId;
    }

    public String getCategoryName() {
        return categoryName;
    }

    public void setCategoryName(String categoryName) {
        this.categoryName = categoryName;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }
}
