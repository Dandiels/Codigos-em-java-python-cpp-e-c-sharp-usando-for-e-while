i = 0
soma = 0
print("Digite uma sequência de números:")
while i >= 0:
    número = float(input())
    soma = soma + número
    if número < 0:
        break
print(f"A soma dos números que você digitou, até o número negativo, é {soma:.6g}.")