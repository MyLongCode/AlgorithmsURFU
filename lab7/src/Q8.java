import java.util.Scanner;

public class Q8 {
    public static int MOD = 1000000007;

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();
        int a = sc.nextInt();
        int b = sc.nextInt();

        System.out.println(getVariants(n, a, b));
    }

    private static int getVariants(int n, int a, int b) {
        int[] dA = new int[50001];
        int[] dB = new int[50001];

        dA[0] = 1;
        dA[1] = 1;
        dB[0] = 1;
        dB[1] = 1;

        for (int i = 2; i <= n; i++) {
            int sum = 0;
            for (int k = 1; k <= a && i >= k; k++) {
                sum += dB[i - k] % MOD;
                sum %= MOD;
            }
            dA[i] = sum;
            sum = 0;
            for (int k = 1; k <= b && i >= k; k++) {
                sum += dA[i - k] % MOD;
                sum %= MOD;
            }
            dB[i] = sum;
        }

        return (dA[n] + dB[n]) % MOD;
    }
}
