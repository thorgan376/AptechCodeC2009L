/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.aptechexcersise.models;

public abstract class Shape {
    private String name;
    private String color;
    //1 parent/super co nhieu sub-class
    //1 lop con co the co 2 lop cha ? NO(java) !,
    //ham khoi tao
    public Shape(String name, String color) {
        this.name = name;
        this.color = color;
    }

    protected String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
    public void doXX(){
        System.out.println("Do xx(in Shape)");
    }
    public abstract Double calculateArea();//ko can thuc thi
    //multi-level = class A cha cua B, C la con cua B =>ok

    @Override
    public String toString() {
        return "name='" + name + '\'' +
                ", color='" + color + '\'';
    }
}
