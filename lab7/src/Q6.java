import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Q6 {
    public static class Conference implements Comparable<Conference> {
        int start, end, sub;

        public Conference(int start, int end) {
            this.start = start;
            this.end = end;
            this.sub = end - start;
        }

        @Override
        public int compareTo(Conference other) {
            return Integer.compare(this.sub + this.start, other.sub + other.start);
        }
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        int n = in.nextInt();

        Conference[] conferences = new Conference[n];

        for (int i = 0; i < n; i++) {
            conferences[i] = new Conference(in.nextInt(), in.nextInt());
        }

        Arrays.sort(conferences);

        for (int i = 0; i < n; i++) {
            System.out.println(conferences[i].start + " " + conferences[i].end);
        }

        System.out.println(getMaxCount(conferences));
    }

    public static int getMaxCount(Conference[] conferences) {
        int count = 1;
        int lastEnd = conferences[0].end;

        for (int i = 1; i < conferences.length; i++) {
            if (conferences[i].start > lastEnd) {
                count++;
                lastEnd = conferences[i].end;
            }
        }

        return count;
    }
}
