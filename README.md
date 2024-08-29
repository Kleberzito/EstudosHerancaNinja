# Documentação do Projeto de Estudo de Herança

## Descrição
Este projeto é um exemplo de estudo de herança em C# utilizando personagens do anime Naruto. Foram criadas classes para representar diferentes clãs de ninjas, cada uma com suas características específicas.

## Estrutura do Projeto

### Classe Base: `Ninja`
A classe `Ninja` é a classe base para todos os ninjas. Ela contém propriedades comuns a todos os ninjas, como nome, idade e vila.

### Classe Derivada: `Haruno`
A classe `Haruno` herda de `Ninja` e adiciona uma propriedade específica: `AtivaSharingan`.

### Outras Classes Derivadas
Além da classe `Haruno`, foram criadas as classes `Uzumaki`, `Uchira` e `Hyuga`, cada uma com suas próprias características específicas. A estrutura básica dessas classes é similar à da classe `Haruno`.

## Exemplo de Uso
A classe `Program` demonstra como instanciar objetos das classes derivadas e exibir suas informações.

```csharp
class Program
{
    static void Main(string[] args)
    {
        Uzumaki Naruto = new Uzumaki("Naruto", 17, "Vila da Folha", true);
        Uchira Sasuke = new Uchira("Sasuke", 18, "Vila da Folha");
        Haruno Sakura = new Haruno("Sakura", 18, "Vila da Folha");
        Hyuga Hinata = new Hyuga("Hinata", 16, "Vila da Folha", true);

        Console.WriteLine(Naruto.ToString());
        Console.WriteLine(Sasuke.ToString());
        Console.WriteLine(Sakura.ToString());
        Console.WriteLine(Hinata.ToString());
    }
}
````

Para instanciar, as classes tem dois construtores onde você decide ao instanciar o objeto se a propriedade específica será ativado ou não com podemos ver no exemplo acima:
- Naruto e Hinata estão com o poder ativado
- Sasuke e Sakura não estão

Saida:
````prompt
Name:    Naruto Uzumaki
Age:     17
Village: Vila da folha
Clã:     Uzumaki
Naruto:  Ativado modo sábio.

Name:    Sasuke Uchira
Age:     18
Village: Vila da folha
Clã:     Uchira

Name:    Sakura Haruno
Age:     18
Village: Vila da folha
Clã:     Haruno

Name:    Hinata Hyuga
Age:     16
Village: Vila da folha
Clã:     Hyuga
Hinata:  Ativado Byakugan.
````

## Conclusão
Este projeto exemplifica o uso de herança em C# através da criação de classes que representam diferentes clãs de ninjas do anime Naruto. Cada classe derivada adiciona suas próprias características específicas, demonstrando como a herança pode ser utilizada para modelar hierarquias de classes em programação orientada a objetos.



