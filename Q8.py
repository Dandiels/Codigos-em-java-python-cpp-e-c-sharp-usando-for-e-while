idade = list(range(20))
vezes = 1
soma = 0 
for i in range(0, len(idade)):
    idade[i] = int(input(f"Digite a {vezes}ª idade: "))
    soma = soma + idade[i]
    vezes += 1
print(f"A soma das 20 idades que você digitou é {soma} anos.")