# 1. Introdução
O projeto ScreenSound foi desenvolvido em C# com o objetivo de estudar as particularidades da linguagem. O sistema possui classes no diretório Modelos para representar músicas e listas de músicas preferidas, além de classes no diretório Filtros para realizar operações de filtragem e ordenação nas músicas. O arquivo Program.cs na raiz do projeto contém o código principal que utiliza essas classes para interagir com uma API de músicas.

# 2. Modelos

## Classe Musica
A classe Musica representa uma música e possui os seguintes atributos:

### **Atributos**:
- **Nome**: Nome da música.
- **Artista**: Nome do artista da música.
- **Duracao**: Duração da música em milissegundos.
- **Genero**: Gênero musical da música.
- **Key**: Índice da tonalidade da música.
- **Tonalidade**: Propriedade apenas de leitura que retorna a tonalidade da música com base na chave.

### **Métodos**:
- *ExibirDetalhesDaMusica()*: Exibe os detalhes da música no console.

## Classe MusicasPreferidas
A classe MusicasPreferidas representa uma lista de músicas favoritas associadas a um nome. Possui os seguintes atributos:

### **Atributos**:
- **Nome**: Nome da lista de músicas preferidas.
- **ListaDeMusicasFavoritas**: Lista das músicas favoritas.

### **Métodos**:
- **AdicionarMusicasFavoritas(Musica musica)**: Adiciona uma música à lista de músicas favoritas.
- **ExibirMusicasFavoritas()**: Exibe as músicas favoritas no console.
- **GerarArquivoJson()**: Gera um arquivo JSON contendo as informações da lista de músicas favoritas.


# 3. Filtros:
## **Classe LinqFilter**
A classe LinqFilter contém métodos estáticos para filtrar músicas com base em diferentes critérios. Métodos disponíveis:

### **Métodos**:
- *FiltrarTodosOsGenerosMusicais(List<Musica> musicas)*: Filtra e exibe todos os gêneros musicais distintos.
- *FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)*: Filtra e exibe artistas por gênero musical.
- *FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)*: Filtra e exibe músicas de um artista específico.


## **Classe LinqOrder**
A classe LinqOrder contém métodos estáticos para ordenar e exibir listas de artistas. Métodos disponíveis:

### **Métodos**:
*ExibirListaDeArtistaOrdenados(List<Musica> musicas)*: Ordena e exibe a lista de artistas em ordem alfabética.


# 4. Program
O arquivo Program.cs na raiz do projeto utiliza as classes mencionadas acima para interagir com uma API de músicas. O código faz solicitações HTTP, deserializa a resposta em uma lista de músicas e realiza operações de filtragem e ordenação.

# 5. Diagrama de Classes UML

+------------------+        +---------------------+        +-------------------+
|     Musica       |        | MusicasPreferidas   |        |    LinqFilter     |
+------------------+        +---------------------+        +-------------------+
| - tonalidades[]  |        | - Nome              |        | + FiltrarTodos... |
| + Nome           |        | - ListaDeMusicas... |        | + FiltrarArtist... |
| + Artista        |        | + AdicionarMusic... |        | + FiltrarMusicas...|
| + Duracao        |        | + ExibirMusicasF... |        +-------------------+
| + Genero         |        | + GerarArquivoJson()| 
| + Key            |        +---------------------+
| + Tonalidade     |
| + ExibirDetalhe...
+------------------+

+------------------+
|   LinqOrder      |
+------------------+
| + ExibirListaDe...
+------------------+

# 6. Conclusão
O projeto ScreenSound apresenta uma estrutura organizada, seguindo boas práticas da arquitetura limpa e de codificação em C#. A utilização de classes bem definidas e métodos específicos facilita a manutenção e extensão do código. A integração com uma API de músicas e a aplicação de filtros e ordenações demonstram a aplicação prática dos conceitos estudados. O uso adequado de namespaces e modificadores de acesso contribui para a encapsulação e modularidade do código.