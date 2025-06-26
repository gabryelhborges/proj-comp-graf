# ProcessamentoImagens

Um projeto de computação gráfica desenvolvido em C# Windows Forms para processamento e manipulação de imagens.

## 📋 Sobre o Projeto

Este projeto foi desenvolvido como parte das atividades da disciplina de Computação Gráfica, implementando funcionalidades de processamento de imagens, aplicação de filtros e manipulação gráfica através de uma interface desktop intuitiva.

## 🚀 Funcionalidades

- **Manipulação de Polígonos**: Criação e edição de formas geométricas
- **Preenchimento**: Algoritmos de preenchimento de áreas
- **Interface Gráfica**: Interface desktop amigável desenvolvida em Windows Forms

![image](https://github.com/user-attachments/assets/8d59b1e7-8dd9-4153-b21d-768b379a1488)

## 🛠️ Tecnologias Utilizadas

- **C#**: Linguagem de programação principal
- **Windows Forms**: Framework para interface gráfica
- **.NET Framework**: Plataforma de desenvolvimento
- **Visual Studio**: IDE de desenvolvimento

## 📁 Estrutura do Projeto

```
ProcessamentoImagens/
├── ProcessamentoImagens.sln      # Arquivo de solução
├── white.jpg                     # Imagem de exemplo
├── ProcessamentoImagens/
│   ├── Program.cs               # Ponto de entrada da aplicação
│   ├── frmPrincipal.cs          # Formulário principal
│   ├── Poligono.cs              # Classes para manipulação de polígonos
│   ├── Preenchimento.cs         # Algoritmos de preenchimento
│   ├── ListBoxItem.cs           # Item customizado para ListBox
│   └── Properties/              # Propriedades e recursos do projeto
└── README.md
```

## 🔧 Como Executar

### Pré-requisitos

- Visual Studio 2019 ou superior
- .NET Framework 4.0 ou superior
- Windows 7 ou superior

### Passos para execução

1. **Clone o repositório**
   ```bash
   git clone https://github.com/seu-usuario/proj-comp-graf.git
   cd proj-comp-graf
   ```

2. **Abra o projeto**
   - Abra o arquivo `ProcessamentoImagens.sln` no Visual Studio

3. **Compile e execute**
   - Pressione `F5` ou clique em "Iniciar" no Visual Studio
   - Ou compile via terminal:
     ```bash
     msbuild ProcessamentoImagens.sln
     ```

## 📱 Como Usar

1. **Carregamento de Imagens**: Use o menu principal para carregar imagens nos formatos suportados
3. **Manipulação de Polígonos**: Utilize as ferramentas de desenho para criar formas geométricas
4. **Preenchimento**: Aplique algoritmos de preenchimento nas áreas selecionadas

## 🎯 Módulos Principais

### [`Poligono.cs`](ProcessamentoImagens/Poligono.cs)
Gerencia a criação e manipulação de polígonos:
- Desenho de formas geométricas
- Cálculos de área e perímetro
- Transformações geométricas

### [`Preenchimento.cs`](ProcessamentoImagens/Preenchimento.cs)
Implementa algoritmos de preenchimento:
- Flood fill
- Boundary fill
- Preenchimento com padrões
