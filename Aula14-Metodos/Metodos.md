# Metodos

* Conjunto de instruções que podem ser chamados no meio do código. Pode trabalhar com paramentros de entrada ou saida.

### Metodos Simples
``` 
public void nameMethod() {}
```
### Metodos com argumentos (paramentros)

* Servem para passar valores aos metodos com o intuito dos mesmos utilizarem.
* Ao passar uma variável como parametro, o metodo cria um novo espaço na memória com o valor  copiado da mesma com o intuito de utiliza-la.

```
public void form (String params1, int params2) {}
```

### Metodos com argumentos e saida

* Servem para passar valores aos metodos com o intuito dos mesmos utilizarem, retornando um valor.

```
String name = "Wallace";
public string getName(String name) 
{
    return name;
}

String newName = getName(name);
```

### Metodos com argumentos referenciados (REF)

* Ao passar uma variavel referenciada no metodo, ele reutiliza o endereço na memoria da variavel referenciada para guardar uma nova informação, não precisando criar um novo espaço na memória.

```
int age = 20;
public void doubleAge(ref int params) 
{
    params *= 2;
}
Console.WriteLine(age); // result = 40

```

### Metodos com referenciamento de saída (OUT)

* Não sendo um Array, o metodo consegue retornar somente um valor, mas, ao colocar-mos o OUT, 

```
int rest;

public int dividedValue(int value, out rest) 
{
    return value/3;
}
Console.WriteLine("Divisão é : {0} sobrando {1}", dividedValue(10, out rest), rest);

```

### Metodos com multiplos parametros (params)

* O metodo recebe varios parametros não tendo a necessidade de criar um novo espço na memoria para cada parametro recebido. Ele armazena esses parametros dentro de um array.

```
public void some(params int[]numbers) 
{
    int result = 0;
    for (int i=0; i<numbers.Length; i++)
    {
        result += numbers;
    }

    Console.Write("A soma dos parametros é: {0}", result);
}


```