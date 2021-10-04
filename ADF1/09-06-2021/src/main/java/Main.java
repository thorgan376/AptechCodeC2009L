import java.util.ArrayList;
import java.util.Hashtable;

public class Main {
    public static void main(String [] args) {
        System.out.println("Heelo");
        FileManager fileManager = new FileManager("/Users/nguyenduchoang/Documents/code/Aptech/C2009L/ADF1/09-06-2021/train.csv");
        fileManager.fetchDataFromExcel();
        ArrayList<Hashtable<String, Object>> filteredLands = fileManager.filterLands();
        fileManager.saveDataToExcel(filteredLands, "/Users/nguyenduchoang/Documents/code/Aptech/C2009L/ADF1/09-06-2021/output.xlsx");
    }
}
