# Контрольная работа

## Задание:

### _Задача:_

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### _Примеры:_

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

## Решение:

1. Создаем исходный массив строк.
2. Для того что-бы создать новый массив, необходимо подсчитать количество строк соответствующих условию задачи.
3. Задаем новый массив равный count. В нем сохраняются строки соответствующие условию.
4. Отображаем резульаты в консоль.