# ms-blacklist-email-sender

Seja bem-vindo!

  Este é um serviço feito para disparar emails incetivados via mensagens, existe a implementação tanto do consumer quanto do producer de um tópico utilizando Kafka.
  É necessário adicionar um email e uma senha de email válida dentro do arquivo Consts.cs, e verificar em qual url está rodando a sua instância do Kafka e adicionar 
neste mesmo arquivo.
    Este projeto foi idealizado para trabalhar em conjunto com outro microsserviço que será o responsável pelo gerenciamento de candidatos adicionados a uma plataforma.
    Foi utilizado o .NET6 para desenvolvimento, as principais libs utilizadas, foram a de SMTP do próprio .NET e a Confluent.Kafka. Tanto o Kafka quanto o Zookeeper estão 
  rodando em containers docker localmente.
    Este projeto não está totalmente genérico e existe muito espaço para melhorias.
   
   Sinta-se a vontade para contribuir :)
