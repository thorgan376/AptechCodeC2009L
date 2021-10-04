import views.LoginView;
import views.ProductListView;
import views.RegisterView;

import javax.swing.JButton;
import javax.swing.JFrame;

public class Main {
    public static void main(String [] args) {
        /*

        Minh can lam man hinh login(object, class):
        Label TextField => nhap email, mat khau
        Nut dang nhap
        Bam nut dang nhap, chuyen sang man hinh khac
        checkbox remember password
        dang nhap sai => bao loi
        //cac vi du xem tren mang => lam 1 man hinh
        //cai ta can la nhieu man hinh
        * */
        LoginView loginView = new LoginView(300, 150);
        loginView.show();




//        RegisterView registerView = new RegisterView(300, 150);
//        registerView.show();

        System.out.println("haha");
    }
}
