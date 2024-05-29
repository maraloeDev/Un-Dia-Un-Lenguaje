# String

my_string ="Mi String"
my_other_string ='Mi otro String'

print(len(my_string))
print(len(my_other_string))

print(my_string + " " + my_other_string)

my_newline_string ="Este en un string\ncon salto de linea"
print(my_newline_string)

my_tab_string ="\tEste en un string con salto de tabulacion"
print(my_tab_string)

my_scape_string ="\tEste en un string con un \n escapado"
print(my_scape_string)

# Formateo

name, surname, age = "Eduardo", "Martin-Sonseca", 24

print(f"Mi nombre es {name} y mi edad es {age}")

# Desenpaquetando caracteres

lenguage ="Python"
a, b, c, d, e, f =lenguage
print(a)
print(b)
print(c)
print(d)
print(e)
print(f)

# Division
lenguaje_slice = lenguage[1:3]
print(lenguaje_slice)

lenguaje_slice = lenguage[1:]
print(lenguaje_slice)

lenguaje_slice = lenguage[-2]
print(lenguaje_slice)

lenguaje_slice = lenguage[1:2:4]
print(lenguaje_slice)

 #Reversed
reversed_lenguaje = lenguage[::-1]
print(reversed_lenguaje)

# Funciones

print("La primera en mayuscula ",lenguage.capitalize())
print("Todo en mayuscula ",lenguage.upper())
print("Cuantas letras t hay?",lenguage.count("t"))
print("El numero 1 es un numero?", "1".isnumeric())
print("Todo en minusculas ",lenguage.lower())
print("La letra Python esta en mayuscula? ",lenguage.upper().isupper())
print("Python empieza por Py ", lenguage.startswith("Py"))


