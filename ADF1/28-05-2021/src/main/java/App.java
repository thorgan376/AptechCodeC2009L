import models.Account;
import models.Calculation;
import models.Employee;

import java.util.ArrayList;
import java.util.Scanner;

public class App {
    static Scanner scanner = new Scanner(System.in);
    static Scanner getScanner() {
        return new Scanner(System.in);
    }
    static void nhapTK(Account tk) {
        System.out.println("Nhập số tài khoản: ");
        tk.setNumberAccount(getScanner().nextInt());
        System.out.println("Nhập tên tài khoản: ");
        tk.setNameAccount(getScanner().nextLine());
    }
    public static void main(String[] args) {
        Employee mrA = new Employee("Hoang", "hoang@gmail.com", 10.0);
        Employee mrB = new Employee("Huy", "hoang@gmail.com", 13.0);

        Employee mrC = new Employee("Huy", "hoang@gmail.com", 11.0);
        Employee.aStaticMethod();
        System.out.println("haha");
        Calculation calculation = new Calculation(2.0, 0.0);
        System.out.println(String.format("result = %f", calculation.divide()));
        ArrayList<Account> accounts = new ArrayList<>();
        int choice = 0;
        int n = 0;
        long accountNumber, c, f;
        do {
            System.out.println("1.Nhập thông tin của các khách hàng\n"
                    + "2.Xuất danh sách thông tin của các khách hàng\n" + "3.Nạp tiền\n" + "4.Rút tiền\n"
                    + "5.Đáo hạn\n" + "6.Chuyển khoản\n" + "Số khác để thoát");
            System.out.println("Bạn chọn làm gì: ");
            choice = scanner.nextInt();
            switch (choice) {
                case 1:
                    System.out.println("Nhập số lượng khách hàng bạn muốn nhập: ");
                    n = scanner.nextInt();
                    for (int i = 0; i < n; i++) {
                        System.out.println("Khách hàng số: " + (i+1));
                        Account newAccount = new Account();
                        nhapTK(newAccount);
                        accounts.add(newAccount);
                    }
                    break;
                case 2:
                    System.out.printf("%-10s %-20s %-20s\n", "Số TK", "Tên TK", "Số tiền trong TK");
                    for (int i = 0; i < n; i++) {
                        accounts.get(i).printAccount();
                    }
                    break;
                case 3:
                    System.out.println("Nhập số tài khoản khách hàng cần nạp tiền: ");
                    Account foundAccount = Account.getAccountByAccountNumber(getScanner().nextLong(), accounts);
                    if(foundAccount != null) {
                        foundAccount.pushMoney();
                    }
                    break;
                case 4:
                    System.out.println("Nhập số tài khoản khách hàng cần rut tiền: ");
                    Account withdrawAccount = Account.getAccountByAccountNumber(getScanner().nextLong(), accounts);
                    if(withdrawAccount != null) {
                        withdrawAccount.withDraw();
                    }
                    break;
                case 5:
                    System.out.println("Nhập số tài khoản khách hàng cần đáo hạn: ");
                     Account expiredAccount = Account.getAccountByAccountNumber(getScanner().nextLong(), accounts);
                    if(expiredAccount != null) {
                        expiredAccount.expiredDate();
                    }
                    break;
                case 6:
                    double chuyen,nhan, tienChuyen;
                    System.out.print("Nhập số tài khoản khách hàng chuyển tiền: ");
                    Account account1 = Account.getAccountByAccountNumber(getScanner().nextLong(), accounts);
                    System.out.print("Nhập số tài khoản khách hàng nhận tiền: ");
                    Account account2 = Account.getAccountByAccountNumber(getScanner().nextLong(), accounts);
                    if(account1 != null && account2 != null) {
                        account1.withDraw();
                        account1.pushMoney();
                    }
                    /*
                    for (int i = 0; i < n; i++) {
                        if (accountNumber == accounts[i].getNumberAccount()) {
                            chuyen = accounts[i].getMoneyInAcount();
                            for (int j = 0; j < n; j++) {
                                f = accounts[j].getNumberAccount();
                                if (c == f) {
                                    nhan = accounts[j].getMoneyInAcount();
                                    System.out.println("Nhập số tiền cần chuyển");
                                    tienChuyen = scanner.nextDouble();
                                    if (tienChuyen <= chuyen) {
                                        chuyen = chuyen - tienChuyen;
                                        nhan = nhan + tienChuyen;
                                        accounts[i].setMoneyInAcount(chuyen);
                                        accounts[j].setMoneyInAcount(nhan);
                                        System.out.println("Tài khoản số " + accounts[i].getNumberAccount() + " vừa chuyển: $" + tienChuyen);
                                        System.out.println("Tài khoản số " + f + " vừa nhận: $" + tienChuyen);
                                    } else {
                                        System.out.println("Số tiền nhập không hợp lệ!");
                                    }
                                } else {
                                    System.out.println("");
                                }
                            }
                        } else {
                            System.out.println("");
                        }
                    }
                    */

                    break;
                default:
                    System.out.println("Bye!!");
                    break;
            }
        } while (choice >= 1 || choice <= 6);
    }
}
