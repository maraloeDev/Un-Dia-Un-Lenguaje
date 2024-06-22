# Excepciones
numer_one = 99
numer_two = 14
numer_tree = "14"

# Try Except
try:

    print(numer_one + numer_two)
    print("No se ha producido un error")
except:
    print("Se ha producido un error")


# Try Except else
try:
    print(numer_one + numer_two)
    print("No se ha producido un error")
except:
    print("Se ha producido un error")

else:
    print("La ejecucion continua")

# Try Except else finally
try:
    print(numer_one + numer_two)
    print("No se ha producido un error")
except:
    print("Se ha producido un error")

else:
    print("La ejecucion continua correctamente")

finally: #Se ejecuta siempre
    print("La ejecucion continua")


# Excepciones por tipo
try:

    print(numer_one + numer_two)
    print("No se ha producido un error")
except TypeError:
    print("Se ha producido un error")