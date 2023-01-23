# ApiCep
Este código é uma aplicação ASP.NET Core que utiliza o framework ApiMinima. 
Ele usa a classe WebApplication para criar um construtor e adiciona vários serviços à aplicação, como DbContext, autorização,
exploração de pontos de extremidade da API e geração de documentação do Swagger. O banco de dados é configurado para usar o banco de dados In-Memory e a tabela é chamada "EnderecoList".

A aplicação verifica se está em um ambiente de desenvolvimento e, se sim, habilita a página de exceção do desenvolvedor. Ele também configura o uso do Swagger e cria dois mapeamentos de rota: um para o recurso "Endereco Cep" que faz uma chamada à API externa "viacep.com.br" e outro para o recurso "Inserir endereco" que permite inserir um novo endereço no banco de dados. Por fim, ele também habilita a interface do usuário do Swagger e inicia a execução da aplicação.
