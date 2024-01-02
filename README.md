# Exercicio Proposto Métodos Abstratos (Curso P.O.O Nélio Alves)


# Sobre o projeto

Solução para exercício proposto sobre Metódos Abstratos do curso de P.O.O de Nélio Alves

Capítulo 10: Herança e Polimorfismo

## Enunciado do desafio
<p>Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais 
podem ser pessoa física ou pessoa jurídica, e depois mostrar o valor do imposto pago por cada um, 
bem como o total de imposto arrecadado. 
Os dados de pessoa física são: nome, renda anual e gastos com saúde. Os dados de pessoa jurídica 
são nome, renda anual e número de funcionários. As regras para cálculo de imposto são as 
seguintes:
Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. Pessoas com 
renda de 20000.00 em diante pagam 25% de imposto. Se a pessoa teve gastos com saúde, 50% 
destes gastos são abatidos no imposto. 
Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto 
fica: (50000 * 25%) - (2000 * 50%) = 11500.00
Pessoa jurídica: pessoas jurídicas pagam 16% de imposto. Porém, se a empresa possuir mais de 10 
funcionários, ela paga 14% de imposto. 
Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica: 
400000 * 14% = 56000.00<p/>

## Saída esperada
Enter the number of tax payers: **3**<br />
Tax payer #1 data:<br />
Individual or company (i/c)? **i**<br />
Name: **Alex**<br />
Anual income: **50000.00**<br />
Health expenditures: **2000.00**<br />
Tax payer #2 data:<br />
Individual or company (i/c)? **c**<br />
Name: SoftTech<br />
Anual income: **400000.00**<br />
Number of employees: **25**<br />
Tax payer #3 data:<br />
Individual or company (i/c)? **i**<br />
Name: **Bob**<br />
Anual income: **120000.00**<br />
Health expenditures: **1000.00**<br />
TAXES PAID:<br />
Alex: **$ 11500.00**<br />
SoftTech: **$ 56000.00**<br />
Bob: **$ 29500.00**<br />
TOTAL TAXES: **$ 97000.00**<br />

## Modelo conceitual
![UMLMetodosAbstratos](https://github.com/luizsilva132/ExercicioPropostoResolvidoMetodosAbstratos-POONelioAlves/assets/112888865/852167ec-35da-41b3-af3b-743afb9d475d)

# Tecnologias utilizadas
- P.O.O
- C#
  
# Autor

Luiz Henrique Rosa Da Silva

https://www.linkedin.com//in/luiz-henrique-rosa-da-silva-7982a2248
