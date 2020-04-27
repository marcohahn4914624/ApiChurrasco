# Problema
Aqui na hammer organizamos um churras todos os meses,
**é necessario que cada funcionario contribua 20$ e se quiser levar um convidado 40$**.
 O problema é que não temos uma maneira para controlar quem irá no churrasco e quanto foi gasto com comida e bebida. 
**Um funcionário pode levar apenas um convidado,se você não beber,o valor do churrasco será metade,a mesma regra é valida para o convidado**.
Dado o problema é necessario desenvolver uma aplicação WebApi 
para consumo do nosso front.


INSTRUÇOES PARA TAREFAS DESAFIO
CRIEI UM SCRIPT DO BANCO JA COM DADOS SE PRECISAR PARA TESTE NOME s
USEI O POSTMAN PARA FAZER AS TAREFAS 
* Participar do Churrasco. funcionario Metodo Post Ex: formato Jason
  https://localhost:44303/api/funcionario		
     {
        "funcionario": "MARCIO",
        "consomE_BEBIDA": "N",
        "cancelado": "N"
    }	
* Participar do Churrasco. funcionario Metodo Post Ex: formato Jason
     https://localhost:44303/api/convidado
	 {
		"iD_FUNCIONARIO": 5.0,
		"nomE_CONVIDADO": "RENATO",
		"consomE_BEBIDAS": "S",
		"cancelado": "N"
	 }
	  Obs se tentar inseir um convidado de um mesmo funcionario duas vezes
	  retorno body = Funcionário com um comvidado já cadastrado
 
* Cancelar participação do Churrasco. funcionario Metodo Put Ex: formato Jason
     https://localhost:44303/api/funcionario/5 (5) é o id funcionario

* Cancelar participação do Churrasco. convidado Metodo Put Ex: formato Jason
     https://localhost:44303/api/convidado/6 (6) é o id convidado

* Total Arrecadado.	 Metodo Get Ex: formato Jason
	 https://localhost:44303/api/TotalArrecadado
	 Obs somante dos registros que não estão cancelados

* Listar Participantes. Metodo Get Ex: formato Jason 
	 https://localhost:44303/api/funcionario
	 Obs somante dos registros que não estão cancelados e entendi que era os funcionarios

* Listar Convidados. Metodo Get Ex: formato Jason
     https://localhost:44303/api/convidado
	 Obs somante dos registros que não estão cancelado

* Total Gasto. Metodo Get Ex: formato Jason	 
	 https://localhost:44303/api/gasto/totalgasto

* Total Gasto em Comida. Metodo Get Ex: formato Jason	
	 https://localhost:44303/api/gasto/totalcomida	
 
* Total Gasto em Bebida. Metodo Get Ex: formato Jason	
     https://localhost:44303/api/gasto/totalbebida
