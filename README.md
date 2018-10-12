# FindIntegerInList
Encontrar el valor faltante dentro de una lista de numeros enteros mayor a uno.

Otra forma de hacerlo:
1.- La suma de los primeros números enteros es n*(n+1)/2
2.- Recorre en arreglo y obtiene el máximo y la suma de los elementos

El número que buscas es la resta del calculo del punto 1 usando el máximo y la suma que obtienes en el punto 2

Ejemplo
[1,2,4,6,3,7,8]
El máximo es 8, la suma es 31
8*9/2-31=36-31=5
