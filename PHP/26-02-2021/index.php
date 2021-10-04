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
        require './models/BookState.php';
        require './models/Book.php';
        require './models/SchoolBook.php';
        require './models/ReferenceBook.php';
        
        $book1 = new SchoolBook("11a",100,2,"hieu sach viet",BookState::OLD);
        $book2 = new SchoolBook("22a",200,3,"hieu sach abc",BookState::NEW);

        $book3 = new ReferenceBook("33a",200,2,"hieu sach viet",0.2);
        $book4 = new ReferenceBook("44a",300,2,"hieu sach abc",0.3);
        $book5 = new ReferenceBook("55a",500,2,"hieu sach viet",0.5);
        $books = array($book1, $book2,$book3, $book4,$book5);
        $totalReferenceBookPrice = 0.0;
        $totalSchoolBookPrice = 0.0;

        $numberOfReferenceBooks = 0;

        foreach($books as $book) {
            if($book instanceof SchoolBook) {
                $totalSchoolBookPrice += $book->getTotalPrice();
            }else if($book instanceof ReferenceBook) {
                $totalReferenceBookPrice += $book->getTotalPrice();
                $numberOfReferenceBooks++;
            }
            if($book->getProducer() == "hieu sach abc") {
                print_r($book);
            }
        }
        echo "totalSchoolBookPrice = ".$totalSchoolBookPrice."<br>";
        echo "totalReferenceBookPrice = ".$totalReferenceBookPrice."<br>";
        echo "mean = ".$totalReferenceBookPrice / $numberOfReferenceBooks."<br>";
        //server nhan duoc
        if(isset($_POST["name"])) {
            echo "<h1> name = ".$_POST["name"]."</h1>";
            echo "<h1> email = ".$_POST["email"]."</h1>";
            echo "<h1> age = ".$_POST["age"]."</h1>";
            //rank 0 => scalar
            scalar: vo huong
        }
    ?>
    <form action='index.php' method="POST">
    <!-- Gui tu client len server -->
        <input type="text" placeholder="Enter name" name="name"><br>
        <input type="text" placeholder="Enter email" name="email"><br>
        <input type="text" placeholder="Enter age" name="age"><br>
        <input type="submit" value="Press me">
        <!--METHOD GET http://localhost:82/index.php?name=hoang&email=abc%40gmail.com&age=18 -->
        <!--METHOD POST http://localhost:82/index.php -->
        <!-- https://www.anphatpc.com.vn/ban-phim-co-choi-game_dm1257.html?gclid=CjwKCAiA1eKBBhBZEiwAX3gqlzCz_Un7YOc2lrCbZkM8JJ5MqGYChz6JopVdHCYSlgyrJjeSUNqESxoCvngQAvD_BwE&brand=3&sort=price-desc&filter=1507 -->
        
    </form>
</body>
</html>

