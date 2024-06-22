# List Comp_rehension sirve para crear listas de formas comprimidas

my_original__list = [0, 1, 2, 3, 4, 5, 6, 7]
print(my_original__list)

my_range = range(8)
print(list(my_range))

my_list = [i + 1 for i in range(8)]  # TSe le suma 1 a la lista
print(my_list)

my_list = [i * 2 for i in range(8)]  # Se le multiplica por 2 a la lista
print(my_list)

my_list = [i * i for i in range(8)]  # Se multiplica por si misma
print(my_list)


def sum_five(number):
    return number + 5


my_list = [sum_five(i) for i in range(8)]  # Modificas el valor antes de guardarlo
print(my_list)