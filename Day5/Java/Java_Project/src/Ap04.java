import javax.swing.*;
import java.awt.*;

public class Ap04 extends JFrame {

    private JTextField txtA;
    private JTextField txtB;
    private JTextField txtAns;

    public Ap04() {
        setTitle("簡易計算機");
        setSize(350, 200);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new FlowLayout());

        JLabel lblA = new JLabel("A=");
        txtA = new JTextField(10);

        JLabel lblB = new JLabel("B=");
        txtB = new JTextField(10);

        JLabel lblAns = new JLabel("Ans=");
        txtAns = new JTextField(10);
        txtAns.setEditable(false);

        JButton btnAdd = new JButton("+");
        JButton btnSub = new JButton("-");
        JButton btnMul = new JButton("*");
        JButton btnDiv = new JButton("/");

        btnAdd.addActionListener(e -> calc("+"));
        btnSub.addActionListener(e -> calc("-"));
        btnMul.addActionListener(e -> calc("*"));
        btnDiv.addActionListener(e -> calc("/"));

        add(lblA);
        add(txtA);

        add(lblB);
        add(txtB);

        add(lblAns);
        add(txtAns);

        add(btnAdd);
        add(btnSub);
        add(btnMul);
        add(btnDiv);

        setLocationRelativeTo(null);
        setVisible(true);
    }

    private void calc(String op) {
        try {
            double a = Double.parseDouble(txtA.getText());
            double b = Double.parseDouble(txtB.getText());
            double ans = 0;

            switch (op) {
                case "+":
                    ans = a + b;
                    break;
                case "-":
                    ans = a - b;
                    break;
                case "*":
                    ans = a * b;
                    break;
                case "/":
                    if (b == 0) {
                        txtAns.setText("不可除以0");
                        return;
                    }
                    ans = a / b;
                    break;
            }

            txtAns.setText(String.valueOf(ans));

        } catch (NumberFormatException ex) {
            txtAns.setText("請輸入數字");
        }
    }

    public static void main(String[] args) {
        new Ap04();
    }
}