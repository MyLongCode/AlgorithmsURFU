import java.util.*;

public class Q1 {

    static class State {
        int big, small1, small2;

        State(int big, int small1, int small2) {
            this.big = big;
            this.small1 = small1;
            this.small2 = small2;
        }

        @Override
        public boolean equals(Object o) {
            if (this == o) return true;
            if (o == null || getClass() != o.getClass()) return false;
            State state = (State) o;
            return big == state.big && small1 == state.small1 && small2 == state.small2;
        }

        @Override
        public int hashCode() {
            return Objects.hash(big, small1, small2);
        }
    }

    public static int getMinSteps(int N, int M, int K, int L) {
        Queue<State> queue = new LinkedList<>();
        Set<State> visited = new HashSet<>();

        State initialState = new State(N, 0, 0);
        queue.add(initialState);
        visited.add(initialState);

        int steps = 0;

        while (!queue.isEmpty()) {
            int size = queue.size();
            for (int i = 0; i < size; i++) {
                State currentState = queue.poll();
                if (currentState.big == L) {
                    return steps;
                }

                List<State> nextStates = getNextStates(currentState, N, M, K);
                for (State nextState : nextStates) {
                    if (!visited.contains(nextState)) {
                        queue.add(nextState);
                        visited.add(nextState);
                    }
                }
            }
            steps++;
        }

        return -1; // Невозможно получить ровно L мл
    }

    private static List<State> getNextStates(State currentState, int N, int M, int K) {
        List<State> states = new ArrayList<>();
        int[] capacities = {N, M, K};
        int[] amounts = {currentState.big, currentState.small1, currentState.small2};

        for (int from = 0; from < 3; from++) {
            for (int to = 0; to < 3; to++) {
                if (from != to) {
                    int[] newAmounts = Arrays.copyOf(amounts, 3);
                    int transferAmount = Math.min(newAmounts[from], capacities[to] - newAmounts[to]);

                    newAmounts[from] -= transferAmount;
                    newAmounts[to] += transferAmount;

                    states.add(new State(newAmounts[0], newAmounts[1], newAmounts[2]));
                }
            }
        }

        return states;
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        int N = in.nextInt(); // Емкость большой колбы
        int M = in.nextInt(); // Емкость первой маленькой колбы
        int K = in.nextInt(); // Емкость второй маленькой колбы
        int L = in.nextInt(); // Требуемое количество в большой колбе

        int result = getMinSteps(N, M, K, L);
        if (result != -1) {
            System.out.println(result);
        } else {
            System.out.println("OOPS");
        }
    }
}