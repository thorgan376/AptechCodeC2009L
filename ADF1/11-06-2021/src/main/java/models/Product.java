package models;

public class Product {
    private String productName;
    private Integer numberOfLikes;
    private String categoryName;
    private String urlImage;
    private Double price;
    private String urlDetail;

    public Product(String productName, Integer numberOfLikes,
                   String categoryName, String urlImage, Double price, String urlDetail) {
        this.productName = productName;
        this.numberOfLikes = numberOfLikes;
        this.categoryName = categoryName;
        this.urlImage = urlImage;
        this.price = price;
        this.urlDetail = urlDetail;
    }

    public String getProductName() {
        return productName;
    }

    public void setProductName(String productName) {
        this.productName = productName;
    }

    public Integer getNumberOfLikes() {
        return numberOfLikes;
    }

    public void setNumberOfLikes(Integer numberOfLikes) {
        this.numberOfLikes = numberOfLikes;
    }

    public String getCategoryName() {
        return categoryName;
    }

    public void setCategoryName(String categoryName) {
        this.categoryName = categoryName;
    }

    public String getUrlImage() {
        return urlImage;
    }

    public void setUrlImage(String urlImage) {
        this.urlImage = urlImage;
    }

    public Double getPrice() {
        return price;
    }

    public void setPrice(Double price) {
        this.price = price;
    }

    public String getUrlDetail() {
        return urlDetail;
    }

    public void setUrlDetail(String urlDetail) {
        this.urlDetail = urlDetail;
    }
}
