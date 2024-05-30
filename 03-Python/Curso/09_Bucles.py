# Bucles

# While

print("WHILE")
my_condition = 0

while my_condition < 10:
    print(my_condition)
    my_condition += 2

else:  # es opcional
    print("Es mayor o igual que 10")

print("La ejecucion continua")

while my_condition < 20:
    my_condition += 1

    if my_condition == 15:
        print("Mi condicion es 15")
        break
    print(my_condition)

    # For
print("FOR")
my_list = [24, 45, 78, 41, 52]

for my_item in my_list:
    print(my_item)

    my_dict = {
        "Nombre": "Eduardo",
        "Apellido": "Martin-Sonseca",
        "Edad": 24,
        "Lenguajes": {"Python", "Kotlin", "HTML"},
        1: 1.77
    }

for my_item1 in my_dict:
    print(my_item1)
    if my_item1 == "Edad":
        break
    print("Se ejecuta")

else:
    print("El bucle del diccionario ha parado")

for my_item1 in my_dict:
    print(my_item1)
    if my_item1 == "Edad":
        continue
    print("Se ejecuta")
else:
    print("El bucle del diccionario ha parado")