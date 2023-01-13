idade = list(range(20))
vezes = 1
pessoas = 0
for i in range(0, len(idade)):
    idade[i] = int(input(f"Digite a {vezes}ª idade: "))
    if idade[i] >= 18:
        pessoas += 1
    vezes += 1
match pessoas:
    case 0:
        print("Das 20 idades que você digitou, nenhuma delas são de pessoas maiores de idade.")
    case 20:
        print("Das 20 idades que você digitou, todas elas são de pessoas maiores de idade.")
    case _:
        print(f"Das 20 idades que você digitou, {pessoas} delas são de pessoas maiores de idade.")