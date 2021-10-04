package views;

import models.Person;
import utilities.DateUtility;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.util.ArrayList;
import java.util.Date;
import java.util.TimerTask;

public class ProductListView implements IView{
    //Khai niem "state" trong Screen
    //Bai tap buoi sau: du lieu thay doi (1giay thay doi 1 lan) => man hinh ProductList view thay doi theo
    //Hien man hinh tiep theo nhung man Login phai bien mat
    private JFrame mainFrame = new JFrame();
    private int width, height;
    private ArrayList<Person> persons = new ArrayList<>();
    //reference 1 - 1
    private LoginView loginView; //mobx trong React, redux(redux saga, redux thunk) trong React
    //global state = shared state
    private int countUp = 0;//internal state
    private javax.swing.Timer timer;
    private JLabel labelCounterUp = new JLabel("0");

    /*
    ProductListView chứa thuộc tính persons(mảng các Person Object)
    khi một trong các person thay đổi giá trị => Giao diện List phải load theo(mà ko phải tắt ProductListView rôi bật lên)
    => persons gọi là "internal state"
    */
    public void setLoginView(LoginView loginView) {
        this.loginView = loginView;
    }
    //reload state phai nam trong setter

    public void setCountUp(int countUp) {
        this.countUp = countUp;
        this.labelCounterUp.setText(String.valueOf(this.countUp));
        //System.out.println("countUp = "+countUp);
    }

    private Object[][] mapPersonsToData() {
        Object[][] result = new String[persons.size()][];
        try {
            for(int row = 0; row < persons.size(); row++) {
                result[row] = new String[]{
                        persons.get(row).getRollNumber(),
                        persons.get(row).getName(),
                        DateUtility.convertDateToString(persons.get(row).getDateOfBirth())
                };
            }
        }catch (Exception e) {
            System.err.println("hahja");
        }
        return result;
    }
    //reload state => cho vao setter

    public void setPersons(ArrayList<Person> persons) {
        this.persons = persons;
    }
    //

    private void setupFakeData() {
        //fake chi de test UI
        //sau nay du lieu phai lay tu DB
        persons.add(new Person("John", "a1233", "06/27/1993"));
        persons.add(new Person("Anna", "x2332", "07/25/2000"));
        persons.add(new Person("Nguyen Duc Hoang", "c3343", "12/27/2001"));
    }
    public ProductListView(int width, int height) {
        this.width = width;
        this.height = height;
    }
    public void reloadData() {
        setupUI(width, height);
    }
    //de them Retype password(can public Gridlayout), can sua tieu de(public JFrame)
    @Override
    public void setupUI(int width, int height) {
        //fake data
        JTable table = new JTable(
                this.mapPersonsToData(),
                new String[] {"Roll number", "Name", "Date of birth"});

        JScrollPane scrollPane = new JScrollPane(table);
        // Cho phep table sap xep
        table.setAutoCreateRowSorter(true);
        mainFrame.add(scrollPane, BorderLayout.CENTER);
        mainFrame.add(labelCounterUp);
        mainFrame.setSize(width, height);
        mainFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        mainFrame.setLocationRelativeTo(null);

        mainFrame.addWindowListener(new WindowAdapter() {
            @Override
            public void windowClosing(WindowEvent e) {
                if (JOptionPane.showConfirmDialog(mainFrame,
                        "Are you sure you want to close this window?", "Close Window?",
                        JOptionPane.YES_NO_OPTION,
                        JOptionPane.QUESTION_MESSAGE) == JOptionPane.YES_OPTION){

                }
            }
        });
        //setup time interval
        timer = null;
        timer = new Timer(1000,new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                //countUp ++; //state thay doi, data phai thay doi
                setCountUp(++countUp); //set state !
            }
        });

        java.util.Timer tt = new java.util.Timer(false);
        tt.schedule(new TimerTask() {
            @Override
            public void run() {
                timer.start();
            }
        }, 0);
    }

    @Override
    public void show() {
        mainFrame.setVisible(true);
    }

    @Override
    public void hide() {
       mainFrame.setVisible(false);
    }
}
