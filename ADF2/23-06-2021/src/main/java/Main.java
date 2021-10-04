
/*
docker rm mysql-c2009l
docker run -d --name mysql-c2009l -p 3308:3306 -e MYSQL_ROOT_PASSWORD=123456 mysql:8.0.25
test: connect from host(laptop):
mysql -h localhost -P 3308 --protocol tcp -u root -p
CREATE TABLE tblProduct(
    productId INT PRIMARY KEY AUTO_INCREMENT,
    productName VARCHAR(200),
    year INT
);
* */

import models.Product;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

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
            EntityManagerFactory factory = Persistence.createEntityManagerFactory("db_test");
            EntityManager entityManager = factory.createEntityManager();

            entityManager.getTransaction().begin();
            Product newProduct = new Product("iphone 8", 2018);
            entityManager.persist(newProduct);
            entityManager.getTransaction().commit();
            entityManager.close();
            factory.close();
        }catch (Exception exception) {
            System.err.println("exception = "+exception);
        }
        //SpringApplication.run(Main.class, arguments);

    }
}
