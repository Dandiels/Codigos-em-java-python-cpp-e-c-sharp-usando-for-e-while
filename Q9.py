idade = list(range(20))
vezes = 1
soma = 0 
for i in range(0, len(idade)):
    idade[i] = int(input(f"Digite a {vezes}ª idade: "))
    soma = soma + idade[i]
    vezes += 1
média = int(soma / 20)
print(f"A média das 20 idades que você digitou é {média} anos.")