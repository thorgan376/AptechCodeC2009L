<?php
// lop cha Book:
// bookCode,
// inputDate
// unitPrice
// amount
// producer
class Book {
    private $bookCode;    
    private $unitPrice;
    private $amount;
    private $producer;
    //constructor
    public function __construct($bookCode, $unitPrice, $amount, $producer) {        
        $this->bookCode = $bookCode;
        $this->unitPrice = $unitPrice;
        $this->amount = $amount;
        $this->producer = $producer;
    }
    //getters
    public function getBookCode() {
        return $this->bookCode; 
    }
    public function getUnitPrice() {
        return $this->unitPrice; 
    }
    public function getAmount() {
        return $this->amount; 
    }
    public function getProducer() {
        return $this->producer; 
    }
    //setters
    public function setBookCode($bookCode){
        $this->bookCode = $bookCode;
    }
    public function setUnitPrice($unitPrice){
        $this->unitPrice = $unitPrice;
    }
    public function setAmount($amount){
        $this->amount = $amount;
    }
    public function setProducer($producer){
        $this->producer = $producer;
    }
}
?>


