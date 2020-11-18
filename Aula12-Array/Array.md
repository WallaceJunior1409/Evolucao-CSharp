# Array

### Unidimensionais
* Array -> vetores
* Array = coleção de valores do mesmo  tipo

* `int[] id = new id[3];` -> array com inicialização (tamanho definido)
* `int[] id = new id[3]{12,31,43};` -> array com inicialização e atribuição (tamanho definido)
* `int[] id = {12,31,43};` -> array com atribuição (tamanho definido pelo numero de elementos)

### Bidimencionais
* Matrizes - coleção de array

* `int[,] id = new int[3,3];`
* `int[,] number2 = new int[2,2]{{11, 12}, {13, 14}};`


# Metodos de Array

### BinarySearch(array, valor) 
* Requer uma matriz unidimencional e um valor. Ele pesquisa o valor na matriz e retorna a posição do mesmo.

### Copy(Ar_origem, originIndex, Ar_destino, destinationIndex, Qtde)
* Copia um intervalo de elementos de um Array a partir de um índice de origem especificado e coloca-los em outro Array a partir do índice de destino específico.

### CopyTo(Array array, int idx)
* Copia todos os itens de uma matriz unidimensional atual para uma matriz unidimensional especificada começando no índice da matriz de destino especificado.

