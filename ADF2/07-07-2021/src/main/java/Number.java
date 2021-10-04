import java.io.File;  // Import the File class
import java.io.FileWriter;
import java.io.IOException;
public class Number {
    private String filePath = "numbers.txt";
    public void saveToFile() {
        //tao file moi
        try {
            File file = new File(filePath);
            file.delete();
            if (file.createNewFile()) {
                System.out.println("File created: " + file.getName());
            }
            FileWriter myWriter = new FileWriter(filePath);
            for(int i = 1; i <= 100; i++) {
                if(i % 3 != 0) {
                    //sqlite
                    myWriter.write(String.format("%d\n", i));
                }
            }
            myWriter.close();
        } catch (IOException e) {
            System.out.println("Cannot write to file.Error: "+e.toString());
            e.printStackTrace();
        }
    }
}
