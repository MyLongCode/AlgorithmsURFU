import java.util.Scanner;

public class Q9 {

    // Функция для вычисления суммы цифр числа
    public static int digitSum(int number) {
        int sum = 0;
        while (number > 0) {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    // Функция для вычисления значения функции Васи в точке S
    public static long vasyaFunction(int s) {
        long[] count = new long[82]; // Используем массив для хранения количества чисел с заданной суммой цифр
        for (int i = 1; i <= 1000000000; i++) {
            int sum = digitSum(i);
            count[sum]++; // Увеличиваем количество чисел с суммой цифр sum
        }

        return count[s]; // Возвращаем количество чисел с суммой цифр s
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int s = scanner.nextInt(); // Получаем значение S из стандартного ввода
        long result = vasyaFunction(s);
        System.out.println(result);
        scanner.close();
    }
}
