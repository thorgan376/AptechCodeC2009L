import models.Product;
import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.support.ui.WebDriverWait;

import java.time.Duration;
import java.util.ArrayList;
import java.util.List;

public class ProductController {
    private ArrayList<Product> products = new ArrayList<>();
    public String getUrl(Integer pageNumber){
        return "https://www.amazon.com/s?i=electronics&bbn=1266092011&rh=n%3A172282%2Cn%3A1266092011%2Cn%3A172659&field-shipping_option-bin=3242350011&pf_rd_i=16225009011&pf_rd_m=ATVPDKIKX0DER&pf_rd_p=85a9188d-dbd5-424e-9512-339a1227d37c&pf_rd_r=DKM0CNXR11CB4PP7AACP&pf_rd_s=merchandised-search-5&pf_rd_t=101&qid=1623412683&rnid=1266092011&ref=sr_pg_"
                +String.valueOf(pageNumber)+
                "&page="+String.valueOf(pageNumber);
    }
    private String getChromeDriverPath() {
        //check hdh
        String osName = System.getProperty("os.name");
        return osName.startsWith("Windows") ?
                "C:/Users/sunli/Documents/chromedriver.exe":
                "/Users/nguyenduchoang/Documents/chromedriver";
    }
    //phuong thuc tu mo duong link,tu truy cap, tu mo chrome! => selenium
    public void openUrl() {
        System.setProperty("webdriver.chrome.driver", getChromeDriverPath());

        WebDriver driver = new ChromeDriver();
        WebDriverWait wait = new WebDriverWait(driver, 5L);
        try {
            driver.get(this.getUrl(1));
            //
            String xPath = "//*[@class='s-main-slot s-result-list s-search-results sg-row']";
            List<WebElement> elements = (driver.findElement(By.xpath(xPath))).findElements(By.xpath("./child::*"));
            this.products.clear();
            //for (WebElement eachElement: elements) {
            for(int i = 0; i < elements.size(); i++){
                WebElement eachElement = elements.get(i);
                String productName = eachElement.findElement(By.xpath("//span[@class='a-size-base-plus a-color-base a-text-normal']")).getText();
                //eachElement.findElement(By.className("a-section a-spacing-medium"))
                Integer numberOfLikes = Integer.valueOf(
                        eachElement.findElement(By.xpath("//span[@class='a-size-base']")).getText()
                                .replace(",",""));
                String categoryName = eachElement.findElement(By.xpath("//a[@class='a-size-base a-link-normal a-text-bold']")).getText();
                String urlImage = eachElement.findElement(By.xpath("//img[@class='s-image']")).getAttribute("src");
                Double price = Double.valueOf(eachElement.findElement(By.xpath("//span[@class='a-price']"))
                                .getText()
                                .replace("$","")
                                .replace("\n","."));

                String urlDetail = eachElement.findElement(By.xpath("//a[@class='a-size-base a-link-normal a-text-normal']")).getAttribute("href");
                //*[@id="search"]/div[1]/div/div[1]/div/span[3]/div[2]/div[1]/div/span/div/div/div[4]/div[2]/a/span/span[1]
                System.out.println("haha");
                Product product = new Product(productName, numberOfLikes, categoryName, urlImage, price, urlDetail);
                products.add(product);
                //eachElement.findElement(By.xpath("//a[@class='a-link-normal a-text-normal']"))
            }
            System.out.println("haha");
            //*[@id="search"]/div[1]/div/div[1]/div/span[3]/div[2]
            //html/body/div[1]/div[2]/div[1]/div/div[1]/div/span[3]/div[2]

//            driver.findElement(By.name("q")).sendKeys("cheese" + Keys.ENTER);
//            WebElement firstResult = wait.until(presenceOfElementLocated(By.cssSelector("h3")));
//            System.out.println(firstResult.getAttribute("textContent"));
            System.out.println("haha, thanh cong");
        } catch (Exception exception) {
            System.err.println("Error: "+exception);
        }finally {
            driver.quit();
        }
    }
}
