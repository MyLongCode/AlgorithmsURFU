import java.util.*;

public class Q6 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Чтение размеров сетки
        int N = scanner.nextInt();
        int M = scanner.nextInt();

        // Чтение количества кварталов, через которые можно пройти по диагонали
        int K = scanner.nextInt();

        // Создание множества для хранения кварталов с возможностью диагонального прохода
        Set<String> diagonalBlocks = new HashSet<>();
        for (int i = 0; i < K; i++) {
            int x = scanner.nextInt();
            int y = scanner.nextInt();
            diagonalBlocks.add(x + "," + y);
        }

        // Массив для хранения минимального расстояния до каждого перекрестка
        double[][] dp = new double[M + 1][N + 1];

        // Инициализация массива расстояний
        for (int i = 0; i <= M; i++) {
            Arrays.fill(dp[i], Double.MAX_VALUE);
        }

        dp[0][0] = 0; // Начальная точка

        // Заполнение массива расстояний
        for (int y = 0; y <= M; y++) {
            for (int x = 0; x <= N; x++) {
                if (x > 0) {
                    dp[y][x] = Math.min(dp[y][x], dp[y][x - 1] + 100);
                }
                if (y > 0) {
                    dp[y][x] = Math.min(dp[y][x], dp[y - 1][x] + 100);
                }
                if (x > 0 && y > 0 && diagonalBlocks.contains(x + "," + y)) {
                    dp[y][x] = Math.min(dp[y][x], dp[y - 1][x - 1] + 100 * Math.sqrt(2));
                }
            }
        }

        // Вывод длины кратчайшего пути, округленной до целых метров
        System.out.println((int)Math.round(dp[M][N]));
    }
}
