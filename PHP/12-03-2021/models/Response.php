<?php
class Response {
    private $result;//true/false
    private $errorCode;//vd: 500
    private $errorMessage;//"User exists"
    public function __construct($result, $errorCode, $errorMessage) {
        $this->result = $result;
        $this->errorCode = $errorCode;
        $this->errorMessage = $errorMessage;
    }
    //getter
    public function getResult() {
        return $this->result;
    }
    public function getErrorCode() {
        return $this->errorCode;
    }
    public function getErrorMessage() {
        return $this->errorMessage;
    }
}
?>