//произведение пар чисел в одномерном массиве
//парой считаем первый и послепдний элемент массива
//результат записать в новый массив

int [] array = new int [] {1, 2, 3, 4, 5, 7, 8};
int [] printArr = new int [array.Length/2];

for(int i = 0; i<array.Length/2;i++){
    printArr[i] = array[i] * array[array.Lenght-1-i];
}
for(int i = 0; i<printArr.Lenght; i++){
    Console.Write($"{printArr[i]} ");
}

