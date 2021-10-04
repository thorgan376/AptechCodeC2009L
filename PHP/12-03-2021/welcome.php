<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Login successfully</h1>
    <form action="./welcome.php" method="POST">
        <input type="submit" value="Logout" name="submit">        
    </form>
    <?php
            session_start();            
            if (isset($_POST['submit'])) {
                $_SESSION["isLoggedIn"] = FALSE;
                header("Location: ./login.php");
            }            
    ?>
</body>
</html>