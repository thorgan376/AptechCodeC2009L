package models;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

import static utilities.DateUtility.convertStringToDate;

public class Person {
    private String name;
    private String rollNumber;
    private Date dateOfBirth;

    public Person(String name, String rollNumber, String stringDateOfBirth) {
        this.name = name;
        this.rollNumber = rollNumber;
        this.dateOfBirth = convertStringToDate(stringDateOfBirth);
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getRollNumber() {
        return rollNumber;
    }

    public void setRollNumber(String rollNumber) {
        this.rollNumber = rollNumber;
    }

    public Date getDateOfBirth() {
        return dateOfBirth;
    }

    public void setDateOfBirth(Date dateOfBirth) {
        this.dateOfBirth = dateOfBirth;
    }
}
