# Formatação de Saída no Console

* string product = "car";
* double price = 29000.99;
* double profit = o.6;
* `Console.WriteLine("Produto......:\t" + product);`

[1] - Indices :
* `Console.WriteLine("Produto......:{0}", product);`
* `Console.WriteLine("Produto......:{0, 15}", product);` -> indice + espaçamento
* `Console.WriteLine("Val.Produto..:{0, 15:c}", price);` -> indice + espaçamento + formatação R$
* `Console.WriteLine("Lucro........:{0, 15:p}", profit);` -> indice + espaçamento + formatação %
