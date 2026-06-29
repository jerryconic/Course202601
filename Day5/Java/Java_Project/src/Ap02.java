import java.util.Scanner;
public class Ap02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		int a, b; 
		Scanner sc = new Scanner(System.in);
		
		System.out.print("a=");
		a = sc.nextInt();
		
		System.out.print("b=");
		b = sc.nextInt();
		
		sc.close();
		
		System.out.printf("%d + %d = %d", a, b, a + b);
		
	}

}
