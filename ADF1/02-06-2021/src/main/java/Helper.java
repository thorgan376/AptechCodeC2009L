import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class Helper {
    public static Date toDate(String dateString) throws ParseException {
        return new SimpleDateFormat("dd/MM/yyyy").parse("31/05/2021");
    }

}
