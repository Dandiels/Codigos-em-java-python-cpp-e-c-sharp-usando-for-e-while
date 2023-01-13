número = int(input("Digite um número maior do que 0: "))
if número > 0:
    acumulador = 0
    print("A soma dos números entre zero e este número é ", end = '')
    for contador in range (0, número):
        acumulador = acumulador + contador
    print(f"{acumulador:,}.")
else:
    print("Você deve digitar um número maior do que 0.")