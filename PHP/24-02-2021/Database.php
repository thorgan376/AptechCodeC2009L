<?php 
    define("HOST_NAME", "127.0.0.1");
    define("USER_NAME", "root");
    define("PASSWORD", "");
    define("DB_NAME", "C2009L");

    class Database {
        private $pdo;
        public function __construct() {            
            $connection_string = "mysql:host=".HOST_NAME.";dbname=".DB_NAME;
            $this->pdo = new PDO($connection_string, USER_NAME, PASSWORD);
            
        }
        //viet 1 ham lay ca thong sinh sach duoi database
        //tuc la gui lenh "SELECT * FROM tblBook xuong DB"
        public function get_all_books(){
            $sql_command = "SELECT * FROM tblBook;";            
            $statement = $this->pdo->query($sql_command);
            $result = $statement->fetchAll();
            print_r($result);
        }
    }
?>