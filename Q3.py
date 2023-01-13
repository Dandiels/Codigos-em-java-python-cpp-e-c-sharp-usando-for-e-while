num1 = int(input("Digite um número maior ou igual à 0: "))
if num1 < 0:
    print("Você deve digitar um número maior ou igual à 0.")
else:
    num2 = int(input("Digite outro número também maior ou igual à 0: "))
    if num2 < 0:
        print("Você deve digitar um número maior ou igual à 0.")
    else:
        soma = 0
        for contador in range(0, num2):
            soma = soma + num1
        print(f"O resultado da multiplicação entre estes dois números, através de somas repetidas, é {soma:,}.")