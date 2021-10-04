<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Login form</h1>
    <form action="./login.php" method="post">
        <p>Username: </p>
        <input type="text" name="username" id="username" 
            value=<?php echo(isset($_COOKIE["username"]) == true ? $_COOKIE["username"] : "") ?>
            placeholder="Enter username"><br>
        <p>Password: </p><input type="password" name="password" id="password" 
            value=<?php echo isset($_COOKIE["password"]) == true ? $_COOKIE["password"] : ""?>
            placeholder="Enter password"><br>        
        <input type="checkbox" id="rememberMe" name="rememberMe" value="1">
            <label for="rememberMe"> Remember me</label><br>
        <input type="submit" value="Log in">
        
    </form>
    <?php
        require "./models/Response.php";
        require "./Database/Database.php";
        session_start();
        if(isset($_SESSION["isLoggedIn"]) == true) {
            if($_SESSION["isLoggedIn"] == TRUE) {
                header("Location: ./welcome.php");
                return;
            }
        }        
        if(isset($_POST["username"]) == true) {
            $username = $_POST["username"];
            $password = $_POST["password"];            
            $database = new Database();
            $response = $database->loginUser($username, $password);    
            /*
            //cach 1            
            if($response->getResult() == TRUE) {

            } else {
                echo $response->getErrorMessage();
            }
            */  
            
            if(isset($_POST["rememberMe"]) == true) {
                $rememberMe = $_POST["rememberMe"];                               
                if($rememberMe == "1") {
                    setcookie("username", $username, time() + (86400 * 30), "/");
                    setcookie("password", $password, time() + (86400 * 30), "/");                    
                    if($response["result"] == true) {
                        //$_SESSION["isLoggedIn"] = TRUE;                        
                        header("Location: ./welcome.php");                
                    } else {
                        echo $response["errorMessage"];
                        //$_SESSION["isLoggedIn"] = FALSE;
                    }
                }
            }
                                    
        }
    ?>
</body>
</html>