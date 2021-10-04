
package com.mycompany.aptechexcersise;

import com.mycompany.aptechexcersise.models.*;
import com.mycompany.aptechexcersise.models.Shape;

import java.util.ArrayList;


public class Main {
    public static void main(String[] args) {        
//        Shape shape1 = new Shape("shape A", "red"); //Shape la abstract => ko duoc khoi tao
//        Shape shape2 = new Shape("shape B", "green");
        Rectangle rectangle1 = new Rectangle("abcd", "yellow", 100.0, 200.0);
        Rectangle rectangle2 = new Rectangle("abcd", "yellow", 100.0, 200.0);
        Circle circleA = new Circle("x", "green", 123.0);
        rectangle1.doSomething();
        System.out.println("Hello");
        rectangle2.doXX();
        ArrayList<Shape> shapes = new ArrayList<>();
        shapes.add(rectangle1);
        shapes.add(rectangle2);
        shapes.add(circleA);
        shapes.forEach(shape -> {
            if(shape instanceof Circle) {
                System.out.println("this is a Circle");
            } else if(shape instanceof  Rectangle) {
                System.out.println("this is a Rectangle");
            }
            System.out.println(shape);
        });
    }
    
}
