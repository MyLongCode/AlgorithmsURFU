import java.util.Scanner;

public class Q5 {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        int n = in.nextInt();
        int m = in.nextInt();

        int[][] table = new int[n][m];

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                table[i][j] = in.nextInt();
            }
        }

        System.out.println(findMaxSum(table));
    }

    public static int findMaxSum(int[][] table) {
        int n = table.length;
        int m = table[0].length;
        int[][] result = new int[n][m];

        int maxSum = Integer.MIN_VALUE;

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                result[i][j] = 0;
                for (int i1 = 0; i1 <= i; i1++) {
                    for (int j1 = 0; j1 <= j; j1++) {
                        result[i][j] += table[i1][j1];
                    }
                }
                if (result[i][j] > maxSum) maxSum = result[i][j];
            }
        }
        return maxSum;
    }
}
