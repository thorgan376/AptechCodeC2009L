<?php
class Employee {
    public static $BASE_SALARY = 1000;
    private $name;
    private $age;
    //phuong thuc khoi tao 1 doi tuong
    public function __construct($name, $age) {
        $this->name = $name;
        $this->age = $age;
    }
}
?>