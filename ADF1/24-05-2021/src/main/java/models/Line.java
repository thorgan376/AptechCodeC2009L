package models;

public class Line {
    private Point startPoint, endPoint;
    public Line(Point startPoint, Point endPoint) {
        this.startPoint = startPoint;
        this.endPoint = endPoint;
    }
    public Double getLength() {
        return startPoint.getDistance(endPoint);
    }

    @Override
    public String toString() {
        return String.format("line's detail: startPoint: %s, endPoint: %s", startPoint, endPoint);
    }
}
