<?php

// class SchoolBook extends tu Book va cong them:
// state: new, old => nghi den enum
class SchoolBook extends Book {
    private $state;
    public function __construct($bookCode, $unitPrice, $amount, $producer, 
                                $state) {
        parent::__construct($bookCode, $unitPrice, $amount, $producer);
        $this->state = $state;

                                }
    public function getTotalPrice() {
        if($this->state == BookState::OLD) {
            return $this->getAmount() * $this->getUnitPrice();
        } else {
            return $this->getAmount() * $this->getUnitPrice() * 0.5;
        }
    }
}
?>