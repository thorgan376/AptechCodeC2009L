package validations;

public class Validation {
    //overloading
    public static boolean isValidID(int id){
        return id > 0 && id < 1000_000;
    }
    public static boolean isValidID(String id){
        boolean isContainOnlyNumbers = id.matches("[0-9]+");
        if(!isContainOnlyNumbers) {
            return false;
        }
        int myID = Integer.valueOf(id);
        return Validation.isValidID(myID);
    }
}
