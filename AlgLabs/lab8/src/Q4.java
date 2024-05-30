import java.util.*;

public class Q4 {

    static class Edge implements Comparable<Edge> {
        int from, to;
        double weight;

        Edge(int from, int to, double weight) {
            this.from = from;
            this.to = to;
            this.weight = weight;
        }

        @Override
        public int compareTo(Edge other) {
            return Double.compare(this.weight, other.weight);
        }
    }

    static int[] parent;
    static int[] rank;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int N = scanner.nextInt();
        int[][] towers = new int[N][2];

        for (int i = 0; i < N; i++) {
            towers[i][0] = scanner.nextInt();
            towers[i][1] = scanner.nextInt();
        }

        double result = findMinimumRadius(N, towers);
        System.out.printf("%.4f\n", result);
    }

    // Метод для поиска минимального радиуса
    public static double findMinimumRadius(int N, int[][] towers) {
        List<Edge> edges = new ArrayList<>();

        for (int i = 0; i < N; i++) {
            for (int j = i + 1; j < N; j++) {
                double distance = Math.sqrt(Math.pow(towers[i][0] - towers[j][0], 2) +
                        Math.pow(towers[i][1] - towers[j][1], 2));
                edges.add(new Edge(i, j, distance));
            }
        }

        Collections.sort(edges);

        parent = new int[N];
        rank = new int[N];
        for (int i = 0; i < N; i++) {
            parent[i] = i;
            rank[i] = 0;
        }

        double maxEdgeInMST = 0.0;
        int edgesUsed = 0;
        for (Edge edge : edges) {
            if (union(edge.from, edge.to)) {
                maxEdgeInMST = edge.weight;
                edgesUsed++;
                if (edgesUsed == N - 1) {
                    break;
                }
            }
        }

        return maxEdgeInMST;
    }

    // Находит корень элемента
    static int find(int x) {
        if (parent[x] != x) {
            parent[x] = find(parent[x]);
        }
        return parent[x];
    }

    // Объединяет два множества
    static boolean union(int x, int y) {
        int rootX = find(x);
        int rootY = find(y);

        if (rootX != rootY) {
            if (rank[rootX] > rank[rootY]) {
                parent[rootY] = rootX;
            } else if (rank[rootX] < rank[rootY]) {
                parent[rootX] = rootY;
            } else {
                parent[rootY] = rootX;
                rank[rootX]++;
            }
            return true;
        }
        return false;
    }
}
