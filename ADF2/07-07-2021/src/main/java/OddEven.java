import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class OddEven {

    public void create2Files() {
        List<String> fileNames = new ArrayList<>(Arrays.asList(new String[] {"odd.txt", "even.txt"}));
        for (String fileName: fileNames) {
            try {
                File file = new File(fileName);
                file.delete();
                if (file.createNewFile()) {
                    System.out.println("File created: " + file.getName());
                }
            }catch (IOException e) {
                System.err.println("Error: "+e.toString());
            }
        }
    }
    public void saveTo2Files(){
        FileWriter fileWriterOdd = null;
        FileWriter fileWriterEven = null;
        try {
            File file = new File("numbers.txt");
            Scanner myReader = new Scanner(file);
            fileWriterOdd = new FileWriter("odd.txt");
            fileWriterEven = new FileWriter("even.txt");
            while (myReader.hasNextLine()) {
                Integer selectedNumber = Integer.valueOf(myReader.nextLine());
                if(selectedNumber % 2 == 0) {
                    fileWriterEven.write(String.format("%d\n", selectedNumber));
                } else {
                    fileWriterOdd.write(String.format("%d\n", selectedNumber));
                }
            }
            myReader.close();
            fileWriterOdd.close();
            fileWriterEven.close();
        } catch (FileNotFoundException e) {
            System.out.println("Cannot read file :"+e.toString());
        } catch (Exception e) {
            System.out.println("Error :"+e.toString());
        } finally {
            fileWriterOdd = null;
            fileWriterEven = null;
        }
    }
}
