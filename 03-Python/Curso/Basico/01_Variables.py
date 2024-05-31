# Variables

my_string_variable = "My String Variable"
print(my_string_variable)

my_int_variable = 5
print(my_int_variable)

my_int_to_str_variable = str(my_int_variable)  # Casteo
print(my_int_to_str_variable)
print(type(my_int_to_str_variable))

my_bool_variable = True
print(my_bool_variable)

# Concatenacion de variables en un print
print(my_string_variable, str(my_int_variable), my_bool_variable)
print("Este es mi valor de : ", my_bool_variable)

# Algunas funciones del sistema
print(len(my_string_variable))  # Es la longitud de un objeto

# Variables en una sola linea
name, surname, alias, age = "Eduardo", "Martin-Sonseca", "maraloedev", 24
print("Me llamo ", name, surname, ".Mi edad es", age, " .Y mi alias es ", alias)

"""

Introducir datos desde el teclado
name = input("¿Cual es tu nombre? ")
age = input("¿Cual es tu edad? ")
print("Tu nombre es ", name, " y tu edad es ", age)

"""

# Cambio de tipos
name = 24
age = "Eduardo"

print(name)
print(age)

# Forzamos el tipo
my_adress: str = "Mi direccion"
my_adress = 24
print(my_adress)
