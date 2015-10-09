# randomText
Chars Randomicos
randomText.dll
Versão 1.0
Status: Finalizado.

# Funcionamento
implemente a dll da seguinte forma

# Opções e parametros
Para utilizar o metodo randomName é preciso informar 2 valores int sendo o primeiro deles a opção escolhida e o segundo o tamanho da string a ser retornada.

Opção 1 = abcdefghijklmnopqrstuvxywz
Opção 2 = ABCDEFGHIJKLMNOPQRSTUVXYWZ
Opção 3 = abcdefghijklmnopqrstuvxywzABCDEFGHIJKLMNOPQRSTUVXYWZ
Opção 4 = 0123456789
Opção 5 = 0123456789abcdefghijklmnopqrstuvxywz
Opção 6 = 0123456789abcdefghijklmnopqrstuvxywzABCDEFGHIJKLMNOPQRSTUVXYWZ
Opção 7 = !@#$%¨&*()_+-=´[`{ª^~}]º/°?;:.>,<|¹²³£¢¬§

por exemplo se eu informar randomname(1,3) terei um retorno aleatorio de 3 caracteres da opção 1,se eu informar randomName(4,10) terei um retorno de 10 caracteres da opção 4.

# Exemplo de implementação

importe a dll randomString da seguinte forma
![Exemplo] (http://s12.postimg.org/y12n93765/image.png)

crie o metodo  CaracterRandom
![Exemplo] (http://s15.postimg.org/8d4fpv6l7/image.png)


chame a classe randomName informando os parametros, atribuindo o resultado ao componente que desejar.

![Exemplo] (http://s29.postimg.org/9wrwhx6ef/image.png)
