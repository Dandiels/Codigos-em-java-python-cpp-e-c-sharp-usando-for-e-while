número = float(input("Digite um número: "))
print("A tabuada de multiplicação de 1 à 10 deste número é:")
for multiplicador in range(1, 11): 
    print(f"{número:.6g} x {multiplicador} = {número * multiplicador:.6g}.")