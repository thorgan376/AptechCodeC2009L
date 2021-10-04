<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

    <title>Document</title>
</head>
<body>
    <div class="container">
        <h1>Form vi du voi PHP</h1>
        <form action="./index.php" method="post">
        <div class="form-group">
            <input type="text" name="x" id="x" placeholder = "Enter x">
        </div>
        <div class="form-group">
            <input type="text" name="y" id="y" placeholder = "Enter y">
        </div>
        <div class="form-group">
            <input type="submit" value="Calculate" class="btn btn-success">
        </div>
        
        </form>
        <?php
            $x = intval(isset($_POST['x']) ? $_POST['x'] : "0");
            $y = intval(isset($_POST['y']) ? $_POST['y'] : "0");
            $sum = $x + $y;
            echo "sum = ".$sum;
            $marks = array(8, 9, 6,"hoang", 7.2, 4,3);
            echo "<br>";
            var_dump($marks);
            array_push($marks, 100);
            echo "<h1>Sau khi them</h1>";
            var_dump($marks);
            //array duoi dang 1 doi tuong
            $student = array("name" => "Nguyen Van A", "age" => 20);//associative array
            echo "<h1>Associative array</h1>";
            sort($student);
            var_dump($student);
            $email = "hoangabc@gmail.com";
            //convert string to array
            echo "<h1>convert string to array</h1>";
            $result = explode("@",$email);
            var_dump($result[0]);
            //multi-value
            $phone_numbers = "0912455454;08265656;0213565;05545484";
            $phone_numbers = explode(";", $phone_numbers);
            echo "<h1>List of phone numbers</h1>";
            var_dump($phone_numbers[count($phone_numbers) - 1]);
        ?>
    </div>
   
</body>
</html>