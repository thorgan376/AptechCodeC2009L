package utilities;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class DateUtility {
    private static String dateFormat = "MM/dd/yyyy";
    public static Date convertStringToDate(String stringDate) {
        DateFormat df = new SimpleDateFormat(dateFormat);
        Date resultDate = null;
        try {
            resultDate = df.parse(stringDate);
        } catch (ParseException e) {
            e.printStackTrace();
        } finally {
            return resultDate;
        }
    }
    public static String convertDateToString(Date date) {
        SimpleDateFormat formatter = new SimpleDateFormat(dateFormat);
        String result = "";
        try {
            result = formatter.format(date);
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            return result;
        }
    }
}
