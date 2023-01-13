número = list(range(10))
vezes = 1
soma = 0 
for i in range(0, len(número)):
    número[i] = float(input(f"Digite o {vezes}° número: "))
    soma = soma + número[i]
    vezes += 1
print(f"A soma dos 10 números que você digitou é {soma:.6g}.")