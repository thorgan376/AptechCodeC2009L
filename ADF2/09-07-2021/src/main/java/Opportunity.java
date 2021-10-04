import java.io.*;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Opportunity implements Serializable {
    private String id;
    private String jobTitle;
    private float expectedSalary;
    private List<String> skills = new ArrayList<>();
    private List<String> education  = new ArrayList<>();
    private transient BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
    public static void saveListToFile(List<Opportunity> opportunities, String filepath){
        try {
            FileOutputStream fileOut = new FileOutputStream(filepath);
            ObjectOutputStream objectOut = new ObjectOutputStream(fileOut);
            objectOut.writeObject((ArrayList<Opportunity>)opportunities);
            objectOut.close();
            System.out.println("The Object  was succesfully written to a file");
        } catch (Exception ex) {
            System.err.println("Cannot save to file:");
            ex.printStackTrace();
        }
    }
    public static List<Opportunity>  readListFromFile(String filepath){
        List<Opportunity> opportunities = new ArrayList<>();
        try {
            FileInputStream fileIn = new FileInputStream(filepath);
            ObjectInputStream objectInputStream = new ObjectInputStream(fileIn);
            Object resultObject = objectInputStream.readObject();
            System.out.println("The Object has been read from the file");
            opportunities = resultObject instanceof List<?> ? (List<Opportunity>)resultObject:new ArrayList<>();

            objectInputStream.close();
        } catch (Exception ex) {
            System.err.println("Cannot read file:");
            ex.printStackTrace();
        } finally {
            return opportunities;
        }
    }

    public Opportunity(String id, String jobTitle, float expectedSalary, List<String> skills,
                       List<String> education) {
        this.id = id;
        this.jobTitle = jobTitle;
        this.expectedSalary = expectedSalary;
        this.skills = skills;
        this.education = education;
    }

    public Opportunity() {
    }
    public static List<Opportunity> findOpportunitiesInList(List<Opportunity> opportunities) {
        List<Opportunity> result = new ArrayList<>();
        System.out.println("Enter job's title: ");
        try {
            BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
            String jobTitle = bufferedReader.readLine();
            result = (List<Opportunity>)(opportunities.stream().filter(eachItem -> eachItem.getJobTitle().trim().equals(jobTitle)).toList());
        }catch (Exception e) {
            System.err.println("Cannot read job title: "+e.toString());
        }
        return result;
    }

    public boolean input(){
        try {
            System.out.println("Enter opportunity's information: ");
            System.out.println("Enter id: ");
            this.id = bufferedReader.readLine();

            System.out.println("Enter job's title: ");
            this.jobTitle = bufferedReader.readLine();
            if(this.jobTitle.trim().length() <= 10) {
                System.err.println("job title must >= 10 characters");
                return false;
            }

            System.out.println("Enter expected salary : ");
            this.expectedSalary = Float.valueOf(bufferedReader.readLine());
            if(this.expectedSalary <= 20) {
                System.err.println("expected salary must >= 20");
                return false;
            }

            System.out.println("Enter job's skills: ");
            String[] skills = bufferedReader.readLine().split(",");
            if(skills.length < 2) {
                System.err.println("Skill must be >= 2");
                return false;
            }
            this.skills = Arrays.stream(skills).toList();

            System.out.println("Enter job's education: ");
            String[] education = bufferedReader.readLine().split(",");
            if(education.length < 1) {
                System.err.println("You must have at least 1 education");
                return false;
            }
            this.education = Arrays.stream(education).toList();

            return true;
        }catch (Exception e) {
            System.err.println("Canot input opportunity: "+e.toString());
            return false;
        }

    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getJobTitle() {
        return jobTitle;
    }

    public void setJobTitle(String jobTitle) {
        this.jobTitle = jobTitle;
    }

    public float getExpectedSalary() {
        return expectedSalary;
    }

    public void setExpectedSalary(float expectedSalary) {
        this.expectedSalary = expectedSalary;
    }

    public List<String> getSkills() {
        return skills;
    }

    public void setSkills(List<String> skills) {
        this.skills = skills;
    }

    public List<String> getEducation() {
        return education;
    }

    public void setEducation(List<String> education) {
        this.education = education;
    }

    @Override
    public String toString() {
        return "Opportunity{" +
                "id='" + id + '\'' +
                ", jobTitle='" + jobTitle + '\'' +
                ", expectedSalary=" + expectedSalary +
                ", skills=" + skills +
                ", education=" + education +
                '}';
    }
}
