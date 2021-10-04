public class MyThread extends Thread{
    private long id;
    public MyThread(long id) {
        this.id = id;
        //System.out.println(String.format("Init thread with id: %d", this.id));
    }
    @Override
    public void run() {
        super.run();
        try {
            //System.out.println(String.format("Running thread with id: %d", this.id));
            Thread.sleep(2);
            for(int j = 1; j < 1_000_000_000; j++) {}

        } catch (InterruptedException e) {
            //System.err.println(String.format("Thread with id: %ld is interrupted, error: %s", this.id, e.toString()));
        }
        System.out.println(String.format("Finish thread with id: %d", this.id));
    }
}
