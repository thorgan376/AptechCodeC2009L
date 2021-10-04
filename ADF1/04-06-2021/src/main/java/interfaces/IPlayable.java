package interfaces;

public interface IPlayable {
    //c++ => friend function
    public void playAGame(String gameName);//chi chua method ko chua phan thuc thi
    public void playFoodball();//ko dc private, ko duoc protected
    //public static void doSomething();//ko chua phuogn thuc static
    public static void doSomething() {
        System.out.println("do something"); //ok chua phuong thuc static + phan thuc thi => ok
    }
    /*ben trong interface ko chua ham constructor
    IPlayable(){

    }
    */
}
