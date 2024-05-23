import java.util.Scanner;

public class Q1 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();
        solve(n);
    }

    public static void solve(int n) {
        int a = 2;
        while (a < n) {
            a += isqrt(a + isqrt(a) + 1) + 1;
            if (a == n) {
                System.out.println("First");
                return;
            }
        }
        System.out.println("Second");
    }

    public static int isqrt(int value) {
        return (int) Math.sqrt(value);
    }
}