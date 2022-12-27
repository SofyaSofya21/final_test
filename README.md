# Описание решения задачи

## Задача
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
______

### Как работает программа

1. Программа принимает на вход строку, которую вводит пользователь.
2.  Программа делит строку на массив строк, считая разделителем один пробел. Используемый метод:

        StringSplit(string)

3. Программа проверяет длину каждого элемента массива, и если он меньше либо равен 3 символам, данный элемент добавляется к новому массиву. 

        AddElementInArray(string[], string)

4. Программа выводит на экран первоначальный массив и новый массив, в котором только элементы из трех или менее символов из первого массива (если таковые имеются). Используется метод:

        PrintStringArray(string[])
_____
_Дополнительное описание работы метода дополнения массива новым элементом_

    AddElementInArray(string[], string)

Пополнение массива (в пункте 3) происходит с помощью метода, который использует вспомогательный массив. Сначала создается новый вспомогательный массив на один элемент длиннее вводного массива. Последнему элементу присваивается необходимое значение. Через цикл все элементы вспомогательного массива, начиная с 0-го до предпоследнего, приобретают значения элементов вводного массива. В итоге получаем копию вводного массива плюс один заданный элемент.

___