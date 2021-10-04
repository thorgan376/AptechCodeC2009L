<?php
const SERVER_NAME = "localhost";
const DB_NAME = "abc12";
const DB_USERNAME = "root";
const DB_PASSWORD = ""; //xml, json 
class Database {
    
    private $connection;
    //ham khoi tao
    public function __construct(){
        try {
            //$connectionString = "mysql:host=".SERVER_NAME.";dbname=".DB_NAME;
            $connectionString = "mysql:host=".SERVER_NAME;
            //PDO PHP Data Object
            $this->connection = new PDO($connectionString, DB_USERNAME, DB_PASSWORD);
            //echo "<h1>Connect DB successfully</h1>";
            $this->createDatabaseAndTables();
        }catch(PDOException $exception) {
            //echo "Error connect to DB: ".$exception->getMessage();
            $connectionString = NULL;
        }
        //
    }
    //ham tao table
    public function createDatabaseAndTables(){
        //in theory
        //Gui cau lenh SQL 
        try {
            $sql = "CREATE DATABASE IF NOT EXISTS ".DB_NAME;
            $this->connection->exec($sql);
            $sql = "use ".DB_NAME;
            $this->connection->exec($sql);
            $sql = "CREATE TABLE IF NOT EXISTS abc12users (".
                "USERNAME VARCHAR(200) NOT NULL UNIQUE,".
                "PASSWORD_HASH CHAR(100) NOT NULL,".
                "PHONE VARCHAR(10)".
            ");";
            $this->connection->exec($sql);//execute 
            //echo "createDatabaseAndTables success";
            //exec = execute
        }catch(PDOException $exception) {
            echo "Error createDatabaseAndTables: ".$exception->getMessage();
            $this->connection = null;
        }
    }
    public function registerUser($username, $password, $phone){
        //dang ky thanh cong => tra ve true
        //neu ko thanh cong, tra ve false
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
                    //echo "The user exists";
                    //return FALSE;//tra ve ket qua(true / false) VA "tai sao loi"
                    //ham se tra ve 3 gia tri ?
                    //Cach 1:
                    //tra ve 1 object co 3 thuoc tinh: result: true/false
                    //errorMessage: "The user exists"
                    //errorCode: 300, 301, do ta tu dinh nghia
                    //goi doi tuong nay la Response
                    //Cach 2: cho cac thuoc tinh errorMessage,errorCode, result vao 1 
                    //associative array (json object)
                    
                    //return new Response(FALSE, 300, "User exists");//cach 1
                    //Cach 2: dung associative array
                    return array(   "result" => FALSE, 
                                    "errorCode" => 300, 
                                    "errorMessage" => "User exists" 
                    );
                }     
            }
                
            $sql = "INSERT INTO abc12users(USERNAME, PASSWORD_HASH, PHONE)".
                    " VALUES(:username, :password, :phone)";
            $stmt = $this->connection->prepare($sql);
            $hash_password = sha1($password);            
            $stmt->bindParam(':username', $username);
            $stmt->bindParam(':password', $hash_password);
            $stmt->bindParam(':phone', $phone);
            $stmt->execute();
            
            //echo "register user successful";
            //exec = execute                        
            //return new Response(TRUE, 200, "Insert user successfully");//cach 1
            //cach 2: 
            return array(   "result" => TRUE, 
                             "errorCode" => 200, 
                             "errorMessage" => "Insert user successfully"
                    );
        }catch(PDOException $exception) {
            //echo "Error createDatabaseAndTables: ".$exception->getMessage();
            //return new Response(FALSE, 300, $exception->getMessage());//cach 1
            //cach 2
            $this->connection = null;
            return array("result" => FALSE, 
                        "errorCode" => 300, 
                        "errorMessage" => $exception->getMessage()
                    );
        }
    }
    public function changePassword($username, $currentPassword, $newPassword){
        //dang ky thanh cong => tra ve true
        //neu ko thanh cong, tra ve false
        try {
            //check ton tai
            $sql = "SELECT COUNT(*) AS numberOfUsers FROM abc12users".
                   " WHERE USERNAME = :username AND PASSWORD_HASH = :currentPassword";
            $stmt = $this->connection->prepare($sql);
            $stmt->bindParam(':username', $username);
            $currentPasswordHash = sha1($currentPassword);
            $stmt->bindParam(':currentPassword', $currentPasswordHash);            

            $stmt->setFetchMode(PDO::FETCH_ASSOC);
            $stmt->execute();
            $resultSet = $stmt->fetchAll();
            foreach ($resultSet as $row) {
                $count = intval($row["numberOfUsers"]);
                if($count == 0) {                    
                    return array("result" => FALSE, 
                                    "errorCode" => 306, 
                                    "errorMessage" => "Old password/username wrong" 
                    );
                }    
            }
                
            $sql = "UPDATE abc12users SET PASSWORD_HASH = :newPasswordHash ".
                    " WHERE USERNAME = :username AND PASSWORD_HASH = :currentPasswordHash";
            $stmt = $this->connection->prepare($sql);                
            
            $newPasswordHash = sha1($newPassword);
            $stmt->bindParam(':username', $username);
            $stmt->bindParam(':newPasswordHash', $newPasswordHash);
            $stmt->bindParam(':currentPasswordHash', $currentPasswordHash);
            
            $stmt->execute();        
            return array(   "result" => TRUE, 
                             "errorCode" => 200, 
                             "errorMessage" => "Change password successfully"
                    );
        }catch(PDOException $exception) {
            $this->connection = null;
            return array("result" => FALSE, 
                        "errorCode" => 300, 
                        "errorMessage" => $exception->getMessage()
                    );            
        }
              
    }
    public function loginUser($username, $password){
        //dang ky thanh cong => tra ve true
        //neu ko thanh cong, tra ve false
        try {
            //check ton tai
            $sql = "SELECT COUNT(*) AS numberOfUsers FROM abc12users".
                   " WHERE USERNAME = :username AND PASSWORD_HASH = :password";
                   //sql injection
            //tren mysql se nhan dc cau lenh:
            //select count(*) as numberOfUsers from 
            //abc12users where USERNAME = 'hoang1' and PASSWORD_HASH = 'dnbvcdfdygfydgf87348'
            $hash_password = sha1($password);                    
            $stmt = $this->connection->prepare($sql);
            $stmt->bindParam(':username', $username);
            $stmt->bindParam(':password', $hash_password);
            $stmt->setFetchMode(PDO::FETCH_ASSOC);
            $stmt->execute();
            $resultSet = $stmt->fetchAll();//statement
            foreach ($resultSet as $row) {
                $count = intval($row["numberOfUsers"]);
                if($count > 0) { 
                    //associative array
                    //"name" => "Hoang", "age" => 20
                    //["AN", "Hoang", "John"]                  
                    return array(   "result" => TRUE, 
                                    "errorCode" => 400, 
                                    "errorMessage" => "Login successfully" 
                    );
                }     
            } 
            return array("result" => FALSE, 
                             "errorCode" => 301, 
                             "errorMessage" => "Wrong username or password"
                    );
        }catch(PDOException $exception) {   
            $this->connection = null;            
            return array("result" => FALSE, 
                        "errorCode" => 300, 
                        "errorMessage" => $exception->getMessage()
                    );
        }
    }
    function generatePassword($length = 10) {
        $characters = '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ';
        $charactersLength = strlen($characters);
        $randomString = '';
        for ($i = 0; $i < $length; $i++) {
            $randomString .= $characters[rand(0, $charactersLength - 1)];
        }
        return $randomString;
    }
    public function resetUserPassword($username, $phone){
        //dang ky thanh cong => tra ve true
        //neu ko thanh cong, tra ve false
        try {
            //check ton tai
            $sql = "SELECT COUNT(*) AS numberOfUsers FROM abc12users".
                   " WHERE USERNAME = :username AND PHONE = :phone";            
            $stmt = $this->connection->prepare($sql);
            $stmt->bindParam(':username', $username);
            $stmt->bindParam(':phone', $phone);
            $stmt->setFetchMode(PDO::FETCH_ASSOC);                             
            $stmt->execute();
            $resultSet = $stmt->fetchAll();
            foreach ($resultSet as $row) {
                $count = intval($row["numberOfUsers"]);
                if($count > 0) {                    
                    //tu dong doi mat khau
                    $sql = "UPDATE abc12users SET PASSWORD_HASH = :hash_password".
                            " WHERE USERNAME = :username AND PHONE = :phone";
                            $password = $this->generatePassword(4);//password dai 4 ky tu
                            echo "new password: ".$password."<br>";
                            $hash_password = sha1($password);   

                            $stmt = $this->connection->prepare($sql);
                            $stmt->bindParam(':hash_password', $hash_password);
                            $stmt->bindParam(':username', $username);
                            $stmt->bindParam(':phone', $phone);
                            $stmt->execute();
                    return array(   "result" => TRUE, 
                                    "errorCode" => 400, 
                                    "errorMessage" => "Reset successfully" 
                    );
                }     
            } 
            return array("result" => FALSE, 
                             "errorCode" => 302, 
                             "errorMessage" => "Wrong username or phone");
        }catch(PDOException $exception) {    
            $this->connection = null;        
            return array("result" => FALSE, 
                        "errorCode" => 300, 
                        "errorMessage" => $exception->getMessage()
                    );
        }
    }
}
?>