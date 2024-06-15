# Escribir un programa que pregunte al usuario por el número de horas trabajadas y el coste por hora.
#
# Después debe mostrar por pantalla la paga que le corresponde.

my_hours_work = input("Introduce un numero de horas ")
my_cost_hours = input("Introduce el coste por hora ")

my_calcule = int(my_hours_work) * int(my_cost_hours)

print(f"La paga es de {my_calcule} €")
