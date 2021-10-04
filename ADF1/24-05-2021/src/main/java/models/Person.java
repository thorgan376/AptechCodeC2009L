package models;

public class Person extends Object{
    //encapsulation = tinh bao goi
    private String name;
    private String email;
    private Integer age;
    public Person(String name, String email, Integer age) {
        this.name = name;
        this.email = email;
        this.age = age;
    }

    public String getName() {
        //getter co dang: get"ten thuoc tinh"
        return name;
    }

    public String getEmail() {
        return email;
    }

    public Integer getAge() {
        return age;
    }
    public void showDetailInformation(){
        System.out.println(
                String.format("name = %s, email = %s, age = %d",
                this.name, this.email, this.age));
    }

    @Override
    public String toString() {
        return String.format("name = %s, email = %s, age = %d",
                this.name, this.email, this.age);
    }
}
