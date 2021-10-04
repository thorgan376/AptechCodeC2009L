package controllers;

import models.CurrencyTransaction;
import models.GoldTransaction;
import models.Transaction;

import java.util.ArrayList;
import java.util.Hashtable;

public class TransactionController {
    private ArrayList<Transaction> transactions = new ArrayList<>();
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

}
