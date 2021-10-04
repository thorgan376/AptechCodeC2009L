package com.mycompany.aptechexcersise.models;

public class Circle extends Shape{
    private Double radius;
    public Circle(String name, String color, Double radius) {
        super(name, color);
        this.radius = radius;
    }

    @Override
    public Double calculateArea() {
        return Math.PI * radius * radius;
    }

    @Override
    public String toString() {
        return super.toString() +
                "radius=" + radius;
    }
}
