package models;

import java.text.NumberFormat;
import java.util.ArrayList;
import java.util.Scanner;

public class Account {
    private long numberAccount = 0;//gia tri ban dau
    private String nameAccount = "";
    private Double deposit = 25.0;
    Scanner scanner = new Scanner(System.in);
    public Account(){
        //default constructor
    }
    //se phai co cho goi den
    public Account(long numberAccount, String nameAccount, Double deposit){
        this.numberAccount = numberAccount;
        this.nameAccount = nameAccount;
        this.deposit = deposit;
    }

    public long getNumberAccount() {
        return numberAccount;
    }

    public void setNumberAccount(long numberAccount) {
        this.numberAccount = numberAccount;
    }

    public String getNameAccount() {
        return nameAccount;
    }

    public void setNameAccount(String nameAccount) {
        this.nameAccount = nameAccount;
    }

    public Double getMoneyInAcount() {
        return deposit;
    }

    public void setMoneyInAcount(Double moneyInAcount) {
        this.deposit = moneyInAcount;
    }


    @Override
    public String toString(){
        return numberAccount + "-" + nameAccount + "-" + convertToMoneyFormat(deposit);
    }

    private String convertToMoneyFormat(Double inputMoney) {
        NumberFormat currencyEN = NumberFormat.getCurrencyInstance();
        return inputMoney == null ? "$0.0" : currencyEN.format(inputMoney);
    }
    public Double pushMoney(){
        Double push;
        System.out.println("Enter the amount you need to deposit: ");
        push = scanner.nextDouble();
        if (push >= 0) {
            deposit = push + deposit;
            System.out.println("Bạn vừa nạp " + convertToMoneyFormat(push) + " vào tài khoản.");
        } else {
            System.out.println("Số tiền nạp vào không hợp lệ!");
        }
        return push;
    }
    public double withDraw() {
        double fee = 5;
        double take;
        System.out.print("Nhập số tiền bạn cần rút: ");
        take = scanner.nextDouble();

        if (take <= (deposit - fee)) {
            deposit = deposit - (take + fee);
            System.out.println("Bạn vừa rút " + convertToMoneyFormat(take) + "Đ từ tài khoản. Phí là $5.");
        } else {
            System.out.println("Số tiền muốn rút không hợp lệ!");
            return withDraw();
        }
        return take;
    }
    public double expiredDate() {
        double rate = 0.035;
        deposit = deposit + deposit * rate;

        System.out.println("Bạn vừa được " +
                convertToMoneyFormat(deposit) +
                " từ đáo hạn 1 tháng");
        return deposit;
    }
    public void printAccount() {
        System.out.printf("%-10d %-20s %-20s \n", numberAccount, nameAccount, convertToMoneyFormat(deposit));
    }
    public static Account getAccountByAccountNumber(long accountNumber, ArrayList<Account> accounts) {
        for(Account eachAccount: accounts) {
            if(accountNumber == eachAccount.getNumberAccount()) {
                System.out.println("Bạn chọn tài khoản: " + eachAccount.getNumberAccount());
                return eachAccount;
            }
        }
        System.err.println("Ko tim thay tai khoan: "+accountNumber);
        return null;
    }

}
