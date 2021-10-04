<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        var_dump(getdate());
        echo "haha";
        $timestamp = time()+date("Z");
        echo gmdate("Y/m/d H:i:s",$timestamp);
        echo "hehee";
        //header("Location: ./something.php");
        var_dump(intdiv(5, 2));
    ?>
</body>
</html>