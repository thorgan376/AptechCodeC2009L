import org.apache.poi.ss.usermodel.Cell;
import org.apache.poi.ss.usermodel.Row;
import org.apache.poi.xssf.usermodel.XSSFSheet;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;

import java.io.BufferedReader;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.Enumeration;
import java.util.Hashtable;
import java.util.function.Predicate;
import java.util.stream.Collectors;

public class FileManager {
    private String filePath;
    private ArrayList<Hashtable<String, Object>> lands = new ArrayList<Hashtable<String, Object>>();
    public FileManager(String filePath) {
        this.filePath = filePath;
    }
    public void fetchDataFromExcel() {
        try {
            BufferedReader csvReader = new BufferedReader(new FileReader(this.filePath));
            int rowIndex = 0;
            String row = "";
            ArrayList<String> fields = new ArrayList<String>();
            boolean isFinished = false;
            do {
                row = csvReader.readLine();
                if(row == null) {
                    isFinished = true;
                }
                if(isFinished == false) {
                    String[] someStrings = row.split(",");
                    //lay ra ten cac field(cot)
                    if(rowIndex == 0) {
                        //hang dau tien = ten cot
                        for(int j = 0; j < someStrings.length; j++) {
                            fields.add(someStrings[j]);
                        }
                        System.out.println("haha");
                    } else {
                        //cac hang con lai = data
                        Hashtable<String, Object> dictionaryObject  = new Hashtable<String, Object>();
                        for(int j = 0; j < someStrings.length; j++) {
                            String dataAtJ = someStrings[j];
                            //chuan hoa du lieu
                            try {
                                Double dataAtJAsDouble = Double.parseDouble(dataAtJ);
                                dictionaryObject.put(fields.get(j), dataAtJAsDouble);
                            } catch (NumberFormatException numberFormatException) {
                                dictionaryObject.put(fields.get(j), dataAtJ);
                            }
                        }
                        this.lands.add(dictionaryObject);
                    }
                }
                ++rowIndex;
                //dictionaryObject.get("MSSubClass")
            }while (isFinished == false);
            csvReader.close();
        }catch (Exception exception) {
            //exception.printStackTrace();
            System.err.println(String.format("Exception = %s",exception.toString()));
        } finally {

        }
    }
    public ArrayList<Hashtable<String, Object>> filterLands() {
        //chi lay ra nhung ban ghi co salePrice > 200_000
        ArrayList<Hashtable<String, Object>> filteredLands = (ArrayList<Hashtable<String, Object>>) this.lands.stream()
                .filter(new Predicate<Hashtable<String, Object>>() {
                    @Override
                    public boolean test(Hashtable<String, Object> eachLand) {
                        return (Double)eachLand.get("SalePrice") > 200_000;
                    }
                }).collect(Collectors.toList());
        System.out.println("haha");
        return filteredLands;
    }
    //filter vao file excel khac
    public void saveDataToExcel(ArrayList<Hashtable<String, Object>> filteredLands, String filePath) {
        XSSFWorkbook workbook = new XSSFWorkbook();
        XSSFSheet sheet = workbook.createSheet("filtered lands");
        int rowCount = 0;
        for (Hashtable<String, Object> eachLand: filteredLands) {
            Row row = sheet.createRow(++rowCount);
            int columnCount = 0;
            Enumeration<String> enumeration = eachLand.keys();
            while (enumeration.hasMoreElements() == true) {
                String field = enumeration.nextElement();
                Cell cell = row.createCell(++columnCount);
                if(eachLand.get(field) instanceof Double) {
                    cell.setCellValue((Double) eachLand.get(field));
                }else if(eachLand.get(field) instanceof String) {
                    cell.setCellValue((String) eachLand.get(field));
                }
                System.out.println("haha");
            }
        }
        System.out.println("haha");
        try {
            FileOutputStream outputStream = new FileOutputStream(filePath);
            workbook.write(outputStream);
        } catch (Exception exception) {
            System.err.println("Cannot save file. Error: "+exception.toString());
        }
    }
}
