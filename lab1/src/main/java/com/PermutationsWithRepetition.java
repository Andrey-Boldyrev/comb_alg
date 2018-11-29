package com;

//класс, генерирующий следущий вариант размещения
public class PermutationsWithRepetition {

    //метод принимает на вход и возвращает массив индексов массива source
    public static boolean getNextPlacing (int[] perest,int srcLength, int variationLength){
        int j = variationLength-1;
        while ((j>=0) && (perest[j] == srcLength-1)) j--;
        if (j<0) return false;
        if (perest[j]>=srcLength) j--;
        perest[j]++;
        if (j == variationLength -1) return true;
        for (int k = j+1;k<variationLength;k++)
            perest[k] = 0;
        return true;
    }


}