package controllers;

import models.CurrencyTransaction;
import models.GoldTransaction;
import models.Transaction;

import java.util.ArrayList;
import java.util.Hashtable;

public class TransactionController {
    private ArrayList<Transaction> transactions = new ArrayList<>();

    public ArrayList<Transaction> getTransactions() {
        return transactions;
    }

    public Hashtable<String, Integer> getNumberOfGoldTransactions() {
        Hashtable<String, Integer> dictionary = new Hashtable<>();
        Integer numberOfGold = 0;
        Integer numberOfCurrency = 0;
        for(int i = 0; i < transactions.size(); i++) {
            Transaction transaction = transactions.get(i);
            if(transaction instanceof GoldTransaction) {
                numberOfGold ++;
            } else if(transaction instanceof CurrencyTransaction){
                numberOfCurrency ++;
            }
        }
        dictionary.put("gold", numberOfGold);
        dictionary.put("currency", numberOfCurrency);
        return dictionary;
    }
    public void insert(Transaction transaction) {
        this.transactions.add(transaction);
    }
    public Float getCurrencyAverage() {
        Float totalPrice = 0.0f;
        for(int i = 0; i < transactions.size(); i++) {
            Transaction transaction = transactions.get(i);
            if(transaction instanceof CurrencyTransaction){
                totalPrice += ((CurrencyTransaction) transaction).getTotalPrice();
            }
        }
        return  transactions.isEmpty() ? 0.0f : totalPrice / transactions.size();
    }
    public void showTransactionsOver1Billion() {
        for(Transaction eachTransaction: this.transactions) {
            /*
            if(eachTransaction instanceof GoldTransaction) {
                ((GoldTransaction) eachTransaction).getTotalPrice();
            } else if(eachTransaction instanceof CurrencyTransaction) {
                ((CurrencyTransaction) eachTransaction).getTotalPrice();
            }
             */
            System.out.println("Transactions over 1 billion: ");
            if(eachTransaction.getTotalPrice() > 1_000_000_000f){
                System.out.println(eachTransaction.toString());
            }
        }
    }
}
