<?php

// ReferenceBook ke thua tu Book va cong them:
// tax

class ReferenceBook extends Book {
    private $tax;
    public function __construct($bookCode, $unitPrice, $amount, $producer, 
                                $tax) {
        parent::__construct($bookCode, $unitPrice, $amount, $producer);
        $this->tax = $tax; //test thu parent::__construct

                                }
    public function getTotalPrice() {
        return $this->getAmount() * $this->getUnitPrice() * $this->tax;
    }
}
?>