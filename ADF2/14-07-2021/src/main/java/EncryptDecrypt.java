import javax.crypto.Cipher;
import javax.crypto.NoSuchPaddingException;
import java.security.InvalidKeyException;
import java.security.KeyPair;
import java.security.KeyPairGenerator;
import java.security.NoSuchAlgorithmException;

public class EncryptDecrypt {
    private KeyPairGenerator keyPairGen;
    private KeyPair pair;
    public EncryptDecrypt() {
        try {
            keyPairGen = KeyPairGenerator.getInstance("RSA");
            keyPairGen.initialize(2048);
        } catch (NoSuchAlgorithmException e) {
            e.printStackTrace();
        }
    }
    public String encryptData(String inputString) {
        try {
            this.pair = keyPairGen.generateKeyPair();
            //Cipher cipher = Cipher.getInstance("RSA/ECB/PKCS1Padding");
            Cipher cipher = Cipher.getInstance("RSA");
            //Initializing a Cipher object
            cipher.init(Cipher.ENCRYPT_MODE, pair.getPublic());
            //Adding data to the cipher
            byte[] input = inputString.getBytes();
            cipher.update(input);
            //encrypting the data
            byte[] cipherText = cipher.doFinal();
            return new String(cipherText);
        } catch (Exception e) {
            e.printStackTrace();
        }
        return "";
    }
    public String decryptData(String inputString) {
        try {
            //Cipher cipher = Cipher.getInstance("RSA/ECB/PKCS1Padding");
            Cipher cipher = Cipher.getInstance("RSA");
            //Initializing a Cipher object
            cipher.init(Cipher.DECRYPT_MODE, pair.getPrivate());
            byte[] decipheredText = cipher.doFinal(inputString.getBytes());
            return new String(decipheredText);
        } catch (Exception e) {
            e.printStackTrace();
        }
        return "";
    }

}
