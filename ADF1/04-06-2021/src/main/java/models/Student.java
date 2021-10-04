package models;

import interfaces.IDoSomething;
import interfaces.ILearning;
import interfaces.IPlayable;

public class Student implements IPlayable, ILearning {
    //Mot class co the thuc thi nhieu interface
    //implement interface nao thi phai thuc thi cac phuong thuc cua interface do(tru pt static)
    private String name;
    private String email;

    public Student(String name, String email) {
        this.name = name;
        this.email = email;
    }

    @Override
    public void playAGame(String gameName) {
        System.out.println("I am playing "+gameName);
    }

    @Override
    public void playFoodball() {
        System.out.println("I am playing foodball");
    }

    @Override
    public int borrowSomeBooks() {
        return 10;
    }

    @Override
    public void goToLibrary(String libraryName) {
        System.out.println("I am going to "+libraryName);
    }
    public void doX(IDoSomething iDoSomething) {
        System.out.println("begin do x");
        iDoSomething.onClick("bla bla");
        System.out.println("end do x");
    }
}
