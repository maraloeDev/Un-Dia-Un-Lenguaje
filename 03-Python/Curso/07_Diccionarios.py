# Diccionarios estructura para almacenar datos C/V

my_dict= {}
my_other_dict = {}
                  #CLAVE   #VALOR     CLAVE         VALOR           CLAVE  VALOR
my_other_dict = {"Nombre":"Eduardo", "Apellido": "Martin-Sonseca", "Edad": 24, 1 : "Python"}

my_dict = {
    "Nombre":"Eduardo",
    "Apellido": "Martin-Sonseca",
    "Edad": 24,
    "Lenguajes" : {"PythAon", "Kottlin", "HTML"},
    1 :1.77
        }


print(my_dict)
print(my_other_dict)
print(len(my_other_dict))
print(len(my_dict))

print(my_dict["Apellido"])

del my_dict[0]
print(my_dict)


print(my_dict)