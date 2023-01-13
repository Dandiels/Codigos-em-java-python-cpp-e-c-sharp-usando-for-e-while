número = list(range(20))
vezes = 1
quantidade = 0
for i in range(0, len(número)):
    número[i] = float(input(f"Digite o {vezes}° número: "))
    if número[i] > 8:
        quantidade += 1
    vezes += 1
match quantidade:
    case 0:
        print("Dos 20 números que você digitou, nenhum deles é maior do que 8.")
    case 20:
        print("Dos 20 números que você digitou, todos eles são maiores do que 8.")
    case _:
        print(f"Dos 20 números que você digitou, {quantidade} deles são maiores do que 8.")