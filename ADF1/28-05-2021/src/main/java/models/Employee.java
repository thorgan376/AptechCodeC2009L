package models;

public class Employee {
    private String name;
    private String email;
    private Double salary;
    public static Double BASE_SALARY = 5.0;
    public Employee(String name, String email, Double salary) {
        this.name = name;
        this.email = email;
        this.salary = salary;

    }
    public static void aStaticMethod(){
        //System.out.println(this.name);
    }
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public Double getSalary() {
        return salary;
    }

    public void setSalary(Double salary) {
        this.salary = salary;
    }
}
