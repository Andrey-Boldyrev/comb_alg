package com;
//класс, проверяющий, какие комбинации подходят

class FindVariants {
    private int ans;
    private int[] arr;
    FindVariants(int ans, int[] arr){
        this.ans=ans;
        this.arr=arr;
    }

    //ищем все варианты
    String findVariants() {
        //для подсчёта значения выражения
        char[] source =new char[] {'-', '+', '/', '*',' '};
        Calc c=new Calc();
        int nump = source.length; //количество переставляемых значения
        int len = arr.length-1;  //на скольких местах переставляем
        int h = nump>len? nump:len; // размер массива выбирается как max(nump,len)
        int[] per = new int[h];
        for (int i=0;i<h;i++)
            per[i]=0;//заполнили массив 0 - индексами первой перестановки

        //ищем подходящие комбинаци
        String resStr = "";
        String calcStr;
        do{    //собираем выражение в одну строку
            int j = 0; //индекс позиции в комбинации.
            calcStr=String.valueOf(arr[0]); // первый символ строки это первая цифра
            for (int i = 1; i < arr.length; i++) {  //цикл по числам, для которых нужно подобрать знаки
                switch (source[per[j]]) {   //добавляем знаки
                    case '+':
                        calcStr = calcStr+ '+'+ String.valueOf(arr[i]);
                        break;
                    case '-':
                        calcStr = calcStr +'-'+ String.valueOf(arr[i]);
                        break;
                    case '*':
                        calcStr = calcStr +'*'+ String.valueOf(arr[i]);
                        break;
                    case '/':
                        calcStr = calcStr +'/'+ String.valueOf(arr[i]);
                        break;
                    case ' ':
                        calcStr+= String.valueOf(arr[i]);
                }
                j++;
            }
            String res=c.calc(calcStr);  //получившуюся строку считаем

            //если полученнный ответ и требуемый равны, то запоминаем комбинацию в resStr
            if (Character.isDigit(res.toCharArray()[0]))
                if (Integer.parseInt(res) == ans) {
                    resStr += calcStr + " = " + ans + "\n";
                }
        }while (PermutationsWithRepetition.getNextPlacing(per,nump,len));
        return resStr;
    }
}