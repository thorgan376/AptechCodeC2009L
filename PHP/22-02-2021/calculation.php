<?php
class Calculation {
    private $x;
    private $y;
    public function Calculation($x, $y) {
        $this->x = $x;
        $this->y = $y;
    }
    //instance method = 
    public function sum() {
        return $this->x + $this->y; 
    }
    public function substract() {
        return $this->x - $this->y; 
    }
    public function multiply() {
        return $this->x * $this->y; 
    }
    public function divide () {
        return $this->x + $this->y; 
    }
}
?>