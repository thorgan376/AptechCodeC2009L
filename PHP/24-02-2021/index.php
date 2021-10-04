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
        require './MyCircle.php';
        require './Rectangle.php';
        require './Database.php';
        //test mysql database        
        $database = new Database();
        $database->get_all_books();
        die();
        $rectangle1 = new Rectangle();        
        $rectangle1->set_width(12);
        $rectangle1->set_height(13);
        $rectangle1->show_something();  
        echo "<h1>dien tich hcn = ".$rectangle1->get_area()."</h1>";  
        die();
        $circle1 = new MyCircle(10.0, "green");
        $circle2 = new MyCircle(20.0, "blue");
        $circle3 = new MyCircle(30.0, "red");
        MyCircle::do_something2();
        die();
        //$circle1->color = "bluee";
        //van de private, muon thay doi color ?
        $circle1->set_color("green");
        echo "<h1>Circle's area is : ".$circle1->get_area()."</h1>";
        print_r(MyCircle::$MIN_RADIUS);echo "<br>";
        MyCircle::do_something();
        $circle1->set_color("purple");
        
    ?>
</body>
</html>