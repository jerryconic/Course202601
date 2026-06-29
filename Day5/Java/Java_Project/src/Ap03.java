import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Ap03 extends JFrame {

    private JTextField txtData;
    private JButton btnOK;

    public Ap03() {
        setTitle("Hello JFrame");
        setSize(350, 120);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new FlowLayout());

        JLabel lblData = new JLabel("Data=");
        txtData = new JTextField(15);
        btnOK = new JButton("OK");

        btnOK.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                txtData.setText("Hello world!");
            }
        });

        add(lblData);
        add(txtData);
        add(btnOK);

        setLocationRelativeTo(null);
        setVisible(true);
    }

    public static void main(String[] args) {
        new Ap03();
    }
}