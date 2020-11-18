# Classes

* É um tido de dado composto por membros, ou seja, por atributos e metodos.

```
[modificadorClasse] class NomeClasse
{
    // variaveis - atributos
    [especificadorAcesso] tipo NomeAtributo;

    // Método
    [especificadorAcesso] retorno NomeMetodo ([arg1, ...]) {}
}
```

# Objeto

* A classe define a base do objeto.
* É possível criar varios objetos através de uma classe.
* Usa o operador `new` para instanciar umaClasse.

### ModificadorClasse

+ `public` - Pública, sem restrição de acesso.
+ `abstract` - Classe-Base para outras classes, não podendo ser instancidas para um objeto.
+ `sealed` - Classe não pode ser herdada.
+ `static` - Classe não permite a instanciação de objetos e seus menbros devem ser estaticos.

### ModificadoresAcesso

+ `public` - Sem restrição de acesso.
+ `private` - Só pode ser acessada pela própria classe.
+ `protected` - Podem ser acessados na própria classe e nas classes derivadas.
+ `abstract` - Os métodos não tem implementação, somente cabeçalho.
+ `sealed` - O método não pode ser redefinido.
+ `virtual` - O método pode ser definido em uma classe derivada.
+ `static` = O método pode ser chamado mesmo sem a instanciação de um objeto.
