número = list(range(20))
vezes = 1
quantidade = [0, 0, 0]
for i in range(0, len(número)):
    número[i] = float(input(f"Digite o {vezes}° número: "))
    if número[i] >= 0 and número[i] <= 100:
        quantidade[0] += 1
    elif número[i] >= 101 and número[i] <= 200:
        quantidade[1] += 1
    elif número[i] > 200:
        quantidade[2] += 1
    vezes += 1
if quantidade[0] + quantidade[1] + quantidade[2] == 19:
    print(f"Entre 0 e 100: {quantidade[0]}, entre 101 e 200: {quantidade[1]} e maiores do que 200: {quantidade[2]}.")
    print("O número restante é menor do que 0.")
elif quantidade[0] + quantidade[1] + quantidade[2] < 19:
    print(f"Entre 0 e 100: {quantidade[0]}, entre 101 e 200: {quantidade[1]} e maiores do que 200: {quantidade[2]}.")
    print("Os números restantes são menores do que 0.")
else:
    print(f"Entre 0 e 100: {quantidade[0]}, entre 101 e 200: {quantidade[1]} e maiores do que 200: {quantidade[2]}.")