número = int(input("Digite um número maior do que 0: "))
if número > 0:
    ordem = int(input("Digite 1 para ordem crescente ou 2 para ordem decrescente: "))
    if ordem == 1:
        número -= 1
        print("A ordem crescente do zero até este número é ", end = '')
        for listagem in range(0, número):
            print(f"{listagem}, ", end = '')
        print(f"{número} e {número + 1}.")
    elif ordem == 2:
        print("A ordem decrescente deste número até zero é ", end = '')
        for listagem in range(0, número - 1):
            listagem = número - listagem
            print(f"{listagem}, ", end = '')
        print(f"1 e 0.")
    else:
        print("Você deve digitar um dos valores pedidos.")
else:
    print("Você deve digitar um número maior do que 0.")