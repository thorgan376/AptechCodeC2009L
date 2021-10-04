import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main {
    public static int MAX_OPPORTUNITIES = 2;
    public static void main(String[] args) {
        List<Opportunity> opportunityList = new ArrayList<>();

        boolean isLoop = true;
        while (isLoop) {
            Opportunity opportunity = new Opportunity();
            if(opportunity.input() == true) {
                opportunityList.add(opportunity);
            }
            isLoop = opportunityList.size() <= MAX_OPPORTUNITIES - 1;
        }
        //Luu file => luu object => luu List<T>
        //file bat => ko nen luu .bat trong Windows
        //fake
//            public Opportunity(String id, String jobTitle, float expectedSalary, List<String> skills,
//                List<String> education, BufferedReader bufferedReader) {
        /*
        opportunityList.add(new Opportunity("a111", "a1111111111", 1111111,
                Arrays.stream((new String [] {"aa", "bb"})).toList(),
                Arrays.stream((new String [] {"daihocA", "daiHocB"})).toList()));
        opportunityList.add(new Opportunity("b111", "bb1111111111", 1111111,
                Arrays.stream((new String [] {"xx", "xxxs"})).toList(),
                Arrays.stream((new String [] {"daihocC", "daiHocD"})).toList()));

         */
        Opportunity.saveListToFile(opportunityList, "data_file.bat");
        List<Opportunity> result= Opportunity.readListFromFile("data_file.bat");
        for(Opportunity opportunity: result) {
            System.out.println(opportunity.toString());
        }
        List<Opportunity> filteredOppotunities = Opportunity.findOpportunitiesInList(result);
        if(filteredOppotunities.size() == 0) {
            System.out.println("Cannot find opportunities");
        }

    }
}
