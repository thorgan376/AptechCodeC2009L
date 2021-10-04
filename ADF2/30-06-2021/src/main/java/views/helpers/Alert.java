package views.helpers;

import javax.swing.*;

public class Alert {
    //alert giong voi js
    public static void alert(String title, String content, int type) {
        JOptionPane optionPane = new JOptionPane(content, type);
        JDialog dialog = optionPane.createDialog(title);
        dialog.setAlwaysOnTop(true); // to show top of all other application
        dialog.setVisible(true); // to visible the dialog
    }
}
