public class Main {
    public static void main(String [] args) {
        //Truy cập vào 1 trang web nào đó, lấy thông tin, lưu về file text, csv, database
        //mysql, sql server
        //redis(luu du lieu dang object, collection), mongodb
        ProductController productController = new ProductController();
        productController.openUrl();
    }

}
