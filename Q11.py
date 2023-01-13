nome = list(range(10))
idade = list(range(10))
vezes = 1
for i in range(0, len(nome)):
    nome[i] = input(f"Digite o nome da {vezes}ª pessoa: ")
    idade[i] = int(input("Digite a idade dela: "))
    vezes += 1
i = 0
n = 0
while i <= len(idade) - 1:
    if idade[i] <= idade[n]:
        if n == len(idade) - 1:
            break
        else:
            n += 1
    else:
        n = 0
        i += 1
print(f"Dentre essas pessoas, a pessoa mais nova é {nome[i]}.")