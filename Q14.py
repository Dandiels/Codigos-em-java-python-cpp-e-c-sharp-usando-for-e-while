número = list(range(20))
vezes = 1
quantidade = 0
for i in range(0, len(número)):
    número[i] = int(input(f"Digite o {vezes}° número: "))
    if número[i] % 2 == 0:
        quantidade += 1
    vezes += 1
match quantidade:
    case 0:
        print("Dos 20 números que você digitou, nenhum deles é par.")
    case 20:
        print("Dos 20 números que você digitou, todos eles são pares.")
    case _:
        print(f"Dos 20 números que você digitou, {quantidade} deles são pares.")