número = list(range(20))
vezes = 1
quantidade = 0
for i in range(0, len(número)):
    número[i] = float(input(f"Digite o {vezes}° número: "))
    if número[i] >= 0 and número[i] <= 100:
        quantidade += 1
    vezes += 1
match quantidade:
    case 0:
        print("Dos 20 números que você digitou, nenhum deles está entre 0 e 100.")
    case 20:
        print("Dos 20 números que você digitou, todos eles estão entre 0 e 100.")
    case _:
        print(f"Dos 20 números que você digitou, {quantidade} deles estão entre 0 e 100.")