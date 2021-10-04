<?php

class MyCircle   {
    public static $MIN_RADIUS = 5.0;
    private $radius;
    private $color;
    public function __construct($radius, $color) {
        $this->radius = $radius;
        $this->color = $color;
    }
    public function __destruct() {

    }
    public static function do_something2() {
        echo "do something222 ne";
        MyCircle::do_something();//OK
    }
    public static function do_something(){
        echo "do something ne";
        // echo "Radius = ".$radius;
        //ben trong phuong thuc static ko the goi dc instance variable
    }
    public function set_color($color) {
        $this->color = $color;
        //Goi phuong thuc static o day duoc ko ?? YES
        MyCircle::do_something();
        //ben trong 1 phuong thuc instance thi co the goi duoc phuong thuc/thuoc tinh static
    }

    //private thuoc tinh, public ham => encapsulation => tinh dong goi
    public function get_radius() {
        //getter : ham lay gia tri ra
        return $radius;
    }
    public function set_radius($radius) {
        //setter : ham thay doi gia tri thuoc tinh
        $this->radius = $radius;
    }
    //tinh dien tich
    public function get_area() {
        return M_PI * $this->radius * $this->radius;
    }
    public function __toString (){
        return "radius : ".$radius;
    }
}
?>