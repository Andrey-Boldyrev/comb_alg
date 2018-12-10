package com;

import java.util.Arrays;
import java.util.TreeSet;

public class GreedyAlg {

    public static void Alg(int[] tasks){
        //tasks - массив заданий
        Arrays.sort(tasks); //сортируем по убыванию стоимости
        TreeSet<Integer> time = new TreeSet<Integer>();
        for (int i = 1; i <= n; ++i) {
            time.add(i);
        }
        int ans = 0;
        for (int i = 0; i < n; ++i) {
            Integer tmp = time.floor(tasks[i].time);
            if (tmp == null) { // если нет свободного места в расписании, то в конец
                time.remove(time.last());
            } else { //иначе можно выполнить задание, добавляем в расписание
                time.remove(tmp);
                ans += tasks[i].cost;
            }
        }
    }
}
