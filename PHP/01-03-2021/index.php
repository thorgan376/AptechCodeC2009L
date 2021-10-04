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
        require "./Employee.php";
        require "./Settings.php";
        echo "<h1>tim hieu ve variables</h1>";
        function doSomething() {
            //global $x;
            $GLOBALS["x"] = 10;
            $GLOBALS["y"] = 20;
            // print_r($GLOBALS["x"]);
        }
        doSomething();
        // print_r($GLOBALS["x"]);
        //in ca doi tuong $GLOBALS ra
        print_r($GLOBALS);
        //echo "base salary of mr Aaa= ".Employee::$BASE_SALARY;
        $employeeA = new Employee("nv a", 18);
        $employeeB = new Employee("nv b", 19);
        
        //neu muon them doi tuong => employeeA, B, C....1000 nhan vien
        //1000 nhan vien nay co thuoc tinh BASE_SALARY giong nhau 

        //echo "server's name = ".Settings::SERVER_NAME.", port is : ".Settings::PORT;
        //var_dump($_SERVER);
        // phpinfo();
        //=== va == khac nhau ntn ?
        //== so sanh bang nhau ve "noi dung"
        //=== so sanh bang nhau ve "noi dung" VA "kieu"
        $x = "123";
        $y = "123";
        if($x === $y) {
            echo "BANG nhau";
        }
        //=== tot hon hay == ?
        //=== chat che hon 
        //tren thuc te thi tuy tung truong hop ma dung ===, ==
        $age = 20;
        $grade = 9.0;
        $isYoung = $age > 20 and $age < 4;
        $goodAtSchool = $grade > 8.0;
        if($isYoung and $goodAtSchool) {
            echo "ok !";
        }

    ?>
</body>
</html>