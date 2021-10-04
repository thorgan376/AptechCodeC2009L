package views;
import org.w3c.dom.xpath.XPathNamespace;
import views.helpers.Alert;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class LoginView implements IView{
    //thuoc tinh: TextField email TextField Password
    private final JFrame mainFrame = new JFrame("Login view");
    private final JTextField textFieldEmail = new JTextField(6);
    private final JPasswordField textFieldPassword = new JPasswordField(6);
    private final JButton buttonLogin = new JButton("Login");
    private final GridLayout gridLayout = new GridLayout(3,2);

    private ProductListView productListView = new ProductListView(375, 250);
    private SPlineView sPlineView = new SPlineView(375, 250);

    public JFrame getMainFrame() {
        return mainFrame;
    }
    public GridLayout getGridLayout() {
        return gridLayout;
    }
    @Override
    public void setupUI(int width, int height) {
        mainFrame.setSize(width, height);
        JPanel innerView = new JPanel(gridLayout);
        innerView.setBorder(new EmptyBorder(20, 20, 20, 20));

        innerView.add(new JLabel("Email :"));
        innerView.add(textFieldEmail);
        innerView.add(new JLabel("Password :"));
        innerView.add(textFieldPassword);
        innerView.add(buttonLogin);
        //fake
        textFieldEmail.setText("hoang@gmail.com");
        textFieldPassword.setText("123456");

        buttonLogin.addActionListener((ActionEvent event) -> {
            System.out.println("sss");
            String email = textFieldEmail.getText().trim();
            String password = String.valueOf(textFieldPassword.getPassword());
            boolean isEmailPasswordBlank = email.length() == 0 || password.length() == 0;
            if(isEmailPasswordBlank) {
                Alert.alert("Warning", "You must enter email/pass", JOptionPane.WARNING_MESSAGE);
                return;
            }
            //Nhieu validation ?
            //goi JPA hoac JDBC, goi thang
            boolean loginSuccess = email.equals("hoang@gmail.com") && password.equals("123456");
            if(loginSuccess == false) {
                Alert.alert("Warning", "Wrong email/pass", JOptionPane.WARNING_MESSAGE);
                return;
            }
            //show do thi
//            this.productListView.reloadData();
//            this.productListView.setLoginView(this);
//            this.hide();
//            this.productListView.show();
            this.sPlineView.setupUI(375, 250);
            this.sPlineView.show();

            //chuyen sang man hinh List
            //System.out.println(String.format("Email = %s, password = %s", textFieldEmail.getText(), textFieldPassword.getPassword()));
        });
        mainFrame.add(innerView);
    }

    public LoginView(int width, int height){
        //mainFrame.setSize(width, height);
        setupUI(width, height);
    }
    @Override
    public void show() {
        //mot so viec khac
        System.out.println("kaka");
        Dimension dim = Toolkit.getDefaultToolkit().getScreenSize();
        mainFrame.setLocation(dim.width/2-mainFrame.getSize().width/2, dim.height/2-mainFrame.getSize().height/2);
        mainFrame.setVisible(true);
    }
    @Override
    public void hide() {
        System.out.println("kaka");
        mainFrame.setVisible(false);
    }
}
