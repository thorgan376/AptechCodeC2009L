<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
    <?php
        $x = 10;
        $y = 20;
        echo '<h1>Gia tri cua x la : '.$x.', gia tri y = '.$y.'</h1>'; //string concatenation
        $name = 'Hoang';
        $age = 18;
        echo "ten : $name, tuoi = $age";
        //reference
        $x1 = 12;
        $x2 = $x1;
        $x3 = &$x1;        
        $x1 = 13;

        
        echo '<p>x2 ======  '.$x2.'x3 = '.$x3.'</p>';
        print_r('<p>x2 ======  '.$x2.'x3 = '.$x3.'</p>');//print result = print_r
        var_dump($x1);
        $str1 = 'Chao moi nguoi';
        echo strtoupper($str1);
        $str2 = 'John';
        $str3 = 'JoHn';
        if(strtolower($str2) == strtolower($str3)) {
            echo '2 anh bang nhau ve gia tri';
        }
        $a = 10;
        $b = '10';
        if($a === $b) {
            echo 'haha';
        } else {
            echo 'hehe';
        }

    ?>
</body>
</html>