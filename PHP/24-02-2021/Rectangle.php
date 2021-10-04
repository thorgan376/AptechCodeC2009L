<?php
require './Shape.php';
//inheritance = ke thua = "lop con chua het cac thuoc tinh/phuong thuc public/protected cua lop cha"
class Rectangle extends Shape{
    //Rectangle goi la lop con(sub-class) cua Shape
    //hinh chu nhat co $name va $color ? YES    
    private $width = 0.0;
    private $height = 0.0;
    public function get_width() {
        return $width;
    }
    public function get_height() {
        return $height;
    }
    public function set_width($width) {
        $this->width = $width;
    }
    public function set_height($height) {
        $this->height = $height;
    }
    public function show_something() {
        
        $this->set_name("hinh chu nhat");
        echo "<h2>width = ".$this->width."</h2>";
        echo "<h2>height = ".$this->height."</h2>";
        echo "<h2>name = ".$this->get_name()."</h2>";
    }
    //trong rectangle co them mot so phuong thuc khac
    //ma Shape ko co hoac ko lam duoc
    public function get_area() {
        return $this->width * $this->height;
    }
}
?>