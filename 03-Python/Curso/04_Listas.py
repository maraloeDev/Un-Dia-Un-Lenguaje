# Listas proporciona ordenadiones, reverse...

my_list = list()
my_other_list= []

print(len(my_list))

my_list = [24,34,56,78,12]
print(my_list)
print(len(my_list))

#Da igual el tipo de dato que se guarde
my_other_list = [24, 1.85, "Eduardo", 24,42]
print(my_other_list)
print(type(my_other_list))

## Acceso a elementos

print(my_other_list[0])
print(my_other_list[1])
print(my_other_list.count(24)) # Cuantas veces aparece
age, height, name, age, age = my_other_list
print(name)

print(my_list + my_other_list)

my_other_list.append("Papa")
print(my_other_list)

my_other_list.insert(0, "LOS GALLOS")
print(my_other_list)

my_other_list.remove("LOS GALLOS")
print(my_other_list)

print(my_list)

my_pop_element = my_list.pop(2) #Pop es para eliminar un valor
print(my_pop_element)
print(my_list)


#remove elimina el elemento
#del elimina por indice

del my_list[2]
print(my_list)

#Copia la lista
my_new_list = my_list.copy()

#Limpia la lista
my_list.clear()
print(my_list)
print(my_new_list)

#Da la vuelta a la lista
my_new_list.reverse()
print(my_new_list)

#Ordena la lista
my_new_list.sort()
print(my_new_list)
