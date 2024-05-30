# Diccionarios estructura para almacenar datos C/V

my_dict = {}
my_other_dict = {}
#CLAVE   #VALOR     CLAVE         VALOR           CLAVE  VALOR
my_other_dict = {"Nombre": "Eduardo", "Apellido": "Martin-Sonseca", "Edad": 24, 1: "Python"}

my_dict = {
    "Nombre": "Eduardo",
    "Apellido": "Martin-Sonseca",
    "Edad": 24,
    "Lenguajes": {"Python", "Kotlin", "HTML"},
    1: 1.77
}

print(my_other_dict)
print(my_dict)

print(len(my_dict))
print(len(my_other_dict))

print(my_dict["Nombre"])

print(my_dict[1])

my_dict["Calle"] = "Calle de micasa"
print(my_dict)

# Eliminar elementos de un diccionario
del my_dict["Calle"]
print(my_dict)

# A la hora de buscar algo, se usa 'in' para buscar por CLAVE

print("Nombre" in my_dict)  #CLAVE
print("Eduardo" in my_dict)  #VALOR

print(my_dict.items())  # Recoje todo el diccionario
print(my_dict.keys())  # Recoje solo Claves
print(my_dict.values())  # Recoje solo Valores

my_list = ["Nombre", 1, "Piso"]

my_new_dict = dict.fromkeys(my_list)  # Creacion de un nuevo dict
print(my_new_dict)

my_new_dict = dict.fromkeys(my_dict)  # Creacion de un nuevo dict
print(my_new_dict)

my_new_dict = dict.fromkeys(my_dict, "Eduardo")  # Creacion de un nuevo dict
print(my_new_dict)

print("Lista: ", list(my_new_dict))
print("Tupla: ", tuple(my_new_dict))
print("Set: ", set(my_new_dict))
