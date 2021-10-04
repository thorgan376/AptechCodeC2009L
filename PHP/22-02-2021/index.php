<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Chao ban</h1>
    <?php
    require './person.php';
    require './student.php';
    require './calculation.php';
    $mr_hoang = new Person();
    $mr_hoang->name = "Hoangggg";
    $mr_hoang->age = 20;
    $mr_hoang->email = "abchoang@gmail.com";

    //Khoi tao doi tuong student
    $student_a = new Student(11, "nguyen", "van A", "male", "Vietnam");
    //tao ra 3 sinh vien, cho vao 1 array
    $student_b = new Student(22, "tran", "van B", "female", "China");
    $student_c = new Student(33, "nguyen", "van c", "male", "USA");
    // $students = array($student_a, $student_b, $student_c);
    //duyet(iterate) array chua 3 sinh vien nay ?
    unset($student_b);
    // foreach($students as $student) {
    //     print_r($student);
    // }

    //var_dump($students);
    // die();
    $my_calculation = new Calculation(2, 4);
    echo $my_calculation->sum(); echo "<br>";
    echo $my_calculation->substract(); echo "<br>";
    echo $my_calculation->multiply(); echo "<br>";
    echo $my_calculation->divide(); echo "<br>";
    /*
    for($i = 0; $i < count($numbers) - 1; $i++){
        for($j = $i + 1; $j < count($numbers); $j++){
            if($numbers[$i] > $numbers[$j]) {
                $temp = $numbers[$i];
                $numbers[$i] = $numbers[$j];
                $numbers[$j] = $temp;
            }
        }
    }
    */
    $numbers = array(9, 5, 6, 7, 8, 4);
    rsort($numbers);//reverse sort = rsort
    // var_dump($numbers);
    print_r($numbers);
    //ko can sap xep thu cong the , dung ham co san
    define("PI", 3.1416);
    $x = 10;
    $y = '10'; //bang nhau ve gia tri, khac nhau ve kieu
    $z = 10;
    echo "Gia tri cua x = ".$x.", gia tri y = ".$y;
    //so sanh gia tri
    if($x == $y) {
        echo "<p>Bang nhau ve kieu, khac nhau ve gia tri</p>";
    }
    var_dump($x);
    //die();//exit
    if($x === $z) {
        echo "<p>x, z Bang nhau ve kieu, BANG NHAU ve gia tri</p>";
    }
    echo "<h2>PI = ".PI."</h2>";//"const" donot contain "$"
    function sum2Numbers($x, $y) {
        return $x + $y;
    }
    echo "<h2>tong cua 2 va 3 la : ".sum2Numbers(2,3)."</h2>";
    
    foreach($numbers as $eachNumber) {
        echo "<h3>number = $eachNumber </h3>";
    }
    

    ?>
</body>
</html>