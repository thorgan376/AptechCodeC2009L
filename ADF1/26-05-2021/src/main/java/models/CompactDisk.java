package models;

public class CompactDisk {
    private Integer id;
    private String cdTitle;
    private String artist;
    private int numberOfSongs;
    private Double price;

    //constructor with all fields
    public CompactDisk(Integer id, String cdTitle, String artist, int numberOfSongs, Double price) {
        this.id = id;
        this.cdTitle = cdTitle;
        this.artist = artist;
        this.numberOfSongs = numberOfSongs;
        this.price = price;
    }

    //ten ham giong nhau, so tham so khac nhau
    //=> overloading
    public CompactDisk(String cdTitle, String artist) {
        this.cdTitle = cdTitle;
        this.artist = artist;
        this.numberOfSongs = 1;
        this.price = 10.0;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getCdTitle() {
        return cdTitle;
    }

    public void setCdTitle(String cdTitle) {
        this.cdTitle = cdTitle;
    }

    public String getArtist() {
        return artist;
    }

    public void setArtist(String artist) {
        this.artist = artist;
    }

    public int getNumberOfSongs() {
        return numberOfSongs;
    }

    public void setNumberOfSongs(int numberOfSongs) {
        this.numberOfSongs = numberOfSongs;
    }

    public Double getPrice() {
        return price;
    }

    public void setPrice(Double price) {
        this.price = price;
    }

    @Override
    public String toString() {
        return String.format(
                "id = %d, title = %s, artist = %s, numberOfSongs = %d, price = %f",
                id, cdTitle, artist, numberOfSongs, price);
    }
}
