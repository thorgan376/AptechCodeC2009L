import java.util.Hashtable;
import java.util.List;
import java.util.Map;

public class ThreadDemo {
    private Map<String, String> mapOfWeek;

    public Map<String, String> getMapOfWeek() {
        mapOfWeek = new Hashtable<>();
        mapOfWeek.put("Monday", "Thu 2");
        mapOfWeek.put("Tuesday", "Thu 3");
        mapOfWeek.put("Wednesday", "Thu 4");
        mapOfWeek.put("Thursday", "Thu 5");
        mapOfWeek.put("Friday", "Thu 6");
        mapOfWeek.put("Saturday", "Thu 7");
        mapOfWeek.put("Sunday", "Chu nhat");
        return mapOfWeek;
    }
    public void testThread() {
        Thread t1 = new Thread() {
            @Override
            public void run() {
                Map<String, String> map = ThreadDemo.this.getMapOfWeek();
                List<String> keys = map.keySet().stream().toList();
                for(int i = 0; i < keys.size(); i++) {
                    System.out.println(keys.get(i));
                    try{
                        Thread.sleep(1000);
                    }catch(InterruptedException e){
                        System.out.println(e);
                    }
                }

            }
        };
        Thread t2 = new Thread() {
            @Override
            public void run() {
                Map<String, String> map = ThreadDemo.this.getMapOfWeek();
                List<String> keys = map.keySet().stream().toList();
                for(int i = 0; i < keys.size(); i++) {
                    System.out.println(map.get(keys.get(i)));
                    try{
                        Thread.sleep(1000);
                    }catch(InterruptedException e){
                        System.out.println(e);
                    }
                }

            }
        };
        t1.start();
        t2.start();
    }
    public static void main(String []args) {
        ThreadDemo threadDemo = new ThreadDemo();
        threadDemo.testThread();
    }
}
