public class Track {
    private String name;
    private Integer viewCount;

    public Track(String name, Integer viewCount) {
        this.name = name;
        this.viewCount = viewCount;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Integer getViewCount() {
        return viewCount;
    }

    public void setViewCount(Integer viewCount) {
        this.viewCount = viewCount;
    }

    @Override
    public String toString() {
        return "Track{" +
                "name='" + name + '\'' +
                ", viewCount=" + viewCount +
                '}';
    }
}
