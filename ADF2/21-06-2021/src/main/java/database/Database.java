package database;

import models.Product;

import java.sql.*;
import java.util.ArrayList;
import java.util.PropertyPermission;
/*
docker rm -f mysql8-container
docker run -d -v ~/Documents/c2002l-mysql-volume:/var/lib/mysql \
--name mysql8-container \
-e MYSQL_ROOT_PASSWORD=123456 \
-p 3308:3306 \
mysql:8.0
Connect mysql tu host(laptop):
mysql -h localhost -P 3308 --protocol tcp -u root -p

// => docker compose
//container orchestration tool (Kubenetes cluster, Docker swarm, Mesos)
 */
public class Database {
    public static String HOST_NAME = "localhost";
    public static Integer PORT = 3308;
    public static String DB_NAME = "db_test";
    public static String DB_USER_NAME = "root";
    public static String DB_PASSWORD = "123456";
    private static Database instance = null;
    private Database() {};
    public static Database getInstance() {
        if(instance == null) {
            instance = new Database();
        }
        return instance;
    }
    public Connection getConnection() {
        try {
            //Class.forName("com.mysql.jdbc.Driver"); //com.mysql.cj.jdbc.Driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            String urlConnection = String.format("jdbc:mysql://%s:%d/%s",HOST_NAME, PORT, DB_NAME);
            return DriverManager.getConnection(urlConnection,DB_USER_NAME,DB_PASSWORD);
        }catch (Exception exception) {
            System.out.println("Error connect DB"+exception.toString());
            return null;
        }
    }
    public long insertProduct(Product product) {
        String sqlString = "INSERT INTO tblProduct(productName, year) "
                + "VALUES(?, ?)";
        long productId = 0;
        try (
                PreparedStatement preparedStatement = this.getConnection().prepareStatement(sqlString,
                        Statement.RETURN_GENERATED_KEYS)) {
            preparedStatement.setString(1, product.getProductName());
            preparedStatement.setInt(2, product.getYear());
            int affectedRows = preparedStatement.executeUpdate();
            // check the affected rows
            if (affectedRows > 0) {
                // get the ID back
                try (ResultSet resultSet = preparedStatement.getGeneratedKeys()) {
                    if (resultSet.next()) {
                        productId = resultSet.getLong(1);
                    }
                } catch (SQLException ex) {
                    System.out.println(ex.getMessage());
                }
            }
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
        }
        return productId;
    }
    public void updateProduct(Integer productId, Product product) {
        String sqlString = "UPDATE tblProduct SET productName = ?, year = ? WHERE id = ?";
        try (PreparedStatement preparedStatement = this.getConnection().prepareStatement(sqlString)) {
            preparedStatement.setString(1, product.getProductName());
            preparedStatement.setInt(2, product.getYear());
            preparedStatement.setInt(3, productId);
            preparedStatement.executeUpdate();

            System.out.println("Update product successfully");
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
        }
    }
    public ArrayList<Product> searchProducts(String text) {
        ArrayList<Product> products = new ArrayList<>();
        try {
            String sqlString = "SELECT id, productName, year FROM tblProduct WHERE productName LIKE '%"+text+"%' LIMIT 100";
//            String sqlString = "SELECT id, productName, year FROM tblProduct WHERE productName LIKE '%%?%%' LIMIT 100";
            PreparedStatement statement = getConnection().prepareStatement(sqlString);
            //statement.setString(1, text);
            ResultSet resultSet = statement.executeQuery();
            while (resultSet.next()) {
                long id = resultSet.getLong(1);
                String productName = resultSet.getString(2);
                Integer year = resultSet.getInt(3);
                products.add(new Product(id, productName, year));
            }
            System.out.println("Query product successfully");
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
        }
        return products;
    }
    public void deleteProduct(Integer productId) {
        String sqlString = "DELETE FROM tblProduct WHERE id = ?";
        try (PreparedStatement preparedStatement = this.getConnection().prepareStatement(sqlString)) {
            preparedStatement.setInt(1, productId);
            preparedStatement.executeUpdate();
            System.out.println("Delete product successfully");
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
        }
    }

}