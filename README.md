# APLICATIVO VOLTADO A CLÍNICA VETERINÁRIA

  Projeto produzido pelo aluno Alexandro Fuchs na disciplina de Programação Orientada a Objetos no ano de 2019 - 1º Semestre do Curso de Ciência da Computação, da Universidade Tecnológica Federal do Paraná - UTFPR Medianeira e sob a orientação do professor Everton Coimbra de Araújo.

  O aplicativo foi desenvolvido em C# utilizando o Visual Studio Community 2017 (v15.9.14). Para o banco de dados, foi utilizado o ORM (Mapeamento Objeto-Relacional) do Entity framework Core (v2.2.4), usando o SQL Server.

# Instalação do Visual Studio Community

* Acesse https://visualstudio.microsoft.com/pt-br/downloads/, selecione a plataforma utilizada (Windows ou MacOS) e clique em "Download Gratuito"; 
* Instale normalmente, conforme as instruções que seguirem;

# Instalação da Aplicação

* Vá para https://github.com/alexandrofuchs/APP_VET;
* Clique em "Clone or download" e "Download ZIP";
* Descompacte o arquivo baixado e abra a pasta "APP_VET";
* O arquivo principal é o "APP_VET.sln";

# Configuração e execução

* Com o Visual Studio Community e a aplicação baixados, Abra o arquivo "APP_VET.sln", que está na pasta "APP_VET";
* Clique em "Iniciar" (ou F5 no teclado) para compilar e executar a aplicação;

# Conteúdo do repositório
O repositório contém as pastas:

* Apresentacao: Camada do projeto onde se encontram as Telas(Interfaces) feitas com Windows Forms, que compoem o sistema;
* Modelo: Camada onde encontram-se o modelo de negócio do sistema, as classes(Entidades) do projeto;
* Persistencia: Camada onde encontram-se as Classes referente a conexão com o Banco de Dados(Entity Framework Core com SQL server)  como também sua configuração de conexão e as classes referente a operações e métodos para repositório no banco de dados;
* Servico: Camada responsavel por fazer a conexão entre a camada de Apresentação e Persistência, onde também são feitas as Validações dos dados capturados na camada de Apresentação;
* APP_VET.sln: Inicializador da Aplicação(Solução);
# IMPORTANTE
* Não foram feitos testes da aplicação em um ambiente real, não havendo portando nenhuma garantia de sua estabilidade.
# Dúvidas ou Sugestões
* Alexandro Fuchs -  aalexandroffuchs@gmail.com;
