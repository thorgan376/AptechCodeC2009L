package views;

import javax.swing.*;
import java.awt.*;
import java.awt.Dimension;
import java.awt.EventQueue;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.List;
import java.util.TimerTask;
import javax.swing.JFrame;

import models.Point;
import org.jfree.chart.ChartPanel;
import org.jfree.chart.JFreeChart;
import org.jfree.chart.axis.NumberAxis;
import org.jfree.chart.axis.SymbolAxis;
import org.jfree.chart.plot.XYPlot;
import org.jfree.chart.renderer.xy.XYSplineRenderer;
import org.jfree.data.xy.XYDataset;
import org.jfree.data.xy.XYSeries;
import org.jfree.data.xy.XYSeriesCollection;

public class SPlineView implements IView{
    private static final int NUMBER_OF_SAMPLE = 30;
    private static final int FREQUENCY = 1000 / 24;
    private int width, height;
    private JFrame mainFrame = new JFrame("Test do thi");
    public SPlineView(int width, int height) {
        this.width = width;
        this.height = height;
        //chay tu dong 1 sec / lan
        javax.swing.Timer timer = new Timer(FREQUENCY,new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                //countUp ++; //state thay doi, data phai thay doi
                System.out.println("rrrrrrrrrr");
                setPoints(getRandomData(NUMBER_OF_SAMPLE));
            }
        });

        java.util.Timer tt = new java.util.Timer(false);
        tt.schedule(new TimerTask() {
            @Override
            public void run() {
                timer.start();
            }
        }, 0);

    }
    //data or "internal state"
    private ArrayList<Point> points = new ArrayList<Point>();
    private ChartPanel chartPanel;

    public void setPoints(ArrayList<Point> points) {
        this.points = points;
        //update data, reload UI
        XYSeries series = new XYSeries("Frequency");
        String[] labels = new String[this.points.size()];
        int i = 0;
        for (Point eachPoint: this.points) {
            series.add(eachPoint.getX(), eachPoint.getY());
            labels[i] = String.valueOf(eachPoint.getX());
            i ++;
        }
        XYDataset dataset = new XYSeriesCollection(series);
        NumberAxis domain = new SymbolAxis("X", labels);
        NumberAxis range = new NumberAxis("Y");
        XYSplineRenderer r = new XYSplineRenderer(8);
        XYPlot xyplot = new XYPlot(dataset, domain, range, r);
        JFreeChart chart = new JFreeChart(xyplot);

        if(this.chartPanel == null) {
            this.chartPanel = new ChartPanel(chart) {
                @Override
                public Dimension getPreferredSize() {
                    return new Dimension(640, 200);
                }
            };
        }
        this.chartPanel.setChart(chart);
        mainFrame.setVisible(true);
    }
    private ArrayList<Point> getRandomData(int size) {
        //sau nay se thay bang lay du lieu tu Server
        ArrayList<Point> newPoints = new ArrayList<Point>();
        for(int i = 0; i < size; i++) {
            float x = i;
            float y = this.getRandomNumber(1, 100);
            newPoints.add(new Point(x, y));
        }
        return newPoints;
    }
    private float getRandomNumber(float min, float max) {
        return (float) Math.floor(Math.random()*(max - min+1) + min);
    }
    @Override
    public void setupUI(int width, int height) {
        setPoints(this.getRandomData(NUMBER_OF_SAMPLE));
        mainFrame.add(this.chartPanel);
        mainFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        mainFrame.pack();
        mainFrame.setLocationRelativeTo(null);
    }

    @Override
    public void show() {
        mainFrame.setVisible(true);
    }
    @Override
    public void hide() {
        mainFrame.setVisible(false);
    }
}
