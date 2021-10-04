package views;

public class RegisterView extends LoginView {
    public RegisterView(int width, int height) {
        super(width, height);
    }
    //Giong man hinh login, them truong "nhap lai password"
    //muon tan dung LoginView

    @Override
    public void setupUI(int width, int height) {
        super.setupUI(width, height);
        this.getGridLayout().setRows(4);

    }
}
