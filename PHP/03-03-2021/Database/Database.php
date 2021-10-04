<?php
const SERVER_NAME = "localhost";
const DB_NAME = "abc12";
const DB_USERNAME = "root";
const DB_PASSWORD = "";
class Database {
    
    private $connection;
    //ham khoi tao
    public function __construct(){
        try {
            //$connectionString = "mysql:host=".SERVER_NAME.";dbname=".DB_NAME;
            $connectionString = "mysql:host=".SERVER_NAME;
            $this->connection = new PDO($connectionString, DB_USERNAME, DB_PASSWORD);
            echo "<h1>Connect DB successfully</h1>";
            $this->createDatabaseAndTables();
        }catch(PDOException $exception) {
            echo "Error connect to DB: ".$exception->getMessage();
            $connectionString = NULL;
        }
        //
    }
    //ham tao table
    public function createDatabaseAndTables(){
        //Gui cau lenh SQL 
        try {
            $sql = "CREATE DATABASE IF NOT EXISTS abc12";
            $this->connection->exec($sql);
            $sql = "use abc12;";
            $this->connection->exec($sql);
            $sql = "CREATE TABLE IF NOT EXISTS abc12users (".
                "USERNAME VARCHAR(200) NOT NULL UNIQUE,".
                "PASSWORD_HASH CHAR(100) NOT NULL,".
                "PHONE VARCHAR(10)".
            ");";
            $this->connection->exec($sql);
            echo "createDatabaseAndTables success";
            //exec = execute
        }catch(PDOException $exception) {
            echo "Error createDatabaseAndTables: ".$exception->getMessage();
        }
    }
    public function registerUser($username, $password, $phone){
        try {
            //check ton tai
            $sql = "SELECT COUNT(*) AS numberOfUsers FROM abc12users".
                   " WHERE USERNAME = :username";
            $stmt = $this->connection->prepare($sql);
            $stmt->bindParam(':username', $username);
            $stmt->setFetchMode(PDO::FETCH_ASSOC);
            $stmt->execute();
            $resultSet = $stmt->fetchAll();
            foreach ($resultSet as $row) {
                $count = intval($row["numberOfUsers"]);
                if($count > 0) {
                    echo "The user is exists";
                    return;
                }     
            }
                
            $sql = "INSERT INTO abc12users(USERNAME, PASSWORD_HASH, PHONE)".
                    " VALUES(:username, :password, :phone)";
            $stmt = $this->connection->prepare($sql);
            $stmt->bindParam(':username', $username);
            $stmt->bindParam(':password', $password);
            $stmt->bindParam(':phone', $phone);
            $stmt->execute();
            
            echo "register user successful";
            //exec = execute
        }catch(PDOException $exception) {
            echo "Error createDatabaseAndTables: ".$exception->getMessage();
        }
    }
}
?>