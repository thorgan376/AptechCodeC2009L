<?php
class Student {
    private $student_id;
    private $first_name;
    private $last_name;
    private $gender;
    private $country;
    //attributes => private, functions => public , => encapsulation(tinh bao goi)
    public function __construct($student_id, 
                                $first_name,
                                $last_name, 
                                $gender,
                                $country) {
        $this->student_id = $student_id; 
        $this->first_name = $first_name;
        $this->last_name = $last_name;
        $this->gender = $gender;
        $this->country = $country;            
    }
    public function __destructor() {
        echo "haha";
    }
}
?>