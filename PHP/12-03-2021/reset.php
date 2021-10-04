<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Reset password</h1>
    <form action="./reset.php" method="post">
        <p>Username: </p>
        <input type="text" name="username" id="username" 
            placeholder="Enter username"><br>
        <p>Phone: </p><input type="text" name="phone" id="phone" 
            placeholder="Enter phone"><br>        
        <input type="submit" value="Reset password">
    </form>
    <?php
        require "./models/Response.php";
        require "./Database/Database.php";
        if(isset($_POST["username"]) == true) {
            $username = $_POST["username"];
            $phone = $_POST["phone"];            
            $database = new Database();
            $response = $database->resetUserPassword($username, $phone);    
            /*
            //cach 1            
            if($response->getResult() == TRUE) {

            } else {
                echo $response->getErrorMessage();
            }
            */
            //Cach 2: dung associative array
            if($response["result"] == TRUE) {
                echo "Reset successfully";
            } else {
                echo $response["errorMessage"];
            }
        }
    ?>
</body>
</html>