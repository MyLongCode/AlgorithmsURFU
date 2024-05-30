import java.util.*;

public class Q2 {

    static class Cell {
        int row, col, energy;

        Cell(int row, int col, int energy) {
            this.row = row;
            this.col = col;
            this.energy = energy;
        }
    }

    public static int minEnergy(int[][] heights) {
        int rows = heights.length;
        int cols = heights[0].length;

        int[][] energy = new int[rows][cols];
        for (int[] row : energy) {
            Arrays.fill(row, Integer.MAX_VALUE);
        }

        PriorityQueue<Cell> pq = new PriorityQueue<>(Comparator.comparingInt(c -> c.energy));
        pq.add(new Cell(0, 0, 0));
        energy[0][0] = 0;

        // Смещения
        int[] dRow = {-1, 1, 0, 0};
        int[] dCol = {0, 0, -1, 1};

        while (!pq.isEmpty()) {
            Cell current = pq.poll();

            for (int i = 0; i < 4; i++) {
                int newRow = current.row + dRow[i];
                int newCol = current.col + dCol[i];

                if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols) {
                    int heightDiff = heights[newRow][newCol] - heights[current.row][current.col];
                    int newEnergy = current.energy + Math.max(0, heightDiff);

                    if (newEnergy < energy[newRow][newCol]) {
                        energy[newRow][newCol] = newEnergy;
                        pq.add(new Cell(newRow, newCol, newEnergy));
                    }
                }
            }
        }

        return energy[rows - 1][cols - 1];
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        int n = in.nextInt();
        int m = in.nextInt();

        int[][] heights = new int[n][m];

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                heights[i][j] = in.nextInt();
            }
        }

        int result = minEnergy(heights);
        System.out.println(result);
    }
}
