public class Main {
    public static void main(String[] args) {
        /*
        System.out.println("Multi thread demo");
        List<Thread> threads = new ArrayList<>();
        int numberOfThreads = 1_000_000_000;
        for(int i = 0; i < numberOfThreads; i++) {
            MyThread myThread = new MyThread(i);
            myThread.start();
            threads.add(myThread);
        }
        System.out.println("Number of threads: "+threads.size());
         */
        EncryptDecrypt encryptDecrypt = new EncryptDecrypt();
        String encryptedString = encryptDecrypt.encryptData("123456");
        System.out.println(encryptedString);
        String decryptedString = encryptDecrypt.decryptData(encryptedString);
        System.out.println(decryptedString);
    }
}
