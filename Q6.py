nome = input("Digite o seu nome: ")
número_de_vezes = int(input("Digite a quantidade de vezes que deseja que o seu nome apareça na tela: "))
vezes = 1
for contador in range(0, número_de_vezes):
    print(f"{vezes}ª Vez: {nome}.")
    vezes += 1