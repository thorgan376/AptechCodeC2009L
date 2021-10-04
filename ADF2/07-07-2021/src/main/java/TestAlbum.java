import java.util.ArrayList;
import java.util.Collection;
import java.util.List;
import java.util.NoSuchElementException;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class TestAlbum {
    public static void main(String []args) {
        Artist tungDuong = new Artist("Tung Duong");
        Artist quangTho = new Artist("Quang Tho");
        Artist quangLe = new Artist("Quang Le");
        Artist nhuQuynh = new Artist("Nhu Quynh");
        List<Track> tracks1 = new ArrayList<>();
        tracks1.add(new Track("Bai ca hi vong", 15000));
        tracks1.add(new Track("Ao mua dong", 12000));
        tracks1.add(new Track("Mau hoa do", 130));
        tracks1.add(new Track("Que nha", 1500));
        tracks1.add(new Track("Me yeu con", 12300));

        List<Track> tracks2 = new ArrayList<>();
        tracks2.add(new Track("Ha Buon", 500));
        tracks2.add(new Track("Vung la me bay", 1000));
        tracks2.add(new Track("Noi buon hoa Phuong", 130));
        tracks2.add(new Track("Phuong hong", 10000));

        Album album1 = new Album("Album 1");
        album1.setTracks(tracks1);
        album1.getMusicians().add(tungDuong);
        album1.getMusicians().add(quangTho);

        Track trackWithMinViewCount =  Stream.of(tracks1, tracks2)
                .flatMap(Collection::stream)
                .collect(Collectors.toList())
                .stream()
                .min((trackA, trackB) -> trackA.getViewCount().compareTo(trackB.getViewCount()))
                .orElseThrow(NoSuchElementException::new);
        System.out.println("Track with min count :"+trackWithMinViewCount.toString());

        Track trackWitMaxViewCount =  Stream.of(tracks1, tracks2)
                .flatMap(Collection::stream)
                .max((trackA, trackB) -> trackA.getViewCount().compareTo(trackB.getViewCount()))
                .orElseThrow(NoSuchElementException::new);
        System.out.println("Track with max count :"+trackWitMaxViewCount.toString());

    }
}
