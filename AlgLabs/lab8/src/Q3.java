import java.util.*;

public class Q3 {

    // Направления движения (вверх, вниз, влево, вправо)
    private static final int[] dRow = {-1, 1, 0, 0};
    private static final int[] dCol = {0, 0, -1, 1};

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Чтение входных данных
        int N = scanner.nextInt();
        int M = scanner.nextInt();
        scanner.nextLine(); // Чтение оставшегося перевода строки

        char[][] grid = new char[N][M];
        boolean[][] visited = new boolean[N][M];

        // Чтение сетки
        for (int i = 0; i < N; i++) {
            String line = scanner.nextLine();
            for (int j = 0; j < M; j++) {
                grid[i][j] = line.charAt(j);
            }
        }

        int rugCount = 0;

        // Обход всех клеток сетки
        for (int row = 0; row < N; row++) {
            for (int col = 0; col < M; col++) {
                if (grid[row][col] == '+' && !visited[row][col]) {
                    dfs(grid, visited, row, col, N, M);
                    rugCount++;
                }
            }
        }

        System.out.println(rugCount);
    }

    // DFS для поиска всех клеток, принадлежащих одному коврику
    private static void dfs(char[][] grid, boolean[][] visited, int row, int col, int N, int M) {
        Stack<int[]> stack = new Stack<>();
        stack.push(new int[]{row, col});
        visited[row][col] = true;

        while (!stack.isEmpty()) {
            int[] cell = stack.pop();
            int currentRow = cell[0];
            int currentCol = cell[1];

            for (int i = 0; i < 4; i++) {
                int newRow = currentRow + dRow[i];
                int newCol = currentCol + dCol[i];

                if (isValid(newRow, newCol, N, M) && grid[newRow][newCol] == '+' && !visited[newRow][newCol]) {
                    stack.push(new int[]{newRow, newCol});
                    visited[newRow][newCol] = true;
                }
            }
        }
    }

    // Проверка валидности координат
    private static boolean isValid(int row, int col, int N, int M) {
        return row >= 0 && row < N && col >= 0 && col < M;
    }
}
