
/*
docker rm mysql-c2009l
docker run -d --name mysql-c2009l -p 3308:3306 -e MYSQL_ROOT_PASSWORD=123456 mysql:8.0.25
test: connect from host(laptop):
mysql -h localhost -P 3308 --protocol tcp -u root -p
CREATE TABLE tblProduct(
    productId INT PRIMARY KEY AUTO_INCREMENT,
    productName VARCHAR(200),
    year INT,
    categoryId INT,
    CONSTRAINT FK_ProductCategory FOREIGN KEY (categoryId)
    REFERENCES tblCategory(categoryId)
);
CREATE TABLE tblCategory(
    categoryId INT PRIMARY KEY AUTO_INCREMENT,
    categoryName VARCHAR(200),
    description VARCHAR(500)
);

* */


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import models.Category;
import models.Product;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

@SpringBootApplication
public class Main {
    private static final String PERSISTENCE_UNIT_NAME = "products";
    private static EntityManagerFactory factory;

    public static void main(String [] arguments) {
        System.out.println("JPA demo");
        try {
            factory = Persistence.createEntityManagerFactory("db_test");
            EntityManager entityManager  = factory.createEntityManager();
            entityManager.getTransaction().begin();
            //co the co nhieu len C U D
//            Product newProduct = new Product("iphone 8", 2018);
//            entityManager.persist(newProduct);

            Category category1 = new Category("Foods", "Do an thuc uong");
            Category category2 = new Category("Electronics", "Do dien tu");
            Product product1 = new Product("sushi", 2010);
            Product product2 = new Product("coca", 2012);
            Product product3 = new Product("eat something", 2009);
            Product product4 = new Product("laptop dell", 2015);
            Product product5 = new Product("iphone 6", 2016);
            product1.setCategory(category1);
            product2.setCategory(category1);
            product3.setCategory(category1);
            product4.setCategory(category2);
            product5.setCategory(category2);

            entityManager.persist(category1);
            entityManager.persist(category2);

            entityManager.persist(product1);
            entityManager.persist(product2);
            entityManager.persist(product3);
            entityManager.persist(product4);
            entityManager.persist(product5);

            entityManager.getTransaction().commit();
            entityManager.close();
            factory.close();
        }catch (Exception exception) {
            System.err.println("exception = "+exception);
        }
        //SpringApplication.run(Main.class, arguments);

    }
}
