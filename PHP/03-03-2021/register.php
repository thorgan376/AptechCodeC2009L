<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="./register.php" method="post">
        <p>Username: </p>
        <input type="text" name="username" id="username" 
            placeholder="Enter username"><br>
        <p>Password: </p><input type="password" name="password" id="password" 
            placeholder="Enter password"><br>
        <p>Phone: </p><input type="text" name="phone" id="phone" 
            placeholder="Enter phone"><br>
        <input type="submit" value="Registration">
    </form>
    <?php
        require "./Database/Database.php";
        if(isset($_POST["username"]) == true) {
            $username = $_POST["username"];
            $password = $_POST["password"];
            $phone = $_POST["phone"];
            $database = new Database();
            $database->registerUser($username, $password, $phone);
        }
    ?>
</body>
</html>