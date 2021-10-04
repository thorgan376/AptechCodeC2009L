<?php
class Shape {
    //Shape la lop cha(base class, super class) cua Rectangle
    private $name;
    private $color;
    
    //getter
    protected function get_name() {
        //phuong thuc/thuoc tinh protected co the goi duojc tu lop con
        //Ko goi duoc phuong thuc/thuoc tinh protected o ngoai class
        return $this->name;
    }
    public function get_color() {
        return $this->color;
    }
    //setter
    public function set_name($name) {
        $this->name = $name;
    }
    public function set_color($color) {
        $this->color = $color;
    }
}
?>